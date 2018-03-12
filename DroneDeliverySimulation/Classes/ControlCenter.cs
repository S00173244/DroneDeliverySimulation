using DroneDeliverySimulation.Classes;
using System;
using System.Collections.Generic;

namespace DroneDeliverySimulation
{
    public class ControlCenter : IDroneDeliverySimulationComponent
    {
        private List<Drone> droneList;
        private List<Warehouse> warehouseList;
        private Queue<WarehouseRequest> warehouseRequests;
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

        public Queue<WarehouseRequest> WarehouseRequests
        {
            get
            {
                return warehouseRequests;
            }

            set
            {
                warehouseRequests = value;
            }
        }

        #endregion

        public bool AddAWarehouseRequestToTheList(WarehouseRequest warehouseRequest)
        {
            WarehouseRequests.Enqueue(warehouseRequest);
            return true;
        }

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


        public void ExecuteAWarehouseRequest(WarehouseRequest warehouseRequest)
        {
            WarehouseRequest currentWarehouseRequest = warehouseRequest;
            List<Drone> dronesWithEnoughCarrySpace = DroneList.FindAll(c => c.CurrentCarryWeight > currentWarehouseRequest.Package.Weight);
            if (dronesWithEnoughCarrySpace.Count <= 0) WarehouseRequests.Enqueue(WarehouseRequests.Dequeue());
            else
            {
                Drone drone = FindTheNearestDroneToTheWarehouseFromADroneList(warehouseRequest.Warehouse, dronesWithEnoughCarrySpace);
                drone.AddAnOrderToTheQueue(new Order());
            }

        }

       
        public Drone FindTheNearestDroneToTheWarehouseFromADroneList(Warehouse warehouse, List<Drone> droneList)
        {
            Drone drone = new Drone();
            double shortestDistance = 0;
            foreach (Drone item in DroneList)
            {
                double distance = MathHelper.DistanceBetweenTwoVectors(item.Coordinates, warehouse.Coordinates);
                if(shortestDistance > distance)
                {
                    shortestDistance = distance;
                    drone = item;
                }
            }

            return drone;
        }


        public bool IssueOrderToDrone()
        {
            return true;
        }

        public void Update()
        {
            if (!IsWarehouseRequestsEmpty())
            {
                
            }
        }



        public bool IsWarehouseRequestsEmpty()
        {
            if (WarehouseRequests.Count <= 0) return true;
            else return false;
        }

        public void Log()
        {

        }

    }
}