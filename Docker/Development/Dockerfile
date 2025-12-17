FROM mcr.microsoft.com/dotnet/aspnet:8.0 
WORKDIR /app

COPY ./publish/ /app
ENV ASPNETCORE_URLS=http://+:8084
ENV ASPNETCORE_ENVIRONMENT Development
EXPOSE 8084
ENTRYPOINT ["dotnet", "/app/Api.Bienalive.dll"]