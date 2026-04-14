FROM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS build-env

RUN apk add --no-cache python3 && dotnet workload install wasm-tools

WORKDIR /App

# Copy project files and restore as a separate layer for caching
COPY Web.sln .
COPY Web/Web.csproj Web/
COPY Web.Client/Web.Client.csproj Web.Client/
RUN dotnet restore Web/Web.csproj

COPY Web/ Web/
COPY Web.Client/ Web.Client/
RUN dotnet publish Web/Web.csproj -c Release -o /out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0-noble-chiseled-extra
ENV DOTNET_URLS=http://*:80
WORKDIR /var/www/web
COPY --from=build-env /out .
ENTRYPOINT ["dotnet", "Web.dll"]
EXPOSE 80
