FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App
COPY Web/ .
RUN dotnet publish -c Release -o out

FROM nginx:1.27.3-alpine
WORKDIR /var/www/web
COPY ./nginx.conf /etc/nginx/nginx.conf
COPY --from=build-env /App/out/wwwroot .
EXPOSE 80