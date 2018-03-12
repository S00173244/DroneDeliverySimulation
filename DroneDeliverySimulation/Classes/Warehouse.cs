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
        private List<Package> packagesAwaitingForDronePickup;
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

        public List<Package> PackagesAwaitingForDronePickup
        {
            get
            {
                return packagesAwaitingForDronePickup;
            }

            set
            {
                packagesAwaitingForDronePickup = value;
            }
        }

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

        #endregion


        public void Update()
        {
            if (!IsPackageListEmpty())
            {
                SendARequestToControlCenterForPackageDelivery();
            }
        }

        public void SendARequestToControlCenterForPackageDelivery()
        {
            WarehouseRequest wr = new WarehouseRequest();
            wr.CreateARequestForPackageDelivery(this, packageList[0]);
            Controlcenter.AddAWarehouseRequestToTheList(wr);
            PackagesAwaitingForDronePickup.Add(packageList[0]);
            PackageList.Remove(packageList[0]);
        }

        public bool IsPackageListEmpty()
        {
            if (packageList.Count <= 0) return true;
            else return true;
        }

        public void LoadPackageOnTheDrone(Drone drone)
        {

        }

        public void Log()
        {

        }
    }

}