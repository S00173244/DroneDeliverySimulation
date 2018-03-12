using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDeliverySimulation
{
    public class WarehouseRequest
    {
        private Warehouse warehouse;
        private Package package;

        public Warehouse Warehouse
        {
            get
            {
                return warehouse;
            }

            set
            {
                warehouse = value;
            }
        }

        public Package Package
        {
            get
            {
                return package;
            }

            set
            {
                package = value;
            }
        }

        public void CreateARequestForPackageDelivery(Warehouse warehouse, Package package)
        {          
            Warehouse = warehouse;
            Package = package;           
            
        }

    }
}
