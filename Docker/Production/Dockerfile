FROM mcr.microsoft.com/dotnet/aspnet:8.0 
WORKDIR /app

COPY ./publish/ /app
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT Production
EXPOSE 80
ENTRYPOINT ["dotnet", "/app/Api.Bienalive.dll"]