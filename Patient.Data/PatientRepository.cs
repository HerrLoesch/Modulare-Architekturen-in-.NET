using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient.Interfaces.Data;
using Patient.Interfaces.Domain;

namespace Patient.Data
{
    public class PatientRepository : IPatientRepository
    {
        private List<PatientEntity> patients;

        public PatientRepository()
        {
            patients = new List<PatientEntity>()
            {
                new PatientEntity() {Firstname = "Hendrik", Lastname = "Lösch", Id = 1},
                new PatientEntity() {Firstname = "Barack", Lastname = "Obama", Id = 2},
                new PatientEntity() {Firstname = "Donald", Lastname = "Trump", Id = 3}
            };
        }

        public IEnumerable<PatientEntity> GetAll()
        {
            return patients;
        }

        public PatientEntity GetBy(int id)
        {
            return patients.Find(x => x.Id == id);
        }
    }
}
