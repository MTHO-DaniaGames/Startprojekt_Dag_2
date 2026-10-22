using Bogkatalog.Api.Contracts;
using Bogkatalog.Api.Services;
using Bogkatalog.Api.Validation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<BookStore>();
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok", service = "Bogkatalog.Api" }));

// GRØN A: Registrér GET /api/books og GET /api/books/{id:int} her.
// GRØN B: Registrér POST /api/books med validation her.
// GUL: Registrér PUT og DELETE her.
// RØD: Udvid det eksisterende GET /api/books med et title-filter.

app.Run();
