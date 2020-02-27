using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using InternationalBusinessMen.DAL;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Models.WebModels;
using InternationalBusinessMen.Services.API.WebAPI;
using InternationalBusinessMen.Services.CheckConexionService;
using InternationalBusinessMen.Services.Converter;
using InternationalBusinessMen.Services.Deserializer;
using InternationalBusinessMen.Services.Excepciones;
using InternationalBusinessMen.Services.GenericRepository;
using InternationalBusinessMen.Services.Log;

namespace InternationalBusinessMen.Services.TransferirDatos
{
    public class TransferirDatos : ITransferirDatos
    {
        private readonly IWebAPIRepository _repoWebApi;
        private readonly IDeserializer _JsonConvert;
        private readonly IDeserializer _jsonTransacion;
        private readonly IConverterConversion _converterConversion;
        private readonly IConverterTransacion _converterTransacion;
        private readonly IGenericRepository<ConversionModelBD> _conversionRepository;
        private readonly IGenericRepository<TransacionModelBD> _transacionRepository;
        private readonly ILog _logger;
        private readonly ICheckConexion _checkConexion;

        public TransferirDatos(

            IWebAPIRepository repoWebApi, 
            IDeserializer JsonConvert,
            IDeserializer jsonTransacion, 
            IConverterConversion converterConversion,
            IConverterTransacion converterTransacion,
            IGenericRepository<ConversionModelBD> ConversionRepository,
            IGenericRepository<TransacionModelBD> transacionRepository,
            ILog logger,
            ICheckConexion checkConexion
        )
        {
            _repoWebApi = repoWebApi;
            _JsonConvert = JsonConvert;
            _jsonTransacion = jsonTransacion;
            _converterConversion = converterConversion;
            _converterTransacion = converterTransacion;
            _conversionRepository = ConversionRepository;
            _transacionRepository = transacionRepository;
            _logger = logger;
            _checkConexion = checkConexion;
        }

        public async Task TransferirData()
        {
            if (await _checkConexion.Check("http://quiet-stone-2094.herokuapp.com/rates.json"))
            {
                _conversionRepository.RemoveTable();
                await TransferirConversiones();
            }

            if (await _checkConexion.Check("http://quiet-stone-2094.herokuapp.com/transactions.json"))
            {
                _conversionRepository.RemoveTable();
                await TransferirTransaciones();
            }
        }

        public async Task TransferirConversiones()
        {
            try
            {
                var ConversionesData = await Task.Run(() => _repoWebApi.DescargarDatos("http://quiet-stone-2094.herokuapp.com/rates.json"));
                var listaConversion = _JsonConvert.ConvertTo<ConversionModel>(ConversionesData);
                var listaBdModelConversion = _converterConversion.ConvertTo(listaConversion);
                await _conversionRepository.MeterRegistros(listaBdModelConversion);
                _conversionRepository.Save();
            }
            catch (Exception ex)
            {
                _logger.WriteException(ex);
                throw ex;
            }
        }

        public async Task TransferirTransaciones()
        {
            try
            {
                var TransacionesData = await Task.Run(() => _repoWebApi.DescargarDatos("http://quiet-stone-2094.herokuapp.com/transactions.json"));
                var listaTransacion = _jsonTransacion.ConvertTo<TransacionModel>(TransacionesData);
                var listaBdModelTransacion = _converterTransacion.ConvertTo(listaTransacion);
                await _transacionRepository.MeterRegistros(listaBdModelTransacion);
                _transacionRepository.Save();

            }
            catch (Exception ex)
            {
                _logger.WriteException(ex);
                throw ex;
            }
        }
    }
}