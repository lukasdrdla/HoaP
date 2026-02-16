# HoaP - Interní hotelový systém

Webová aplikace pro správu hotelových operací postavená na **Blazor Server** a **.NET 8**. Systém pokrývá kompletní agendu hotelu - rezervace, správu pokojů, zákazníky, fakturaci, platby, zaměstnance a doplňkové služby.

## Technologie

| Vrstva | Technologie |
|--------|-------------|
| **Frontend** | Blazor Server (Interactive Server Mode), Bootstrap 5, Bootstrap Icons |
| **Backend** | ASP.NET Core 8.0, C# 12 |
| **ORM** | Entity Framework Core 8.0 |
| **Databáze** | MySQL 8 |
| **Autentizace** | ASP.NET Core Identity (role: Admin, Manager, Receptionist) |
| **Mapování** | AutoMapper 13 |
| **PDF generování** | QuestPDF |
| **Kontejnerizace** | Docker, Docker Compose |

## Architektura

Projekt používá **Clean Architecture** se 4 vrstvami:

```
HoaP.Web                  → Prezentační vrstva (Blazor komponenty, stránky)
HoaP.Application           → Aplikační vrstva (služby, ViewModely, AutoMapper profily)
HoaP.Infrastructure        → Infrastrukturní vrstva (repozitáře, DbContext, migrace)
HoaP.Domain                → Doménová vrstva (entity, rozhraní)
```

```
┌──────────────────────────────────────────────┐
│         HoaP.Web (Blazor Server)             │
│   45 Razor stránek, komponenty, layouty      │
├──────────────────────────────────────────────┤
│         HoaP.Application                     │
│   22 služeb, 19 AutoMapper profilů, DTOs     │
├──────────────────────────────────────────────┤
│         HoaP.Infrastructure                  │
│   20 repozitářů, EF Core DbContext           │
├──────────────────────────────────────────────┤
│         HoaP.Domain                          │
│   24 entit, rozhraní repozitářů              │
├──────────────────────────────────────────────┤
│         MySQL 8 databáze                     │
└──────────────────────────────────────────────┘
```

### Použité návrhové vzory

- **Repository Pattern** - abstrakce přístupu k datům
- **Dependency Injection** - všechny služby registrovány přes DI kontejner
- **DTO Pattern** - ViewModely oddělují UI od doménových entit
- **Mapper Pattern** - AutoMapper pro konverzi entit na DTOs

## Funkce

### Dashboard
- Statistiky v reálném čase (zákazníci, rezervace, pokoje, tržby)
- Interaktivní kalendář rezervací
- Přehled aktuálních rezervací s filtrováním a stránkováním

### Správa rezervací
- CRUD operace nad rezervacemi
- Přiřazení více hostů k jedné rezervaci
- Výběr doplňkových služeb (parking, wellness, domácí mazlíčci aj.)
- Sledování stavu rezervace (Potvrzená / Zrušená)
- Podpora více měn
- Speciální požadavky a administrátorské poznámky

### Správa pokojů
- Evidence pokojů se stavy (Volný / Obsazený / Mimo provoz / Vyžaduje úklid)
- Typy pokojů: Jednolůžkový, Dvoulůžkový, Třílůžkový, Rodinný
- Správa vybavení pokojů (Wi-Fi, klimatizace, TV)
- Ceník a kapacita (max. dospělí/děti)
- Kontrola dostupnosti

### Správa zákazníků
- Kompletní profily hostů s doklady
- Ověření identity (pas, číslo OP)
- Kontaktní údaje a adresy
- Systém recenzí a hodnocení (1-5)

### Fakturace a platby
- Tvorba faktur z rezervací s položkami
- Generování PDF faktur (QuestPDF)
- Slevy a zálohy
- Evidence plateb (Hotovost / Karta / Bankovní převod)
- Podpora více měn s kurzem

### Správa zaměstnanců
- Profily zaměstnanců s údaji o mzdě
- Přiřazení pojišťovny
- Pozice a stav zaměstnání
- Systém úkolů

### Administrace
- Správa vybavení, měn, pojišťoven, stravovacích plánů
- Konfigurace platebních metod, stavů rezervací, rolí
- Správa stavů pokojů, typů pokojů, doplňkových služeb

## Struktura projektu

