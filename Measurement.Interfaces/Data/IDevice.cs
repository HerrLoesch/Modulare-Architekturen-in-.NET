using Measurement.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement.Interfaces
{
    public interface IDevice
    {
        MeasurementEntity Measure();
    }
}
