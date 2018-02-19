using System;
using System.Collections.Generic;

namespace DroneDeliverySimulation
{
    public class ControlCenter
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

        
        public void CreateWarehouses()
        {

        }

        public void CreateDrones()
        {

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
            

        }

        public void Log()
        {

        }

    }
}