using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using InternationalBusinessMen.DAL;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.Services.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private IBMContext _dbContext;
        private DbSet<T> table;

        public GenericRepository(IBMContext dbContext)
        {
            _dbContext = dbContext;
            table = _dbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var lista = await Task.Run(() => table.ToList()
            );
            return lista;

        }
        public async Task<T> GetById(object id)
        {
            var obj = await Task.Run(() => table.Find(id));
            return obj;
        }
        public async void Insert(T obj)
        {
            await Task.Run(() => table.Add(obj));
        }

        public async Task MeterRegistros(List<T> lista)
        {
            foreach (var item in lista)
            {
                await Task.Run(() => table.Add(item)).ConfigureAwait(false);
            }
        }

        public async void Update(T obj)
        {
            await Task.Run(() => table.Attach(obj));
            _dbContext.Entry(obj).State = EntityState.Modified;
        }
        public async void Delete(object id)
        {
            var obj = await Task.Run(() => table.Find(id));
            await Task.Run(() => table.Remove(obj));
        }

        public async void RemoveTable()
        {
            await Task.Run(() => table.RemoveRange(table));
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}