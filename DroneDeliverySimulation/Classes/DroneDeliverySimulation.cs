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

        int totalTicks = 100;
        int startingTick = 0;

        public void RunSimulation()
        {

            do
            {
                if (controlCenter != null)
                {
                    controlCenter.Update();
                    controlCenter.DroneList.ForEach(drone => drone.Update());
                    controlCenter.WarehouseList.ForEach(warehouse => warehouse.Update());

                }
                else SimulationInitializer.SetupAControlCenter(ref controlCenter);
            } while ((startingTick++) < 100);
            
           
        }     
    }

 
}
