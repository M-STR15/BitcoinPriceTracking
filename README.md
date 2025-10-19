# BitcoinPriceTracking (ve vývoji)

Aplikace slouží k načítání dat z API:
- https://data-api.coindesk.com//cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.xml
    
    - tyto data se v BUFFEru aktualizují jednou za minutu
  
- https://www.cnb.cz//cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.xml
  
    - tyto data se v BUFFEru aktualizují jednou za den
 
Tyto data je poté možné uložit či zobrazit. 


## Authors

- [@M-STR](https://github.com/M-STR15)


## License

[MIT](https://choosealicense.com/licenses/mit/)

## Technické požadavky

- Backend:

   - ASP.NET Core Web API
   - Entity Framework nebo EF Core
   - Logování (např. Serilog, NLog)

- Frontend:

   - ASP.NET WebForms / MVC / Blazor / Razor
   - Bootstrap pro responzivní vzhled (volitelné)

- Databáze:

   - Microsoft SQL Server
   = Součástí řešení bude T-SQL skript pro vytvoření tabulek a případných procedur

- Architektura:

   - Dodržujte principy SOLID
   - Pište čitelný, srozumitelný a udržitelný kód
   - Dbejte na oddělení business logiky od prezentační vrstvy

## Použita technologie

- Backend:
    - ASP.NET Core Web API
    - EF Core
    - Logování-serilog
    
- Frontend:
    - Blazor

- Databáze:
    - Microsoft SQL Server

- Architektura:
    - Aplikace je psaná architekturou MVC
    - Projekt je rozdělený na několik menších projektů pro lepší přehlednost a údržbu kódu.
        - BE (backendová část)
            - BusinessLogic
                - zde se nachází kontrolery , služby a další logika aplikace
                - controllery mají vytvořenou dokumentaci za pomocí SWAGGERu, který je dostupný po spuštění aplikace na /swagger/index.html
                
            - DB (databázová část))
                - zde se nachází entity a kontext databáze
            - Shared
                - zde se nachází DTO a další sdílené objekty
        - FE (frontendová část)
            - Components
                - zde se nachází komponenty aplikace

## Nasazení

-Spuštění přes vývojové prostředí VS2022
    - aplikace vznikla za pomocí ORM pomocí EF, kde jsou vytvořený migrační balíčky pro vytvoření databáze a tabulek
        - ConnectString pro vytváření migračních balíčků je nastavený MsSqlDbContextFactory, pokud bybylo potřeba vytvořit jiný migrační balíček, tak bude potřerba upravit connectstring
    - v appsettings.json-> ConnectionStringsMSSQL je nastavený připojovací řetězec k databázi, aktuálně je nastavený na ServerName=., tím by měl být připojený na lokální instanci SQL serveru
        - Pokud by bylo potřeba připojit na jinou instanci, tak je potřeba upravit tento řetězec
    - aplikaci stačí sputit buď přes F5 nebo Ctrl+F5, nebo pak lze vytvořit public balíček a nasadit ho na IIS server, kde bude i DB

## Popis časové náročnosti
- Celkový čas na vytvoření aplikace byl přibližně 16 hodin
    - Přípravná práce: 2 hodina
    - Vývoj (BE+ FE): 13 hodin
    - Dokumentace: 1 hodin
    - Vývoj testování: 0 hodiny

## Changes

Legend: 

Hlavní kategorie 

- 🚀 - Nová funkce
- 🐞 - Oprava chyby
- 📝 - Dokumentace
- 🛠 - Úprava kódu
- 🚨 - Bezpečnostní aktualizace
- ❌ - Odstranění funkce
- 🛢 - Databázové úpravy

Dodatečné info
- 🔒 - Nezveřejňovat informaci zákazníkovi
- 🔥 – Kritická
- ⚠ – Důležitá -> ovlivňující mnoho uživatelů
- 🛑 – Zásadní
- 🚨 – Bezpečnostní
- ***

***

### 0.0.1   (2025-10-19)
- 🚀 vytvořené základní funkcionality aplikace dle požadavku projektu
    - jenom je potřeba dodělat změnu poznámek k zánamu 