![Nøsted logo](https://raw.githubusercontent.com/Prosjekt2023/Reficio/main/bacit-dotnet.MVC/wwwroot/nlogo.png)

# Nøsted – Vedlikeholdssystem (CNET)

Dette er en ASP.NET Core MVC-applikasjon for sjekklister og vedlikehold hos Nøsted & AS.  
Prosjektet kjøres nå **fullt ut i Docker**: både web-applikasjon og MariaDB-database startes med én kommando.

---

## Forutsetninger

Før du starter trenger du:

1. **Docker Desktop**
  - Last ned fra den offisielle siden: <https://www.docker.com/products/docker-desktop/>
  - Installer og start Docker Desktop.

2. ### Kjøringsmiljø

  - Denne løsningen er designet for å kjøres i containere.  
  - All funksjonalitet (web-applikasjon + database) forutsetter Docker og Docker Compose.  
  - Kjøring uten Docker (`dotnet run` direkte på host) er ikke en del av den støttede konfigurasjonen.


## Kjøre prosjektet med Docker (anbefalt)

Dette er den enkleste og mest komplette måten å kjøre løsningen på.

1. **Klone repoet** (eller last det ned som ZIP og pakk ut)

2. **Åpne en terminal i rotmappen til prosjektet**

   Rotmappen inneholder blant annet:
  - `docker-compose.yml`
  - `Dockerfile`
  - `CreateDb.sql`
  - mappen `bacit-dotnet.MVC/`

3. **Start hele løsningen**

   ```bash
   docker compose up --build
