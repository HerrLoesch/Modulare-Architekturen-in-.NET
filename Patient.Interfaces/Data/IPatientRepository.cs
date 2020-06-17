using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient.Interfaces.Domain;

namespace Patient.Interfaces.Data
{
    public interface IPatientRepository
    {
        IEnumerable<PatientEntity> GetAll();
    }
}
