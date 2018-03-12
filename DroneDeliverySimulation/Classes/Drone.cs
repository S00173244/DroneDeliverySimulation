using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicVector;
namespace DroneDeliverySimulation
{
    public class Drone : IDroneDeliverySimulationComponent
    {
        private Vector coordinates;
        private int maxCarryWeight;
        private int currentCarryWeight;
        private Queue<Order> allOrders;
        private List<Package> packageList;

        public Vector Coordinates
        {
            get
            {
                return coordinates;
            }

            set
            {
                coordinates = value;
            }
        }

        public int MaxCarryWeight
        {
            get
            {
                return maxCarryWeight;
            }

            set
            {
                maxCarryWeight = value;
            }
        }

        public int CurrentCarryWeight
        {
            get
            {
                return currentCarryWeight;
            }

            set
            {
                currentCarryWeight = value;
            }
        }

        public Queue<Order> AllOrders
        {
            get
            {
                return allOrders;
            }

            set
            {
                allOrders = value;
            }
        }

        public List<Package> PackageList
        {
            get
            {
                return packageList;
            }

            set
            {
                packageList = value;
            }
        }

        public void AddAnOrderToTheQueue(Order order)
        {
            AllOrders.Enqueue(order);
        }

        public void Log()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
