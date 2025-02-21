using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);
// rendering the app
var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

await app.MigrateDbAsync();

app.Run();
