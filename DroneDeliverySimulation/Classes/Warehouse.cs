using System;
using System.Collections.Generic;
using System.Numerics;
using Microsoft;
using BasicVector;
namespace DroneDeliverySimulation
{


    public class Warehouse : IDroneDeliverySimulationComponent
    {
        
        private List<Package> packageList;
        private ControlCenter controlcenter;
        private Vector coordinates;
        public Warehouse()
        {
           
        }


        #region Accessors
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

        public ControlCenter Controlcenter
        {
            get
            {
                return controlcenter;
            }

            set
            {
                controlcenter = value;
            }
        }

        #endregion
        

        public void Update()
        {

        }

        public void LoadPackageOnTheDrone(Drone drone)
        {

        }

        public void Log()
        {

        }
    }

}