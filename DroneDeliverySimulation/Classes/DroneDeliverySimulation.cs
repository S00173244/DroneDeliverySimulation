using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDeliverySimulation
{
    public class DroneDeliverySimulation 
    {
        ControlCenter controlCenter;
    
        public void RunSimulation()
        {
            if (controlCenter != null)
            {
                controlCenter.Update();
            }
            else SimulationInitializer.SetupAControlCenter(ref controlCenter);
        }     
    }

 
}
