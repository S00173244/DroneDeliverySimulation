using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDeliverySimulation
{
    public class RequestTypes
    {
        public enum Types { RequestADroneForDelivery };
        public Types Type { get; set; }
    }
}
