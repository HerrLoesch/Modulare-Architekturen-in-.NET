using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Interfaces.Domain
{
    public class PatientEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Id { get; set; }
    }
}
