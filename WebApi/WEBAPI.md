# HireMe WebApi

RESTful WebApi with CRUD endpoints to interact with HireMe data.

## Environment variables

| Variable                  | Description         | Type                        | Example     |
| ------------------------- | ------------------- | --------------------------- | ----------- |
| ASPNETCORE_ENVIRONMENT    | ASP.NET environment | [ Development, Production ] | Development |
| HIREME_WEBAPI_DB_HOST     | database host       | string                      | localhost   |
| HIREME_WEBAPI_DB_NAME     | database name       | string                      | hireme      |
| HIREME_WEBAPI_DB_USERNAME | database username   | string                      | hireme      |
| HIREME_WEBAPI_DB_PASSWORD | database password   | string                      |             |

## Getting started on your machine

### Prerequisites

Local PostgreSQL instance

- accessible at `HIREME_WEBAPI_DB_HOST`
- with installed `psql` command-line tools
- requires an login with username `HIREME_WEBAPI_DB_USERNAME` and password `HIREME_WEBAPI_DB_PASSWORD` with appropriate permissions

### Step by step

1. Install the [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download)

2. Restore dotnet tools

   `dotnet tool restore`

3. Set appropriate values for the [environment variables](#environment-variables)

4. Launch

   In Visual Studio Code, press <kbd>F5</kbd>

5. Access with your favorite browser: [http://localhost:8080/](http://localhost:8080/)
