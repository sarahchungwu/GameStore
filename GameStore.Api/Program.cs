using GameStore.Api.Data;
using GameStore.Api.EndPoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);


var app = builder.Build();



app.MapGamesEndpoint();
app.MapGenresEndpoints();

await app.MigrateDbAsync();
app.Run();
