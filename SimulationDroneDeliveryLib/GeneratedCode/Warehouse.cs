﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Warehouse : DroneDeliverySimulationComponent
{
	public virtual List<Package> PackageList
	{
		get;
		set;
	}

	public virtual Vector Coordinate
	{
		get;
		set;
	}

	public virtual string ID
	{
		get;
		set;
	}

	public virtual void LoadPackageOnTheDrone(Drone drone)
	{
		throw new System.NotImplementedException();
	}

	public virtual void Log()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Update()
	{
		throw new System.NotImplementedException();
	}

	public virtual void CreatePackages()
	{
		throw new System.NotImplementedException();
	}

}

