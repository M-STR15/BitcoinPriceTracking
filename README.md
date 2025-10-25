# BitcoinPriceTracking (ve vývoji)

💡 *Demonstrační aplikace pro sledování vývoje ceny Bitcoinu pomocí ASP.NET Core Web API, Blazoru a Entity Framework Core. Projekt slouží jako ukázka architektury, práce s daty z API, logování a nasazení webové aplikace s databází.*

## Popis projektu

Aplikace pravidelně načítá a ukládá data z veřejných API:

- **Coindesk API:**[https://data-api.coindesk.com//cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.xml]
 
 → Data se aktualizují v bufferu **jednou za minutu**.
  
- **ČNB API:** [https://www.cnb.cz//cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.xml]
  
    - tyto data se v BUFFEru aktualizují jednou za den
 
Načtená data lze následně zobrazit, filtrovat, třídit a ukládat do databáze.  
Součástí je i možnost přidávat poznámky k jednotlivým záznamům.

---

## Použité technologie

### Backend
- **ASP.NET Core Web API**
- **Entity Framework Core** (Code First, migrační balíčky)
- **Serilog** – logování událostí
- **Swagger** – automaticky generovaná dokumentace API

### Frontend
- **Blazor** – responzivní webové rozhraní
- **Bootstrap** – volitelný pro vzhled komponent

### Databáze
- **Microsoft SQL Server**  
  - Databáze je vytvářena automaticky při prvním spuštění (EF Core migrations).  
  - Připojovací řetězec (`ConnectionStringsMSSQL`) je uložen v `appsettings.json`.

---
## Architektura

Aplikace využívá vícevrstvou architekturu podle principů **MVC** a **SOLID**.  
Projekt je rozdělen na samostatné části pro lepší přehlednost a údržbu:

# Solution

- **BE (backendová část)**
  - **BusinessLogic** – controllery, služby, business logika
  - **DB** – entity, kontext databáze
  - **Shared** – DTO a sdílené objekty

- **FE (frontendová část)**
  - **Components** – Blazor komponenty

---

## Nasazení

Aplikaci lze spustit přímo z **Visual Studio 2022**:
- Vyžaduje pouze dostupnou instanci **Microsoft SQL Serveru**.
- Databáze i tabulky se vytvoří automaticky při prvním spuštění.
- Spuštění: `F5` nebo `Ctrl+F5`.

Volitelně lze aplikaci publikovat jako webový balíček a nasadit na **IIS server**.

---    
## Poznámky

- Migrace databáze se provádějí přes `MsSqlDbContextFactory`.  
  Při vytváření nového migračního balíčku je nutné upravit připojovací řetězec.
- `appsettings.json` obsahuje výchozí `ServerName=.` pro lokální instanci SQL Serveru.
- Swagger dokumentace je dostupná po spuštění aplikace na adrese:  
  **`/swagger/index.html`**

---

## Časová náročnost vývoje

| Fáze práce             | Čas |
|------------------------|------:|
| Přípravná práce        | 2 h |
| Vývoj (BE + FE)        | 13 h |
| Dokumentace            | 1 h |
| Testování              | 0 h |
| **Celkem:**            | **16 h** |

---


## Changes (verzování)

Legend: 

Hlavní kategorie 

- 🚀 - Nová funkce
- 🐞 - Oprava chyby
- 📝 - Dokumentace
- 🛠 - Úprava kódu
- 🚨 - Bezpečnostní aktualizace
- ❌ - Odstranění funkce
- 🛢 - Databázové úpravy

Dodatečné info:
- 🔒 - Nezveřejňovat informaci zákazníkovi
- 🔥 – Kritická
- ⚠ – Důležitá -> ovlivňující mnoho uživatelů
- 🛑 – Zásadní
- 🚨 – Bezpečnostní

***
### 0.4.1   (2025-10-25)
- 🐞 oprava validace formuláře při ukládání poznámek k záznamu
***
### 0.4.0   (2025-10-22)
- 🚀 přidání validování formuláře 
- 🚀 přidání validování REST API
***
### 0.3.0   (2025-10-21)
- 🚀 přidaná možnost editování poznámek k záznamu přímo v tabulce
***
### 0.2.0   (2025-10-20)
- 🚀 přidání nové zobracování loaderu při načítání dat
- 🚀 přidáno zobrazení toast notifikací při úspěšném či neúspěšném uložení dat
***
### 0.1.0   (2025-10-19)
- 🚀 přidání sortování a filtrování v tabulkách
- 🚀 zobrazování verzovacího čísta aplikace
- ❌ odstraněno API pro úpravu [PUT] CryptoDat, je to z důvodu, že data by se neměla měnit po uložení
- 🚀 nové API pro uložení poznámek k záznamu [PUT] CryptoDatNote
***
### 0.0.1   (2025-10-19)
- 🚀 vytvořené základní funkcionality aplikace dle požadavku projektu
    - jenom je potřeba dodělat změnu poznámek k zánamu ([#15-Uložit změny poznámek k záznamu
](https://github.com/M-STR15/BitcoinPriceTracking/issues/15))

---

## Authors

[@M-STR](https://github.com/M-STR15)

## License

[MIT](https://choosealicense.com/licenses/mit/)