﻿using System.Net.Http;
using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using InternationalBusinessMen.DAL;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Services.API.WebAPI;
using InternationalBusinessMen.Services.CheckConexionService;
using InternationalBusinessMen.Services.Converter;
using InternationalBusinessMen.Services.Deserializer;
using InternationalBusinessMen.Services.GenericRepository;
using InternationalBusinessMen.Services.GetDataFromDB;
using InternationalBusinessMen.Services.Log;
using InternationalBusinessMen.Services.TransferirDatos;

namespace InternationalBusinessMen
{
    public class IoCConfiguration
    {
        public static void RegistrarControllers(ContainerBuilder builder)
        {
            builder.RegisterControllers
                (Assembly.GetExecutingAssembly());
        }

        public static void RegistrarRepos(ContainerBuilder builder)
        {
            builder.RegisterType<Log>()
                .As<ILog>().InstancePerRequest();

            builder.RegisterType<TransferirDatos>()
                .As<ITransferirDatos>().InstancePerRequest();

            builder.RegisterType<WebAPIRepository>()
                .As<IWebAPIRepository>().InstancePerRequest();

            builder.RegisterType<DeserializerConversionJson>()
                .As<IDeserializer>().InstancePerRequest();

            builder.RegisterType<DeserializerTransactionJson>()
                .As<IDeserializer>().InstancePerRequest();

            builder.RegisterType<ConversionToBdModel>()
                .As<IConverterConversion>().InstancePerRequest();

            builder.RegisterType<TransancionToBdModel>()
                .As<IConverterTransacion>().InstancePerRequest();

            builder.RegisterType<GenericRepository<ConversionModelBD>>()
                .As<IGenericRepository<ConversionModelBD>>().InstancePerRequest();

            builder.RegisterType<GenericRepository<TransacionModelBD>>()
                .As<IGenericRepository<TransacionModelBD>>().InstancePerRequest();

            builder.RegisterType<CheckConexion>()
                .As<ICheckConexion>().InstancePerRequest();

            builder.RegisterType<Data>()
                .As<IData>().InstancePerRequest();
        }

        public static void RegitrarClases(ContainerBuilder builder)
        {
            //builder.Register(z => new IBMContext()).
            //    InstancePerRequest();

            builder.Register(z => new HttpClient()).
                InstancePerRequest();
        }

        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();

            RegistrarControllers(builder);
            RegistrarRepos(builder);
            RegitrarClases(builder);

            IContainer contenedor = builder.Build();

            DependencyResolver.SetResolver
                (new AutofacDependencyResolver(contenedor));
        }
    }
}