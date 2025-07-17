using secbackend.DbCntectextes;
using secbackend.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("books/list", () =>
{
    return "books list";
}

);
app.MapPost("books/create", (Book book) =>
{
    using var db = new LibraryDb();
    db.Books.Add(book);
    db.SaveChanges();
    return "book created";
});
app.MapPut("books/update", () =>
{
    return "book updated";
}

);
app.MapDelete("books/remove", () =>
{
    return "book removed";
}
);

app.Run();

