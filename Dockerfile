# Build y publicación en .NET 10
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY CineCatalog.API/CineCatalog.API.csproj CineCatalog.API/
RUN dotnet restore CineCatalog.API/CineCatalog.API.csproj

COPY . .
RUN dotnet publish CineCatalog.API/CineCatalog.API.csproj -c Release -o /app/publish --no-restore /p:UseAppHost=false

# Contenedor de ejecución más liviano
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080
COPY --from=build /app/publish .
USER $APP_UID
ENTRYPOINT ["dotnet", "CineCatalog.API.dll"]
