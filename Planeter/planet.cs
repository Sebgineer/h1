using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter
{
    class planet
    {
        private string planetName;
        private double mass, diameter, density, gravity, rotationPeriod, lengthOfDay, orbitalPeriod, distanceFromSun, orbitalVelocity, meanTemperature, numberOfMoons = 0;
        private bool ringSystem = false;
        public string PlanetName { get => planetName; set => planetName = value; }
        public double Mass { get => mass; set => mass = value; }
        public double Diameter { get => diameter; set => diameter = value; }
        public double Density { get => density; set => density = value; }
        public double Gravity { get => gravity; set => gravity = value; }
        public double RotationPeriod { get => rotationPeriod; set => rotationPeriod = value; }
        public double LengthOfDay { get => lengthOfDay; set => lengthOfDay = value; }
        public double OrbitalPeriod { get => orbitalPeriod; set => orbitalPeriod = value; }
        public double DistanceFromSun { get => distanceFromSun; set => distanceFromSun = value; }
        public double OrbitalVelocity { get => orbitalVelocity; set => orbitalVelocity = value; }
        public double MeanTemperature { get => meanTemperature; set => meanTemperature = value; }
        public double NumberOfMoons { get => numberOfMoons; set => numberOfMoons = value; }
        public bool RingSystem { get => ringSystem; set => ringSystem = value; }

        public planet(string name, double mass, double diameter, double density, double gravity, double rotationPeriod, double lengthOfDay, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, double meanTemperature, double numberOfMoons, bool ringSystem)
        {
            this.PlanetName = name;
            this.Mass = mass;
            this.Diameter = diameter;
            this.density = density;
            this.Gravity = gravity;
            this.RotationPeriod = rotationPeriod;
            this.LengthOfDay = lengthOfDay;
            this.DistanceFromSun = distanceFromSun;
            this.OrbitalPeriod = orbitalPeriod;
            this.OrbitalVelocity = orbitalVelocity;
            this.MeanTemperature = meanTemperature;
            this.NumberOfMoons = numberOfMoons;
            this.RingSystem = ringSystem;
        }

    }
}
