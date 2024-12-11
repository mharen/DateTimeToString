FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
RUN dotnet workload install wasm-tools
RUN apt-get update && apt-get install -y python3

WORKDIR /App
COPY Web.sln .
COPY Web Web
COPY Web.Client Web.Client

WORKDIR /App/Web
RUN dotnet publish -c Release -o /out


FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV DOTNET_URLS=http://*:80
WORKDIR /var/www/web
COPY --from=build-env /out .
ENTRYPOINT [ "dotnet", "Web.dll" ]
EXPOSE 80