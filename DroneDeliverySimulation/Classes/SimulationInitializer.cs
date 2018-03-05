using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDeliverySimulation
{
    public static class SimulationInitializer
    {

       private static Random rn = new Random();

        
       public static bool SetupAControlCenter(ref ControlCenter controlCenter)
        {
            if (GenerateSimulationComponentsForAControlCenter(controlCenter, 5, 5)) return true;
            else return false;
        }

        public static bool GenerateSimulationComponentsForAControlCenter(ControlCenter controlCenter, int numberOfDrones, int numberOfWarehouses)
        {
            if (CreateDronesForAControlCenter(controlCenter, numberOfDrones) && CreateWarehousesForAControlCenter(controlCenter, numberOfWarehouses)) return true;
            else return false;
            
        }

        public static bool CreateDronesForAControlCenter(ControlCenter controlCenter, int numberOfDrones)
        {

            try
            {
                for (int i = 0; i < numberOfDrones; i++)
                {
                    controlCenter.DroneList.Add(new Drone());
                }

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error While Creating Drones {0} ",e.Message);

                return false;
            }
            



        }


        public static bool CreateWarehousesForAControlCenter(ControlCenter controlCenter, int numberOfWarehouses)
        {
            try
            {
                for (int i = 0; i < numberOfWarehouses; i++)
                {
                    Warehouse warehouse = new Warehouse();
                    AddPackagesToAWarehouse(warehouse);
                    controlCenter.WarehouseList.Add(warehouse);

                }

                return true;
            }

            catch (Exception e)
            {

                Console.WriteLine("Error While Creating Warehouses {0} ", e.Message);

                return false;
            }
        }

        public static bool AddPackagesToAWarehouse(Warehouse warehouse)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    warehouse.PackageList.Add(new Package(new Recipient(), rn.Next(1,20)));
                }
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error While Adding Packages {0} ", e.Message);
                return false;
            }
        }
    }
}
