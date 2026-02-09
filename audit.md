# AUDIT: HoaP -- Hotelový SaaS Systém

**Kompletní strategický a technický audit projektu**
**Datum:** 2026-02-08

---

## Obsah

1. [Fáze 1: Product-Market Fit & Konkurence](#fáze-1-product-market-fit--konkurence)
2. [Fáze 2: Interní Dashboard -- Hloubková Analýza](#fáze-2-interní-dashboard----hloubková-analýza)
3. [Fáze 3: Zákaznický Portál -- Návrh](#fáze-3-zákaznický-portál----návrh)
4. [Fáze 4: Technická & Architektonická Review](#fáze-4-technická--architektonická-review)
5. [Fáze 5: Brutálně Upřímné Závěry](#fáze-5-brutálně-upřímné-závěry)
6. [TOP 5 Akcí](#top-5-akcí----co-udělat-první)
7. [MVP Scope](#mvp-scope----minimum-pro-prvního-platícího-zákazníka)
8. [Verdikt](#verdikt)

---

## Souhrn projektu

| Parametr | Hodnota |
|----------|---------|
| **Tech stack** | Blazor Server, .NET 9, PostgreSQL (Neon), EF Core |
| **Architektura** | Clean Architecture (Domain → Application → Infrastructure → Web) |
| **Entity** | 24 doménových entit |
| **Repositories/Services** | 20+ repozitářů, 20+ služeb |
| **UI** | 50+ Razor komponentů, Bootstrap 5 |
| **Auth** | ASP.NET Identity, 3 role (Admin, Manager, Receptionist) |
| **Multi-tenancy** | NE -- single hotel per deployment |
| **Guest portal** | NE -- žádná guest-facing část |
| **REST API** | NE -- čistý Blazor Server |
| **Integrace** | NE -- žádná platební brána, channel manager, email/SMS |
| **Deployment** | Docker Compose (PostgreSQL + Web), Neon (cloud) |
| **Testy** | 0 unit testů, 0 integračních testů |
| **Stav** | Funkční MVP interního dashboardu, žádní reální zákazníci |
| **Tým** | Solo / malý tým (1-3 lidi) |

---

## FÁZE 1: Product-Market Fit & Konkurence

### Kdo je reálný kupující?

Teď upřímně: **nikdo**. V současném stavu systém nemá žádnou funkci, kvůli které by hotel přešel z čehokoliv -- ani z Excelu. Proč?

- **Žádný channel manager** -- hotel nemůže synchronizovat s Booking.com/Expedia. To je dnes absolutní základ. Hotel bez napojení na OTA neexistuje.
- **Žádný booking engine** -- hotel nemůže přijímat přímé rezervace z webu.
- **Žádné online platby** -- host nemůže zaplatit kartou.
- **Žádné emailové potvrzení** -- po vytvoření rezervace se nic nestane.

Reálný kupující by mohl být **majitel malého penzionu/apartmánu (5-20 pokojů)** v ČR, který aktuálně používá Excel nebo papír a hledá jednoduché, levné řešení. Ale i ten potřebuje minimálně napojení na Booking.com.

### Konkurenční landscape

| Funkce | **Previo** | **Mews** | **Better Hotel** | **HoaP** |
|--------|-----------|----------|-----------------|---------|
| Multi-tenant SaaS | Ano | Ano | Ano | **NE** |
| Channel Manager (Booking, Expedia) | Ano (15+ OTA) | Ano (1000+ integr.) | Ano | **NE** |
| Booking Engine | Ano (4% z rez.) | Ano (v ceně) | Ano | **NE** |
| Online platby | Ano (ČSOB 0.9%) | Ano (vestavěné) | Ano | **NE** |
| Guest portal/app | Ano (Alfred) | Ano (portal + klíč) | Ano | **NE** |
| REST API | Ano | Ano (Open API) | Ano | **NE** |
| Dynamic pricing | Ano | Ano (Atomize AI) | Ano | **NE** |
| Housekeeping app | Ano (mobilní) | Ano | Ano | Základní statusy |
| Emailové šablony | Ano (automatizace) | Ano (branded) | Ano | **NE** |
| Night audit | Ano | Ano | Ano | **NE** |
| Reporting (RevPAR, ADR) | Ano (pokročilé) | Ano (Analytics) | Ano | 4 základní KPIs |
| Český trh/lokalizace | Nativně CZ | CZ podpora | Nativně CZ | CZ |
| Zákazníci | 5000+ | Tisíce (Best Western) | 350+ CZ | **0** |

### Cenové srovnání

- **Previo:** Setup 9 490 Kč + 300 Kč/pokoj/měsíc (PMS) + channel manager 250 Kč/měs + moduly
- **Mews:** Od cca 300 EUR/měsíc (~7 500 Kč), enterprise segment
- **Better Hotel:** Ceny na vyžádání, cca 350+ CZ hotelů
- **HoaP:** Žádný pricing model, žádná platební infrastruktura v kódu

### Pozice na českém trhu

Český trh je **relativně konsolidovaný**: Previo dominuje s 5000+ klienty, Better Hotel má 350+, Protel funguje ve středním/velkém segmentu. Mezeru vidím pouze v:

1. **Ultra-levný segment** -- penziony s 5-15 pokoji, pro které je i Previo drahé (setup 9 490 Kč + 300 Kč/pokoj = min. 1 500 Kč/měs pro 5 pokojů)
2. **Self-hosted / open-source** -- hotely, které nechtějí vendor lock-in

### Cílení na "všechny segmenty" -- verdikt

**Tohle je nereálné.** S 1-3 lidmi v týmu nemůžete konkurovat Mews (valuace $2.5B, stovky zaměstnanců) ve velkém segmentu. Ani Previu (20+ let vývoje, 5000+ zákazníků) ve středním. Jediná šance je **laser focus na mikro-segment**: malé české penziony, apartmány, rodinné hotely do 20 pokojů.

---

## FÁZE 2: Interní Dashboard -- Hloubková Analýza

### Co funguje dobře

**Rezervační systém** má solidní základ:
- Dva režimy vytváření (podle data / podle pokoje) -- to je uživatelsky přívětivé
- Multi-guest podpora (hlavní host + další hosté přes `ReservationCustomer` join tabulku)
- Doplňkové služby s přepočtem měn (wellness, parkování, mazlíček)
- Kalendářový přehled na dashboardu s vizualizací obsazenosti

**Správa pokojů** pokrývá základy:
- Typy pokojů, kapacita (dospělí/děti), amenity, cena v různých měnách
- Statusy (Volný, Obsazený, Mimo provoz, Čeká na úklid)

**Admin nastavení** je flexibilní:
- 10 konfigurovatelných oblastí (typy pokojů, statusy, měny, stravování, služby...)
- Seed data v češtině -- připraveno pro český trh

**Fakturace** má základ:
- QuestPDF generátor, položky faktury, slevy, zálohy
- Multi-měnová podpora

### Co je špatně -- konkrétní kódové nálezy

#### 1. Revenue výpočet je chybný

**Soubor:** `HoaP.Infrastructure/Repositories/DashBoardRepository.cs` řádky 25-27

```csharp
var revenue = await _context.Reservations
    .Where(r => r.CheckIn >= firstDayOfLastMonth && r.CheckIn <= lastDayOfLastMonth)
    .SumAsync(r => r.TotalPrice);
```

Problémy:
- **Sčítá různé měny dohromady** -- 2200 CZK + 100 EUR + 50 USD = 2350 "Kč"? Nesmysl.
- **Počítá zrušené rezervace** -- žádný filtr na `IsCanceled` nebo `ReservationStatusId`
- **Počítá nezaplacené** -- revenue by měl reflektovat skutečné příjmy
- Zobrazuje se natvrdo s "Kč" na dashboardu (`HoaP.Web/Components/Pages/Home.razor` řádek 41)

#### 2. Všechny rezervace se načítají do paměti

**Soubor:** `HoaP.Web/Components/Pages/Home.razor` řádek 149

```csharp
bookings = await ReservationService.GetReservationsAsync();
```

Toto načte VŠECHNY rezervace ze VŠECH dob s Include na zákazníky, pokoje, statusy. Při 1000 rezervacích to znamená tisíce řádků v paměti serveru -- pro KAŽDÉHO přihlášeného uživatele (Blazor Server drží stav v paměti).

#### 3. Žádná validace dostupnosti při vytváření rezervace

**Soubor:** `HoaP.Infrastructure/Repositories/ReservationRepository.cs` řádky 26-80

Metoda `CreateReservationAsync` přijme formulář a uloží ho do DB bez jakékoliv kontroly, zda pokoj není v daném termínu už obsazený. **Overbooking je zaručený.**

Metoda `GetAvailableRoomsAsync` existuje v `RoomRepository`, ale v rezervačním workflow se nevolá při uložení -- pouze při výběru pokoje.

#### 4. Jen 2 stavy rezervace

**Soubor:** `HoaP.Infrastructure/Data/ApplicationDbContext.cs` řádky 215-218

```csharp
new ReservationStatus { Id = 1, Name = "Potvrzená" },
new ReservationStatus { Id = 2, Name = "Zrušená" }
```

Pro reálný hotelový provoz chybí: **Pending, CheckedIn, CheckedOut, NoShow**. Bez check-in/check-out workflow systém neví, kdo je aktuálně v hotelu.

#### 5. ReservationManagePage.razor má 1265 řádků

Jeden obrovský Blazor komponent -- obsahuje kalendář, výběr pokoje, správu hostů, služby, fakturaci. To je neudržitelné. Každá změna v jakékoliv části riskuje rozbití celého formuláře.

#### 6. Duplicitní konfigurace v DbContext

**Soubor:** `HoaP.Infrastructure/Data/ApplicationDbContext.cs` řádky 47-51 a 60-64

Identická konfigurace vztahu Reservation→Invoice je definována dvakrát. Nezpůsobí chybu, ale signalizuje nepozornost.

#### 7. Obrázky pokojů uložené jako byte[] v DB

Entita `Room` má `Image` jako `byte[]`. Při načítání seznamu pokojů se binární data tahají z DB do paměti. Tohle drasticky zpomalí dotazy a nafukuje DB.

### Co zásadně chybí pro hotelový provoz

| Chybějící funkce | Důležitost | Proč |
|-------------------|-----------|------|
| Check-in / Check-out workflow | Kritická | Hotel neví, kdo je na pokoji |
| Night audit / uzávěrka dne | Kritická | Standard v každém PMS |
| Hotel profil (název, adresa, IČO, DIČ, logo) | Kritická | Faktury jsou neplatné bez těchto údajů |
| Emailové potvrzení rezervace | Kritická | Host nedostane žádnou zprávu |
| Rate plans (sezónní ceny, víkend/všední den) | Vysoká | Cena je per-pokoj, ne per-typ/období |
| Reporting (RevPAR, ADR, obsazenost %) | Vysoká | Management bez dat nemůže řídit |
| Audit log (kdo co změnil) | Vysoká | Billing disputes, compliance |
| Skupinové rezervace | Střední | Konference, skupiny, allotmenty |
| Zdroj rezervace (walk-in, telefon, web, OTA) | Střední | Analýza odkud přicházejí hosté |

---

## FÁZE 3: Zákaznický Portál -- Návrh

### Aktuální stav: nula

Všechny stránky jsou za `[Authorize]` atributem. Není jediná veřejná stránka. Login page dokonce **zobrazuje testovací credentials** (`HoaP.Web/Components/Pages/Account/LoginPage.razor` řádky 12-16):

```html
<strong>Testovací účet</strong><br />
<i>Email:</i> admin@admin.com<br />
<i>Heslo:</i> Admin123456789!
```

### Blazor Server = SEO problém

`HoaP.Web/Program.cs` řádky 165-166 používá `AddInteractiveServerRenderMode()`. To znamená, že veškerý obsah se renderuje přes SignalR WebSocket. **Google nemůže indexovat dynamický obsah renderovaný přes WebSocket.** Pro booking engine, kde chcete, aby hosté našli hotel přes Google, je to deal-breaker.

### Doporučená architektura pro guest portal

**Varianta A (doporučená): Blazor SSR + Minimal API**

.NET 8 Blazor podporuje různé render modes per-stránka:
- **Veřejné stránky** (pokoje, dostupnost, booking form): `@rendermode` static SSR -- SEO-friendly, žádný SignalR
- **Interní dashboard**: `@rendermode InteractiveServer` -- stávající chování
- **API vrstva**: Minimal API endpointy pro booking engine, platby, webhooky

Tohle je nejmenší zásah do stávající architektury.

### Must-have funkce guest portálu (MVP)

**Booking flow (max 4 kroky):**

1. **Hledání** -- datum příjezdu/odjezdu, počet hostů → zobrazení dostupných pokojů
2. **Výběr pokoje** -- fotky, popis, cena, amenity → výběr do košíku
3. **Údaje hosta** -- jméno, email, telefon, speciální požadavky
4. **Potvrzení** -- shrnutí + platba (nebo potvrzení bez platby pro MVP)

**Po rezervaci:**
- Emailové potvrzení s referenčním číslem
- Stránka pro správu rezervace (zobrazení/storno přes referenční kód)

### Nice-to-have (fáze 2+)

- Online check-in (formulář s osobními údaji před příjezdem)
- Upselling (upgrade pokoje, snídaně, parkování)
- Multi-jazyk (CZ, EN, DE -- minimum pro český trh)
- Hodnocení po pobytu
- Platební brána (GoPay pro CZ trh, Stripe pro mezinárodní)

### UX požadavky

- **Mobile-first** -- 60%+ rezervací je z mobilu
- **Rychlost** -- booking form musí být pod 3 sekundy load time
- **Důvěryhodnost** -- profesionální design, HTTPS, zobrazení recenzí
- **Obrázky** -- přesunout z DB `byte[]` na CDN/blob storage

---

## FÁZE 4: Technická & Architektonická Review

### 4.1 Architektura -- dobrý záměr, špatné provedení

Projekt správně používá **Clean Architecture** se 4 vrstvami:

```
HoaP.Domain → HoaP.Application → HoaP.Infrastructure → HoaP.Web
```

**Ale hranice jsou porušené:**

- **Application vrstva závisí na ASP.NET** -- `HoaP.Application.csproj` referencuje `Microsoft.AspNetCore.Components.Web`. Application layer by měla být čistě doménová, nezávislá na frameworku.
- **Repository interfaces vrací ViewModels** -- `IReservationRepository.GetReservationsAsync()` vrací `List<ReservationViewModel>`, ne `List<Reservation>`. Repository by měl vracet doménové entity; mapování na ViewModely patří do servisní vrstvy.
- **Business logika žije v repositories** -- celá logika vytváření rezervace (přidání hostů, služeb, validace) je v `ReservationRepository`, ne v `ReservationService`.

### 4.2 Service Layer Anti-Pattern

Každý service je **prázdný passthrough**. Příklad -- `HoaP.Application/Services/ReservationService.cs` -- všech 8 metod:

```csharp
public async Task<List<ReservationViewModel>> GetReservationsAsync()
{
    return await _reservationRepository.GetReservationsAsync();
}
```

Žádná validace, žádná business logika, žádná orchestrace. Service vrstva je 100% redundantní. Tohle znamená:
- **Nelze unit testovat business logiku** izolovaně od databáze
- **Business pravidla jsou svázaná s EF Core** -- přesun na jinou DB = přepsání veškeré logiky
- **Žádná ochrana** -- cokoliv přijde z UI, jde rovnou do DB

### 4.3 Entity Framework problémy

**Načítání všech dat bez paginace:**

`HoaP.Infrastructure/Repositories/ReservationRepository.cs` řádky 124-133:

```csharp
var reservations = await _context.Reservations
    .Include(r => r.ReservationCustomers)
        .ThenInclude(rc => rc.Customer)
    .Include(r => r.Room)
    .Include(r => r.ReservationStatus)
    .Include(r => r.Currency)
    .ToListAsync();
```

Žádná paginace na DB úrovni. Žádné `Where`. Žádné `AsNoTracking()`. Při 5000 rezervacích tohle bude trvat sekundy a zabere desítky MB RAM.

**`DateTime.Now` v seed datech:**

`HoaP.Infrastructure/Data/ApplicationDbContext.cs` řádek 175: `StartDate = DateTime.Now` v admin seed. Tohle se vyhodnocuje při KAŽDÉ migraci, takže seed data se mění → migrace nejsou deterministické → duplicitní záznamy při re-seed.

**Chybějící indexy:**

Žádné explicitní indexy kromě PK. Pro hotelový systém jsou kritické:
- `Reservation (RoomId, CheckIn, CheckOut)` -- dotazy na dostupnost
- `Reservation (CustomerId)` -- historie hosta
- `Room (RoomStatusId)` -- filtrování dostupných pokojů
- `Invoice (IsPaid, DueDate)` -- přehled nezaplacených

**Database provider:** Projekt nyní používá PostgreSQL (Neon) přes `Npgsql.EntityFrameworkCore.PostgreSQL`.

### 4.4 Bezpečnostní problémy

| Problém | Soubor | Závažnost |
|---------|--------|-----------|
| Root DB heslo v source control | `HoaP.Web/appsettings.json`: `user=root;password=root` | Kritická |
| Admin heslo hardcoded | `ApplicationDbContext.cs` řádek 182: `Admin123456789!` | Kritická |
| Test credentials v UI | `LoginPage.razor` řádky 12-16 | Kritická (pokud deployed) |
| Rodná čísla plaintext | `Customer.PersonalIdentificationNumber` bez šifrování | Vysoká (GDPR) |
| Žádný rate limiting na login | `LoginPage.razor` -- brute-force možný | Vysoká |
| Žádný audit log | Nikde v kódu | Střední |
| Generic exception leaking | `ReservationRepository.cs` řádek 192: `throw new Exception(...)` | Nízká |

### 4.5 Multi-tenancy -- největší technický bloker

**Stav: kompletně single-tenant.** Žádný `TenantId` na žádné z 24 entit. Žádný query filter. Žádná tenant izolace.

Pro SaaS produkt to znamená: **každý hotel = vlastní deployment + vlastní databáze + vlastní údržba**. Při 50 hotelech to je 50 Docker kontejnerů, 50 databází, 50 migrací. Neudržitelné.

**Doporučení pro malý tým:**
- **Fáze 1 (0-10 zákazníků):** Database-per-tenant s automatizovaným deployment scriptem. Nejjednodušší na retrofit, izolace dat zdarma.
- **Fáze 2 (10+ zákazníků):** Přechod na shared DB s `TenantId` + EF Core global query filters. Velký refaktor, ale škálovatelný.

### 4.6 Blazor Server škálovatelnost

Každý uživatel = persistent SignalR connection + server-side state. Pro interní dashboard (5-10 concurrent users) to je OK. Pro guest-facing booking engine s desítkami concurrent visitors je to problém:

- Žádný caching (`IMemoryCache`, `IDistributedCache` -- nic)
- Dashboard načítá všechny rezervace per-user do paměti
- Žádné graceful handling při disconnectu

### 4.7 Chybějící infrastruktura

- **0 testů** -- žádné unit testy, žádné integrační testy
- **Žádné structured logging** -- chybí Serilog nebo podobný
- **Žádné health checks** -- `app.MapHealthChecks()` chybí
- **CI/CD pipeline smazaný** -- `.github/workflows` odstraněn (git history: `b5d85d3`)
- **Žádný global exception handler** -- jen try-catch v jednotlivých komponentech
- Typo v interface: `Program.cs` řádek 118 -- `IDashBoardRepsoitory` (chybí `i` v Repository)
- Matoucí naming: `ServiceService` (služba pro služby)

---

## FÁZE 5: Brutálně Upřímné Závěry

### STOP -- Tohle je problém (musí se vyřešit)

1. **Žádný channel manager / OTA integrace** -- Hotel bez napojení na Booking.com v roce 2026 nikdo nekoupí. Ani malý penzion. OTA přinášejí 40-70% rezervací. Bez API to nejde implementovat.

2. **Žádný REST API** -- Celý systém je monolitický Blazor Server. Nemůžete napojit platební bránu, channel manager, mobilní app, webhook, nic. API je prerekvizita pro VŠECHNO ostatní.

3. **Bezpečnostní díry** -- Root hesla v source control, test credentials v UI, rodná čísla plaintext. Pokud tohle nasadíte s reálnými daty, riskujete GDPR pokutu a únik dat.

4. **Žádná validace dostupnosti** -- Systém dovolí vytvořit dvě rezervace na stejný pokoj ve stejný termín. Pro hotel je overbooking katastrofa.

5. **Žádný guest-facing portál** -- Hotel nemůže přijímat online rezervace. V roce 2026 je web bez online bookingu mrtvý web.

### POZOR -- Rizika a slabiny

1. **Service layer je prázdná obálka** -- Business logika v repositories znemožňuje testování a porušuje Clean Architecture.
2. **Revenue výpočet je chybný** -- Míchá měny, počítá zrušené. Management by dostal falešná čísla.
3. **Obrázky v databázi** -- `byte[]` v Room entitě nafukuje DB a zpomaluje dotazy.
4. **1265-řádkový komponent** -- `ReservationManagePage.razor` je neudržitelný monolith.
5. **Blazor Server pro public pages** -- SEO problém, škálovatelnost problém.
6. **DateTime.Now v seedech** -- Nedeterministické migrace.
7. **Faktura nesplňuje české zákony** -- Chybí IČO, DIČ, sekvenční číslo, daňový rozpad.
8. **Cílení na všechny segmenty** -- S malým týmem je to rozptýlení energie. Enterprise segment vyžaduje funkce, které jsou roky vývoje daleko.

### SÍLA -- Tohle funguje (stavěj na tom)

1. **Clean Architecture základ** -- 4 vrstvy, DI, Repository pattern. Záměr je správný, implementace potřebuje opravu, ale základ je dobrý.
2. **Multi-měnová podpora** -- Konverzní kurzy s precision 18,6, přepočet při vytváření rezervace. Tohle mají i dražší systémy špatně.
3. **Multi-guest model** -- Hlavní host + další hosté přes join tabulku. Správný hospitality model.
4. **Doplňkové služby** -- Per-night, per-person, one-time typy. Flexibilní a správně navržené.
5. **Česká lokalizace** -- UI, seed data, stravovací plány v češtině. Pro český trh výhoda.
6. **Docker deployment** -- docker-compose.yml je ready. Snadné nasazení.
7. **Konfigurovatelný admin** -- 10 lookup tabulek v admin nastavení. Hotel si může přizpůsobit statusy, typy, služby.
8. **Dva režimy rezervace** -- Vytvoření "podle data" a "podle pokoje" je intuitivní pro recepční.

### PŘIDEJ -- Tohle tam chybí a mělo by být

1. **REST API vrstva** (Minimal API) -- základ pro vše ostatní
2. **Channel manager integrace** (Booking.com API jako první)
3. **Booking engine** (veřejná stránka s dostupností a formulářem)
4. **Emailový systém** (potvrzení, připomínky, komunikace)
5. **Platební brána** (GoPay pro CZ, Stripe pro INT)
6. **Check-in / Check-out workflow** s více stavy rezervace
7. **Night audit / denní uzávěrka**
8. **Rate plans** (sezónní, víkend/všední, balíčky)
9. **Reporting** (RevPAR, ADR, obsazenost %, tržby po období)
10. **Hotel profil** (název, adresa, IČO, DIČ, logo -- pro faktury a booking engine)
11. **Audit log** (kdo co kdy změnil)
12. **Unit testy** (aspoň pro business logiku)

---

## TOP 5 Akcí -- Co udělat PRVNÍ

### 1. Přidat REST API vrstvu (2-3 týdny)

**Proč:** Odemyká VŠECHNY budoucí integrace. Bez API nelze napojit platby, OTA, email, mobilní app.

**Jak:** Minimal API v `Program.cs`. Zároveň přesunout business logiku z repositories do services.

### 2. Opravit bezpečnost (1 týden)

**Proč:** Bez toho nesmíte nasadit s reálnými daty.

**Jak:** User Secrets pro lokální dev, env variables pro Docker. Smazat test credentials z LoginPage. Šifrovat citlivá data zákazníků.

### 3. Přidat validaci dostupnosti + více stavů rezervace (1-2 týdny)

**Proč:** Overbooking = katastrofa. Hotel bez check-in/check-out neví, kdo je na pokoji.

**Jak:** Server-side kontrola překrývajících se rezervací v `CreateReservationAsync`. Přidat stavy: Pending, CheckedIn, CheckedOut, NoShow.

### 4. Postavit jednoduchý booking engine (3-4 týdny)

**Proč:** Bez online rezervací žádný hotel systém nekoupí.

**Jak:** Blazor SSR public pages (SEO), dostupnost, formulář, email potvrzení. Pro MVP bez platební brány (hotel potvrdí ručně).

### 5. Napojit email systém (1 týden)

**Proč:** Potvrzení rezervace emailem je absolutní minimum.

**Jak:** SendGrid free tier (100 emails/den) nebo SMTP. Email šablony pro potvrzení, storno, připomínku před příjezdem.

---

## MVP Scope -- Minimum pro prvního platícího zákazníka

### Interní Dashboard (opravy stávajícího)

- [ ] Opravit revenue výpočet (filtr na měnu + nekancelované + zaplacené)
- [ ] Přidat server-side validaci dostupnosti
- [ ] Přidat stavy: Pending, CheckedIn, CheckedOut, NoShow
- [ ] Přidat check-in / check-out tlačítka na rezervaci
- [ ] Přidat hotel profil (název, adresa, IČO, DIČ, logo)
- [ ] Opravit fakturu -- legálně platný formát pro ČR
- [ ] Opravit bezpečnost (credentials, šifrování)
- [ ] Paginace na DB úrovni (ne načítat vše do paměti)

### Zákaznický Portál (nový)

- [ ] Veřejná stránka s pokoji hotelu (SSR, SEO-friendly)
- [ ] Vyhledávání dostupnosti (datum + hosté)
- [ ] Booking formulář (jméno, email, telefon, speciální požadavky)
- [ ] Email potvrzení s referenčním číslem
- [ ] Stránka pro zobrazení/storno rezervace přes referenční kód

### Infrastruktura

- [ ] REST API vrstva (Minimal API)
- [ ] Email integrace (SendGrid/SMTP)
- [ ] Aspoň základní unit testy pro business logiku
- [ ] CI/CD pipeline (GitHub Actions)

### Co NENÍ v MVP

- Channel manager (fáze 2)
- Online platby (fáze 2)
- Multi-tenancy (single-tenant deploy pro prvního zákazníka)
- Dynamic pricing (fáze 3)
- Mobilní app (fáze 3+)

**Odhadovaný scope:** 3-4 měsíce full-time pro jednoho vývojáře.

---

## Verdikt

**HoaP je kvalitní učební/portfoliový projekt, který demonstruje solidní znalost .NET/Blazor ekosystému a principů Clean Architecture. Jako SaaS produkt ale v současném stavu není prodejný -- chybí VŠECHNY funkce, které oddělují interní tool od komerčního hotelového systému: API, integrace, booking engine, platby, email.**

Propast mezi aktuálním stavem a nejlevnějším konkurentem (Previo Lite) je přibližně 6-12 měsíců full-time vývoje. Největší chybějící kus není žádná jednotlivá funkce -- je to **kompletní absence externí komunikace** (žádné API, žádné webhooky, žádné emaily, žádné platby, žádný channel manager).

**Proti komu má šanci vyhrát:** Proti Excelu, papíru, a ručnímu řízení -- ale pouze pokud nabídnete booking engine + email potvrzení + jednoduché UI za agresivní cenu (100-200 Kč/pokoj/měsíc, žádný setup fee).

**Proti komu prohraje:** Proti Previo, Mews, Better Hotel, Cloudbeds -- ti mají vše, co HoaP nemá, plus roky vývoje a tisíce zákazníků.

**Za jakých podmínek to může fungovat:**

1. **Laser focus** na malé české penziony (5-20 pokojů) místo "všechny segmenty"
2. **Booking engine + email** jako priorita č. 1 (ne další admin features)
3. **Agresivní cenová politika** -- výrazně levnější než Previo
4. **Jeden pilotní hotel zdarma** -- získat reálnou zpětnou vazbu dříve, než budete dál programovat
5. **API-first přístup** od teď -- každá nová funkce jako API endpoint + UI nad tím

Pokud splníte tyto podmínky a najdete 1-2 pilotní penziony, máte šanci vybudovat niche produkt pro mikro-segment českého trhu. Ale přestaňte přidávat admin features a začněte budovat to, co přináší hodnotu hotelům: **online rezervace s potvrzením**.

---

*Zdroje pro competitive intelligence:*
- [Previo ceník](https://www.previo.cz/en/pricelist/)
- [Mews pricing](https://www.mews.com/en/pricing)
- [Mews $300M funding at $2.5B valuation](https://siliconangle.com/2026/01/23/hotel-software-maker-mews-nabs-300m-2-5b-valuation/)
- [Previo PMS](https://www.previo.cz/en/)
- [Better Hotel](https://better-hotel.com/en/)
- [Cloudbeds pricing](https://www.cloudbeds.com/pricing/)
