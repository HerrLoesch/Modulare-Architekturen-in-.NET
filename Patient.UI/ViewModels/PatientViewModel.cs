using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;
using Prism.Commands;

namespace Patient.UI.ViewModels
{
    public class PatientViewModel
    {
        private INavigationService navigationService;

        public DelegateCommand NavigateNextCommand { private set; get; }

        public PatientViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            NavigateNextCommand = new DelegateCommand(GoToNext);
        }

        private void GoToNext()
        {
            navigationService.Next();
        }
    }
}
