FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
WORKDIR /app
COPY ./ ./
RUN dotnet publish WebApi/WebApi.csproj --output ./publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine
EXPOSE 8080
COPY --from=build /app/publish /app
ENTRYPOINT ["dotnet", "app/WebApi.dll"]
