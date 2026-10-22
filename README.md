# Bogkatalog · dag 2

Åbn Bogkatalog.slnx i Visual Studio. Sæt Bogkatalog.Api som Startup Project, og start med Ctrl+F5.
API'et lytter normalt på http://localhost:5200. Kontrollér adressen i konsollen.

Alternativt fra solution-mappen:

```powershell
dotnet run --project src/Bogkatalog.Api --urls http://localhost:5200
```

Åbn src/Bogkatalog.Api/Bogkatalog.Api.http i Visual Studio. Klik Send Request ved den request, du vil teste. API'et skal allerede køre.
Start med A0. A1 og resten virker først, når du har implementeret de relevante endpoints.
### adskiller requests. Den tomme linje mellem Content-Type og JSON skal bevares.

## Det er gjort klar

- Models/Book.cs: bogens data i API'et. En record samler værdier i et objekt.
- Contracts/BookInput.cs: input til POST og PUT, uden Id.
- Services/BookStore.cs: en delt liste med GetAll, GetById, Add, Update og Delete.
- Validation/BookRules.cs: kontrollerer titel, forfatter og sidetal. Du skal selv kalde metoden i dine endpoints.
- Program.cs: /health og registrering af BookStore. Bog-endpoints tilføjer du i øvelserne.

BookStore deles af requests til den samme API-process. Data findes kun i hukommelsen og nulstilles ved genstart.
Web er stadig den oprindelige Blazor-app med eget repository. Den viser ikke API'ets data endnu.
Du behøver kun starte API'et til dagens API-øvelser.

## Rækkefølge

Grøn A: GET-listen og GET med Id. Grøn B: POST med validation og 201 Created.
Gul: PUT og DELETE. Rød: filtrér den eksisterende GET-liste med ?title=.
Brug Loesningsforslag til sammenligning, hvis du går i stå. Kør kun én udgave af API'et på port 5200 ad gangen.

I Loesningsforslag er alle endpoints implementeret, inklusive det røde title-filter.
