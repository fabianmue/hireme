# HireMe

This is a monorepo containing source code for a sample web application. Its purposes include demonstrating implementation concepts and serving as a reference.

## Technologies

### Web API

Built with [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core) 8, uses [Kestrel](https://learn.microsoft.com/de-de/aspnet/core/fundamentals/servers/kestrel) web server.

Notable (NuGet) packages

- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) with [Npgsql Provider](https://www.npgsql.org/efcore/)

### Web client

Built with [Angular](https://angular.io/docs) 16, uses [Nginx](https://nginx.org/en/docs/) web server.

Notable (npm) packages

- [Angular Material](https://material.angular.io/)

### Container

Building with [Docker Build](https://docs.docker.com/build/), orchestration with [Docker Compose](https://docs.docker.com/compose/)

## Getting started

### Web API

**Build the container**

> `cd WebApi`

> `docker build --tag hireme-webapi .`

## Features

### Web API

**CRUD endpoints**

Create, read, update and delete endpoints for various entities.

**OpenAPI compatible documentation**

API documentation is available as an OpenAPI v3.1 compatible JSON file. The exposed Swagger UI provides a graphical user interface to interact with endpoints.

### Web client

### Other

**Containerization**

Build a Docker container for the WebApi. Run the container together with a Postgres based database container using Docker Compose.

## Feature ideas

**.NET integration tests**

**CI / CD pipeline with GitHub actions**
