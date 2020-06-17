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
        public IEnumerable<PatientEntity> GetAll()
        {
            return new List<PatientEntity>()
            {
                new PatientEntity() {Firstname = "Hendrik", Lastname = "Lösch"},
                new PatientEntity() {Firstname = "Barack", Lastname = "Obama"},
                new PatientEntity() {Firstname = "Donald", Lastname = "Trump"}
            };
        }
    }
}
