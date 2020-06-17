using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;
using Patient.Interfaces.Data;
using Patient.Interfaces.Domain;
using Prism.Commands;
using Prism.Mvvm;

namespace Patient.UI.ViewModels
{
    public class PatientViewModel : BindableBase
    {
        private INavigationService navigationService;
        private IPatientRepository patientRepository;
        private PatientEntity selectedPatient;

        public DelegateCommand NavigateNextCommand { private set; get; }
        public IEnumerable<PatientEntity> AvailablePatients { get; set; }

        public PatientEntity SelectedPatient
        {
            get => selectedPatient;
            set
            {
                selectedPatient = value;
                RaisePropertyChanged();
            } 
        }

        public PatientViewModel(INavigationService navigationService, Interfaces.Data.IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
            this.navigationService = navigationService;

            NavigateNextCommand = new DelegateCommand(GoToNext, () => SelectedPatient != null);
            NavigateNextCommand.ObservesProperty(() => SelectedPatient);

            Initialize();
        }

        public void Initialize()
        {
            this.AvailablePatients = this.patientRepository.GetAll();
        }

        private void GoToNext()
        {
            navigationService.Next(SelectedPatient.Id);
        }
    }
}
