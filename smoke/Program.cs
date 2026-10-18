using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SMSPool.Api;
using SMSPool.Client;

var config = new Configuration { BasePath = "https://api.smspool.net" };
var api = new InformationApi(config);
var countries = api.CountryRetrieveAll() as JArray ?? throw new Exception("no countries");
if (countries.Count == 0) throw new Exception("no countries");
Console.WriteLine($"countries: {countries.Count} {countries[0].ToString(Formatting.None)}");
var rates = api.RequestSuccessRate("1") ?? throw new Exception("no success rates");
var ratesJson = JsonConvert.SerializeObject(rates);
Console.WriteLine($"success_rate (form POST): {ratesJson.Substring(0, Math.Min(80, ratesJson.Length))}");

var authed = new InformationApi(new Configuration { BasePath = "https://api.smspool.net", AccessToken = new string('0', 32) });
try {
    authed.RequestBalance();
    throw new Exception("expected an auth error");
} catch (ApiException e) when (e.ErrorCode == 401 || e.ErrorCode == 403) {
    var body = e.ErrorContent?.ToString() ?? "";
    Console.WriteLine($"bad key -> {e.ErrorCode} {body.Substring(0, Math.Min(80, body.Length))}");
}
Console.WriteLine("CSHARP OK");
