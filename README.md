# ProjectHB ReadMe

Denna ReadMe-fil beskriver steg-för-steg hur du bygger och startar ProjektHB på en annan dator. Här beskrivs också vilken utvecklingsmiljö som krävs för att genomföra dessa steg.
## Utvecklingsmiljö
För att kunna bygga och köra projektet behöver du använda en utvecklingsmiljö som stödjer .NET Core. Du ska använda dig utav Visual Studio (Windows, Mac).
## Förutsättningar

För att kunna bygga och köra projektet behöver du följande:

- [.NET Core SDK](https://dotnet.microsoft.com/download) installerat på din dator. Se till att ha minst version 3.1 eller senare installerad.
- En SQL Server-databas som är tillgänglig för att skapa och ansluta till.

## Steg 1: Klona projektet

1. Öppna en terminal eller kommandotolk på din dator.
2. Navigera till den mapp där du vill placera projektet.
3. Kör följande kommando för att klona projektet från GitHub:
git clone <https://github.com/FTrajanovski/CalorieApp.git>

## Steg 2: Konfigurera databasanslutning

1. Öppna projektet i din föredragna utvecklingsmiljö (t.ex. Visual Studio, Visual Studio Code, eller liknande).
2. Navigera till filen `BurgerModel.cs` i mappen `ProjektHB\Models`.
3. I `OnConfiguring`-metoden ändrar du anslutningssträngen `optionsBuilder.UseSqlServer` enligt dina SQL Server-anslutningsuppgifter.
optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CalorieAppDb;Trusted_Connection=True;MultipleActiveResultSets=true");

## Steg 3: Bygg och kör projektet
1. Öppna en terminal eller kommandotolk i projektets rotmapp.
2. Kör följande kommando för att bygga projektet:
dotnet build
3. Kör följande kommando för att starta projektet
dotnet run
4. U


