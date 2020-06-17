using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;
using Measurement.UI;
using Measurement.UI.Views;

namespace Measurement.Module
{
    public class MeasurementModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", typeof(MeasurementView));

            var navigationRegistry = containerProvider.Resolve<INavigationRegistry>();
            navigationRegistry.RegisterNavigationStep(typeof(MeasurementModule), typeof(MeasurementView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
