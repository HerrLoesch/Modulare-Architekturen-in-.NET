
using Infrastructure.Interfaces;
using Prism.Regions;
using System;
using System.Collections.Generic;

namespace Medizinsoftware.Infrastructure
{
    public class NavigationService : INavigationService, INavigationRegistry
    {
        Dictionary<Type, Type> registry = new Dictionary<Type, Type>();
        List<Type> moduleTypes = new List<Type>();
        private IRegionManager regionManager;
        private Type currentPosition;

        public NavigationService(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void NavigateTo(Type moduleType)
        {
            var viewType = registry[moduleType];
            this.regionManager.RequestNavigate("MainRegion", new Uri(viewType.Name, UriKind.Relative));

            this.currentPosition = moduleType;
        }

        public void Back()
        {
            var position = this.moduleTypes.IndexOf(currentPosition);
            var nextType = this.moduleTypes[--position];

            this.NavigateTo(nextType);
        }

        public void Next()
        {
            var position = this.moduleTypes.IndexOf(currentPosition);
            var nextType = this.moduleTypes[++position];

            this.NavigateTo(nextType);
        }

        public void RegisterNavigationStep(Type moduleType, Type stepView)
        {
            this.registry.Add(moduleType, stepView);
            this.moduleTypes.Add(moduleType);
        }

    }
}
