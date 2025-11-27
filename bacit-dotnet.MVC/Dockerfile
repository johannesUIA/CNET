#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debug.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only the project and NuGet configuration to leverage Docker layer caching
COPY ["bacit-dotnet.MVC.csproj", "."]
COPY ["nuget.config", "."]
RUN dotnet restore --configfile nuget.config "bacit-dotnet.MVC.csproj"

# Bring in the full source after the initial restore
COPY . .

# Force a full restore inside the container so package resolution (including analyzers)
# does not depend on the developer machine's CLI setup.
RUN dotnet restore --configfile nuget.config --force "bacit-dotnet.MVC.csproj"
RUN dotnet build -c Release --no-restore

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bacit-dotnet.MVC.dll", "--environment=Development"]
