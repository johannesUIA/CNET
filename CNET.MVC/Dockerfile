#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CNET.MVC", "CNET.MVC/"]
RUN ls /src
WORKDIR "/src/CNET.MVC/"
RUN ls "/src/CNET.MVC/"
RUN dotnet restore
RUN dotnet build -c Release  --no-restore

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish  --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CNET.MVC.dll", "--environment=Development"]
