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
            controlCenter = new ControlCenter();
            if (GenerateSimulationComponentsForAControlCenter(ref controlCenter, 5, 5)) return true;
            else return false;
        }

        public static bool GenerateSimulationComponentsForAControlCenter(ref ControlCenter controlCenter, int numberOfDrones, int numberOfWarehouses)
        {
            if (CreateDronesForAControlCenter(ref controlCenter, numberOfDrones) && CreateWarehousesForAControlCenter(controlCenter, numberOfWarehouses)) return true;
            else return false;
            
        }

        public static bool CreateDronesForAControlCenter(ref ControlCenter controlCenter, int numberOfDrones)
        {

            try
            {
                controlCenter.DroneList = new List<Drone>();
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
                controlCenter.WarehouseList = new List<Warehouse>();
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
                warehouse.PackageList = new List<Package>();
                for (int i = 0; i < 10; i++)
                {
                    warehouse.PackageList.Add(new Package(new Recipient(), rn.Next(1,20)));
                }

                warehouse.PackagesAwaitingForDronePickup = new List<Package>();
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
