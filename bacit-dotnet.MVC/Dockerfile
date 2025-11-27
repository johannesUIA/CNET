#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debug.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["bacit-dotnet.MVC.csproj", "."]
COPY ["nuget.config", "."]
RUN dotnet restore
COPY . .
RUN dotnet build -c Release --no-restore

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bacit-dotnet.MVC.dll", "--environment=Development"]
