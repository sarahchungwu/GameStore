﻿using GameStore.Api.Data;
using GameStore.Api.Dtos;
using GameStore.Api.Entities;
using GameStore.Api.Mapping;

namespace GameStore.Api.EndPoints;

public static class GamesEndpoints
{
  const string GetGameEndPointName = "GetGame";
  private static readonly List<GameDto> games = [new(1, "Street Fighter II", "Fighting", 19.99M, new DateOnly(1992, 7, 15)), new(2, "Final Fantasy XIV", "Roleplaying", 59.99M, new DateOnly(2010, 9, 30)), new(3, "FIFA 23", "Sports", 69.99M, new DateOnly(2022, 9, 17))];

  public static RouteGroupBuilder MapGamesEndpoint(this WebApplication app)
  {

    var group = app.MapGroup("games").WithParameterValidation();
    // GET /games
    group.MapGet("/", () => games);

    // GET /games/1
    group.MapGet("/{id}", (int id) =>
    {
      GameDto? game = games.Find(game => game.Id == id);

      return game is null ? Results.NotFound() : Results.Ok(game);

    }).WithName(GetGameEndPointName);

    // POST /games
    group.MapPost("/", (CreateGameDto newGame, GameStoreContext dbContext) =>
    {

      Game game = newGame.ToEntity();
      game.Genre = dbContext.Genres.Find(newGame.GenreId);

      dbContext.Games.Add(game);
      dbContext.SaveChanges();


      return Results.CreatedAtRoute(GetGameEndPointName, new { id = game.Id }, game.ToDto());
    });

    // PUT /games/1
    group.MapPut("/{id}", (int id, UpdateGameDto updateGame) =>
    {

      var index = games.FindIndex(game => game.Id == id);
      if (index == -1)
      {
        return Results.NotFound();
      }
      games[index] = new GameDto(id, updateGame.Name, updateGame.Genre, updateGame.Price, updateGame.ReleaseDate);
      return Results.NoContent();

    });

    // DELETE /games/1
    group.MapDelete("/{id}", (int id) =>
    {
      games.RemoveAll(game => game.Id == id);
      return Results.NoContent();
    });

    return group;


  }


}