```
HoaP/
├── HoaP.Domain/                    # Doménová vrstva
│   ├── Entities/                   # 24 entitních tříd (Reservation, Room, Customer, Invoice...)
│   └── Interfaces/                 # Rozhraní repozitářů
│
├── HoaP.Application/               # Aplikační vrstva
│   ├── Services/                   # 22 služeb (ReservationService, InvoiceService...)
│   ├── Interfaces/                 # Kontrakty služeb a repozitářů
│   ├── Mappings/                   # 19 AutoMapper profilů
│   └── ViewModels/                 # DTOs pro přenos dat
│
├── HoaP.Infrastructure/            # Infrastrukturní vrstva
│   ├── Data/                       # ApplicationDbContext (21+ DbSetů)
│   ├── Repositories/               # 20 implementací repozitářů
│   └── Migrations/                 # EF Core migrace
│
├── HoaP.Web/                       # Prezentační vrstva
│   ├── Components/
│   │   ├── Pages/                  # 45 Razor stránek
│   │   │   ├── Home.razor          # Dashboard s kalendářem
│   │   │   ├── Account/            # Přihlášení/Odhlášení
│   │   │   ├── Reservations/       # Správa rezervací
│   │   │   ├── Rooms/              # Správa pokojů
│   │   │   ├── Customers/          # Správa zákazníků
│   │   │   ├── Invoices/           # Správa faktur
│   │   │   ├── Payments/           # Správa plateb
│   │   │   ├── Employees/          # Správa zaměstnanců
│   │   │   ├── AdminSettings/      # Administrace (10 stránek)
│   │   │   └── Review/             # Recenze hostů
│   │   ├── Layout/                 # Navigace a layouty
│   │   └── Modals/                 # Znovupoužitelné modální komponenty
│   ├── Dockerfile                  # Multi-stage Docker build
│   └── wwwroot/                    # Statické soubory
│
├── docs/                           # Dokumentace (EA diagram)
├── docker-compose.yml              # Docker orchestrace
└── HoaP.sln                        # Visual Studio solution
```

## Spuštění projektu

### Docker Compose (doporučeno)

```bash
docker-compose up
```

- Webová aplikace: **http://localhost:8080**
- MySQL databáze: port **3306**

### Lokální vývoj

**Předpoklady:** .NET 8 SDK, MySQL 8

1. Spusťte MySQL server
2. Upravte connection string v `HoaP.Web/appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "server=localhost;port=3306;database=hoapdb;user=root;password=root;"
     }
   }
   ```
3. Aplikujte migrace a spusťte aplikaci:
   ```bash
   cd HoaP.Web
   dotnet ef database update --project ../HoaP.Infrastructure
   dotnet run
   ```
4. Otevřete **http://localhost:5228** nebo **https://localhost:7122**

### Testovací přihlášení

| Email | Heslo | Role |
|-------|-------|------|
| admin@admin.com | Admin123456789! | Admin |

## Databázový model

### Hlavní entity

- **Reservation** - rezervace s vazbou na pokoj, hosta, stravovací plán a služby
- **Room** - hotelový pokoj s typem, stavem, cenou a vybavením
- **Customer** - host s osobními údaji a doklady
- **Invoice** / **InvoiceItem** - faktura s položkami
- **Payment** - platba přiřazená k faktuře
- **AppUser** / **AppRole** - zaměstnanec s rolí (Identity)
- **Service** - doplňková služba (za noc / za osobu / jednorázová)

### Konfigurační entity

RoomType, RoomStatus, ReservationStatus, Currency, MealPlan, PaymentMethod, Amenity, InsuranceCompany

### Vazby

- **1:N** - Room → Reservations, Customer → Reservations, Invoice → Payments, Invoice → InvoiceItems
- **M:N** - Room ↔ Amenity (přes RoomAmenity), Reservation ↔ Customer (přes ReservationCustomer), Reservation ↔ Service (přes ServiceReservation)

## Proměnné prostředí

| Proměnná | Popis | Výchozí hodnota |
|----------|-------|-----------------|
| `ASPNETCORE_ENVIRONMENT` | Prostředí aplikace | Development |
| `ConnectionStrings__DefaultConnection` | Connection string k MySQL | viz docker-compose.yml |
| `MYSQL_ROOT_PASSWORD` | Root heslo MySQL | root |
| `MYSQL_DATABASE` | Název databáze | hoapdb |
| `MYSQL_USER` | Uživatel MySQL | hoapuser |
| `MYSQL_PASSWORD` | Heslo uživatele MySQL | hoappass |

## Licence

QuestPDF je použit pod komunitní licencí.
