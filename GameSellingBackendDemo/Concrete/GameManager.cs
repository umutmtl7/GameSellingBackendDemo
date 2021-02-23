using GameSellingBackendDemo.Abstract;
using GameSellingBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSellingBackendDemo.Concrete
{
    public class GameManager : IGameService
    {
        List<Game> _games;
        public GameManager(List<Game> games)
        {
            _games = games;
        }
        public void Add(Game game)
        {
            _games.Add(game);
            Console.WriteLine("The game : " + game.Name + " is added.");
        }

        public void Delete(int Id)
        {
            Game gameToDelete = _games.SingleOrDefault(g => g.Id == Id);
            _games.Remove(gameToDelete);
        }

        public void Update(int Id)
        {
            Game gameToUpdate = _games.SingleOrDefault(g => g.Id == Id);
            string nameUpdated = gameToUpdate.Name += "+";
            Console.WriteLine("Game :" + gameToUpdate.Name + " is updated. New name of the game is : " + nameUpdated);
            gameToUpdate.Name = nameUpdated;
        }
        }
    }

