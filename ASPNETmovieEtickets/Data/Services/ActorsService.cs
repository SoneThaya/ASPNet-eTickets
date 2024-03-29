﻿using ASPNETmovieEtickets.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETmovieEtickets.Data.Services
{
    public class ActorsService : IActorsServices
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Actor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
