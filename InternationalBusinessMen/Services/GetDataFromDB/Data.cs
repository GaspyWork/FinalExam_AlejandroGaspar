using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using InternationalBusinessMen.DAL;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Services.GenericRepository;
using Newtonsoft.Json;

namespace InternationalBusinessMen.Services.GetDataFromDB
{
    public class Data : IData
    {
        private IBMContext _dbContext;
        private IGenericRepository<ConversionModelBD> _genericConversionRepo;
        private IGenericRepository<TransacionModelBD> _genericTransacionRepo;

        public Data(IBMContext dbContext,IGenericRepository<ConversionModelBD> genericConversionRepo, IGenericRepository<TransacionModelBD> genericTransacionRepo)
        {
            _dbContext = dbContext;
            _genericConversionRepo = genericConversionRepo;
            _genericTransacionRepo = genericTransacionRepo;
        }

        public async Task<string> GetAllrates()
        {
            var query = await _genericConversionRepo.GetAll();

            string result = JsonConvert.SerializeObject(query);
            return result;
        }

        public async Task<string> GetAllTransactions()
        {
            var query = await _genericTransacionRepo.GetAll();

            string result = JsonConvert.SerializeObject(query);
            return result;
        }

        public string GettransacionBySKU()
        {
            throw new NotImplementedException();
        }
    }
}