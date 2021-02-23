using GameSellingBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingBackendDemo.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(int Id);
        void Update(int Id);
    }
}