using Autofac;
using Med.Application.Interfaces;
using Med.Application.Services;
using Med.Domain.Core.Interfaces.Repositories;
using Med.Domain.Core.Interfaces.Services;
using Med.Domain.Services.Services;
using Med.Infrastructure.CrossCutting.Adapter.Interfaces;
using Med.Infrastructure.CrossCutting.Adapter.Map;
using Med.Infrastructure.Repository.Repositories;
using System;

namespace Med.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Register IOC

            #region IOC Application
            builder.RegisterType<ApplicationMedicationService>().As<IApplicationMedicationService>();
            #endregion

            #region IOC Domain Services
            builder.RegisterType<DomainMedicationService>().As<IDomainMedicationService>();
            #endregion

            #region IOC Repositoriess SQL
            builder.RegisterType<MedicationRepository>().As<IMedicationRepository>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MedicationMapper>().As<IMedicationMapper>();
            #endregion

            #endregion

        }
    }
}
