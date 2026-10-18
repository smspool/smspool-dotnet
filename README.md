# SMSPool .NET (C#) SDK

Official .NET (C#) client for the [SMSPool API](https://api.smspool.net/docs): one-time SMS
verification numbers, rentals, pre-orders, eSIMs and more.

Package: [`SMSPool`](https://www.nuget.org/packages/SMSPool) on NuGet.

## Install

```bash
dotnet add package SMSPool
```

## Quick start

Get your API key from [your settings page](https://www.smspool.net/my/settings).

```csharp
using SMSPool.Api;
using SMSPool.Client;

var config = new Configuration { AccessToken = "YOUR_API_KEY" };
Console.WriteLine(new InformationApi(config).RequestBalance());
var countries = new InformationApi(config).CountryRetrieveAll();
var order = new SMSApi(config).PurchaseSms(service: "1", country: "US");
```

Responses are Newtonsoft.Json values (`JObject` / `JArray`). Errors (HTTP 4xx/5xx) throw
`SMSPool.Client.ApiException`, with `ErrorCode` and `ErrorContent`. Targets .NET 8 and .NET Standard 2.0.

## Calling endpoints

Every endpoint in the [API reference](https://api.smspool.net/docs) is a method named after
its path, on the class for its section: `/sms/check` is `SmsCheck()` on `SMSApi`. Endpoints that need
your API key send it as a bearer token.

Responses are returned as decoded JSON exactly as the API sends them: many endpoints answer
`200` with `"success": 0` and a `message` when a request is refused, so check `success`.

- Generated reference for every method and parameter: [`docs/`](docs/)
- API reference with examples: https://api.smspool.net/docs

## How this SDK is made

The code is generated from the API's OpenAPI spec
([openapi.json](https://api.smspool.net/openapi.json)) with
[OpenAPI Generator](https://openapi-generator.tech). Do not edit generated files by hand:
a workflow regenerates them every week and opens a pull request when the API changed.
Hand-written files are listed in `.openapi-generator-ignore`.

## Releasing (maintainers)

1. Set the new version in `openapi-generator.yaml` (`packageVersion`).
2. Run `scripts/generate.sh` (needs Docker) and `scripts/smoke.sh`, then commit.
3. Tag and push: `git tag vX.Y.Z && git push origin vX.Y.Z`.

The Release workflow checks the tag against the version, runs the smoke test and publishes.
Publishing needs the `NUGET_API_KEY` secret (a nuget.org API key scoped to `SMSPool`).

## License

MIT
