# HoaP -- TODO

Kompletni seznam uloh z auditu, rozdeleny podle priority a kategorie.

---

## HOTOVO

- [x] Odstranit test credentials z LoginPage
- [x] Presunout connection string do Development configu, produkcni placeholder
- [x] Fixni GUIDs a datumy v seed datech (deterministicke migrace)
- [x] Odstranit duplicitni Reservation->Invoice konfiguraci v DbContext
- [x] Opravit revenue vypocet (filtr na menu, nekancelovane, zaplacene)
- [x] Pridat AsNoTracking pro read-only dotazy v repositories
- [x] Pridat DB-level paginaci (dashboard nacita jen aktualni mesic)
- [x] Pridat stavy rezervace: Pending, CheckedIn, CheckedOut, NoShow
- [x] Pridat check-in/check-out workflow (tlacitka + zmena statusu)
- [x] Server-side validace dostupnosti v CreateReservationAsync (overbooking ochrana)
- [x] Presunout business logiku z repositories do services (ReservationService)
- [x] Pridat DB indexy (Reservation Room+Dates, CustomerId, StatusId, Room StatusId, Invoice IsPaid+DueDate)
- [x] Opravit typo IDashBoardRepsoitory -> IDashBoardRepository
- [x] Pridat Hotel profil entitu (nazev, adresa, ICO, DIC, logo)
- [x] Repositories vracet Domain entity misto ViewModelu (mapovani do services)
- [x] Odstranit hardcoded admin heslo (presunuto do DbInitializer + appsettings)
- [x] Odstranit SqlServer NuGet balicek (dead dependency)
- [x] Sifrovat citliva data zakazniku (AES-256, PersonalIdentificationNumber + DocumentNumber)
- [x] Pridat rate limiting na login (Identity lockout, 5 pokusu / 15 min)
- [x] Odstranit referenci Application vrstvy na Microsoft.AspNetCore.Components.Web
- [x] Opravit naming ServiceService -> AddonService
- [x] Pridat zdroj rezervace (ReservationSource: Walk-in, Telefon, Web, OTA, Email)
- [x] Pridat audit log (automaticky tracking zmen v SaveChangesAsync)
- [x] Opravit fakturu -- legalne platny format pro CR (ICO, DIC, sekvencni cislo, DPH rozpad, DUZP)
- [x] Pridat REST API vrstvu (Minimal API endpointy pro Rooms, Reservations, Customers, Invoices, Dashboard)
- [x] Pridat public booking engine (vyhledavani pokoju, rezervacni formular, potvrzeni, lookup)

---

## PRIORITA 3: Architektura & Kvalita kodu

### Databaze
- [ ] Presunout obrazky pokoju z byte[] v DB na blob storage/CDN

### Kod
- [ ] Rozdelit ReservationManagePage.razor (1265 radku) na mensi komponenty
- [ ] Pridat global exception handler (misto try-catch v komponentach)

### Testovani
- [ ] Pridat unit testy pro business logiku
- [ ] Pridat integracni testy

---

## PRIORITA 4: Infrastruktura

- [ ] Pridat structured logging (Serilog)
- [ ] Pridat health checks (app.MapHealthChecks())
- [ ] Obnovit CI/CD pipeline (GitHub Actions)
- [ ] Pridat email system (potvrzeni rezervace, SendGrid/SMTP)

---

## PRIORITA 5: Zakaznicky portal - rozsireni

### UX
- [ ] Mobile-first design (60%+ rezervaci z mobilu)
- [ ] Oddelena guest autentikace (magic link / reservation code) od staff auth
- [ ] Email potvrzeni s referencnim cislem

---

## PRIORITA 6: Pokrocile funkce (faze 2+)

- [ ] Channel manager integrace (Booking.com API)
- [ ] Platebni brana (GoPay pro CZ, Stripe pro INT)
- [ ] Night audit / denni uzaverka
- [ ] Rate plans (sezonni ceny, vikend/vsedni den, balicky)
- [ ] Dynamic pricing
- [ ] Reporting (RevPAR, ADR, obsazenost %, trzby po obdobi)
- [ ] Multi-tenancy (TenantId + global query filters nebo DB-per-tenant)
- [ ] Online check-in (formular s osobnimi udaji pred prijezdem)
- [ ] Upselling (upgrade pokoje, snidane, parkovani)
- [ ] Multi-jazyk (CZ, EN, DE)
- [ ] Hodnoceni po pobytu
- [ ] Skupinove rezervace (konference, allotmenty)
- [ ] Mobilni app
- [ ] Caching (IMemoryCache, IDistributedCache)
- [ ] Graceful handling pri SignalR disconnectu
