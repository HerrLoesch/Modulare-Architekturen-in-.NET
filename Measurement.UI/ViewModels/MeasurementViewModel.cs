using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient.Interfaces.Data;
using Patient.Interfaces.Domain;
using Prism.Mvvm;
using Prism.Regions;

namespace Measurement.UI.ViewModels
{
    public class MeasurementViewModel : BindableBase, INavigationAware
    {
        private IPatientRepository patientRepository;
        private PatientEntity patient;

        public PatientEntity Patient
        {
            get => patient;
            set
            {
                patient = value;
                RaisePropertyChanged();
            }
        }

        public MeasurementViewModel(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var id = Convert.ToInt32(navigationContext.Parameters["id"]);
            this.Patient = this.patientRepository.GetBy(id);
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
