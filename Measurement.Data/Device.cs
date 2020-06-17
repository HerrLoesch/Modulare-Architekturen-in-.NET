using Measurement.Interfaces;
using Measurement.Interfaces.Domain;

namespace Measurement.Data
{
    public class Device : IDevice
    {
        public MeasurementEntity Measure()
        {
            return new MeasurementEntity() { MeasuredValue = 42 };
        }
    }
}
