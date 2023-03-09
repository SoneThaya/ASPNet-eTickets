﻿using ASPNETmovieEtickets.Models;

namespace ASPNETmovieEtickets.Data.Services
{
    public interface IActorsServices
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}