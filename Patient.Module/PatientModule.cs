using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;
using Patient.Data;
using Patient.Interfaces.Data;
using Patient.UI;
using Patient.UI.Views;

namespace Patient.Module
{
    public class PatientModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", typeof(PatientView));

            var navigationRegistry = containerProvider.Resolve<INavigationRegistry>();
            navigationRegistry.RegisterNavigationStep(typeof(PatientModule), typeof(PatientView));

            var navigationService = containerProvider.Resolve<INavigationService>();
            navigationService.NavigateTo(typeof(PatientModule));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IPatientRepository, PatientRepository>();
        }
    }
}
