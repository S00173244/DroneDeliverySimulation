using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDeliverySimulation
{
    public class Package
    {
        private Recipient recipient;
        private int weight;

        #region Accessors
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public Recipient Recipient
        {
            get
            {
                return recipient;
            }

            set
            {
                recipient = value;
            }
        }

        #endregion

        public Package(Recipient recipient, int weight)
        {
            this.Recipient = recipient;
            this.Weight = weight;
        }
    }
}
