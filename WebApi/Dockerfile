FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
WORKDIR /app
COPY ./ ./
RUN dotnet publish WebApi/WebApi.csproj --configuration Release --output ./publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine
EXPOSE 443
WORKDIR /publish
COPY --from=build /app/publish /app
ENTRYPOINT ["dotnet", "app/WebApi.dll"]
