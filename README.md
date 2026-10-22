# Bogkatalog · dag 2

## Fra dag 1 til dag 2

Dette er det fælles udgangspunkt efter dag 1:

- Blazor-appen har fortsat boglisten, formularen og sit lokale repository.
- API'et har både /health og /about. /about er løsningen på ekstraøvelsen fra dag 1 og returnerer name og version som JSON.
- Startbøgerne er nulstillet til Hobbitten og Frankenstein. Egne ændringer af titler og bøger tilføjet under dag 1 er ikke med i den fælles version.

Til dag 2 er BookStore, BookInput og BookRules tilføjet som hjælp til API-øvelserne. I startprojektet skal bog-endpoints stadig skrives i Program.cs. Blazor-appen kobles først til API'et senere.


Visual Studio skal have workloaden **ASP.NET and web development** installeret. Den giver blandt andet mulighed for at sende requests direkte fra .http-filer.

Åbn Bogkatalog.slnx i Visual Studio. Sæt Bogkatalog.Api som Startup Project, og start med Ctrl+F5.
API'et lytter normalt på http://localhost:5200. Kontrollér adressen i konsollen.

Alternativt fra solution-mappen:

```powershell
dotnet run --project src/Bogkatalog.Api --urls http://localhost:5200
```

Åbn src/Bogkatalog.Api/Bogkatalog.Api.http i Visual Studio. Klik Send Request ved den request, du vil teste. API'et skal allerede køre.
Start med **A0 Kontrol**, som kalder /health og skal give 200 OK. A0, A1 osv. er navne på testene i filen. Bog-endpoints giver 404, indtil du har implementeret dem i øvelserne.
`###` adskiller requests. Den tomme linje mellem Content-Type og JSON skal bevares.

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
Hints og løsningsforslag findes sidst i PowerPoint-præsentationen til dag 2. Kør kun én udgave af API'et på port 5200 ad gangen.

Dette repo indeholder startprojektet. Øvelser og kodegennemgang findes i PowerPoint-præsentationen til dag 2.


