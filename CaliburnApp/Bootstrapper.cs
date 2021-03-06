using AutoMapper;
using Caliburn.Micro;
using CaliburnApp.Models;
using CaliburnApp.ViewModels;
using DataAccessLibrary.HSPMelt;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace CaliburnApp
{
    public class Bootstrapper : BootstrapperBase
    {
        //dependancy injection
        private CompositionContainer container = new CompositionContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }


        protected override void Configure()
        {
            var batch = new CompositionBatch();
            batch.AddExportedValue(ConfigureAutoMapper());
            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());

            container.Compose(batch);
        }

        private IMapper ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BagHouse, BagHouseModel>().ReverseMap()
                .ForMember(dest => dest.BagHouseRecID, opt => opt.Ignore());
                cfg.CreateMap<Station, StationModel>().ReverseMap()
                .ForMember(dest => dest.StationID, opt => opt.Ignore());
            });

            return config.CreateMapper();
        }
    }
}
