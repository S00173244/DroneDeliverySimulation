using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicVector;
namespace DroneDeliverySimulation.Classes
{
    public static class MathHelper
    {
        public static double DistanceBetweenTwoVectors(Vector a, Vector b)
        {
            return Math.Pow(b.X - a.X,2) + Math.Pow(b.Y - a.Y, 2);
        }

    }
}
