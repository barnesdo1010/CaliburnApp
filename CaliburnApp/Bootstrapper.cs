using AutoMapper;
using Caliburn.Micro;
using CaliburnApp.Models;
using CaliburnApp.ViewModels;
using DataAccessLibrary.HSPMelt;
using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace CaliburnApp
{
    public class Bootstrapper : BootstrapperBase
    {
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
            var container = new CompositionContainer();
            var batch = new CompositionBatch();
            batch.AddExport(ConfigureAutoMapper());
            batch.AddExport<IWindowManager>(new WindowManager());
            batch.AddExport<IEventAggregator>(new EventAggregator());

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
