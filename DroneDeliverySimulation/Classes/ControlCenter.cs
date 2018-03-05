using System;
using System.Collections.Generic;

namespace DroneDeliverySimulation
{
    public class ControlCenter : IDroneDeliverySimulationComponent
    {
        private List<Drone> droneList;
        private List<Warehouse> warehouseList;
        public ControlCenter()
        {
            
        }

        #region Accessors
        public List<Warehouse> WarehouseList
        {
            get
            {
                return warehouseList;
            }

            set
            {
                warehouseList = value;
            }
        }

        public List<Drone> DroneList
        {
            get
            {
                return droneList;
            }

            set
            {
                droneList = value;
            }
        }

        #endregion

        
        public bool AddAWarehouseToTheControlCenter(Warehouse warehouse)
        {
            
                this.warehouseList.Add(warehouse);
                return true;
            
        }
        public bool RemoveAWarehouseFromTheControlCenter(Warehouse warehouse)
        {

            if (this.WarehouseList.Remove(warehouse)) return true;
            else return false;
            
        }
        public bool AddADroneToTheControlCenter(Drone drone)
        {        
            this.droneList.Add(drone);
            return true;
        }

        public bool RemoveADroneFromTheControlCenter(Drone drone)
        {
            if (this.DroneList.Remove(drone)) return true;
            else return false;
        }

        public void FindTheNearestDroneToTheWarehouse(Warehouse warehouse)
        {

        }

        public bool IssueOrderToDrone()
        {
            return true;
        }

        public void Update()
        {
            foreach (Drone item in droneList)
            {
                item.Update(); 
            }
            foreach (Warehouse item in warehouseList)
            {
                item.Update();
            }
        }

        public void Log()
        {

        }

    }
}