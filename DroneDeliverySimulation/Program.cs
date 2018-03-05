using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDeliverySimulation
{
    class Program
    {
        static void Main(string[] args)
        {

            DroneDeliverySimulation simulation = new DroneDeliverySimulation();

            do
            {
                simulation.RunSimulation();
            } while (true);
            
        }
    }
}
