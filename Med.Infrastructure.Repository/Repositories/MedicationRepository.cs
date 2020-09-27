using Med.Domain.Core.Interfaces.Repositories;
using Med.Domain.Models;
using Med.Infrastruture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Med.Infrastructure.Repository.Repositories
{
    public class MedicationRepository : IMedicationRepository
    {
        private readonly SqlContext _context;
        public MedicationRepository(SqlContext Context)
        {
            _context = Context;
        }

        public Medication GetById(int id)
        {
            return _context.Set<Medication>().Find(id);
        }

        public IEnumerable<Medication> GetAll()
        {
            return _context.Set<Medication>().ToList();
        }

        public Medication Add(Medication obj)
        {
            try
            {
                _context.Set<Medication>().Add(obj);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Medication obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(Medication obj)
        {
            try
            {
                _context.Set<Medication>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}