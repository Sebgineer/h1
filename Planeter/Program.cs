using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<planet> planets = new List<planet>();

            planets.Add(new planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88, 47.4, 167, 0, false));
            planets.Add(new planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802, 108.2, 224.7, 35, 464, 0, false));
            planets.Add(new planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24, 149.6, 365.2, 29.8, 15, 1, false));
            planets.Add(new planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687, 24.1, -65, 2, false));
            planets.Add(new planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true));
            planets.Add(new planet("Saturn", 568, 120536, 687, 9, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true));
            planets.Add(new planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, true));
            planets.Add(new planet("Neptune", 102, 49528, 1638, 11, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true));
            planets.Add(new planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false));

            foreach (var item in planets)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Name: {item.PlanetName} | Mass: {item.Mass}kg (1024kg) | Diameter: {item.Diameter}km | Density: {item.Density}kg/m3\nGravity: {item.Gravity}m/s2 | Rotation Period: {item.RotationPeriod}hours | Length of Day: {item.LengthOfDay}Hours | Distance from Sun {item.DistanceFromSun}(106 km)\nOrbital Period: {item.OrbitalPeriod}Days | Orbital Velocity: {item.OrbitalVelocity}km/s | Mean Temperature: {item.MeanTemperature}C | Number of Moons: {item.NumberOfMoons}\nRing System: {item.RingSystem}");
            }

            Console.ReadKey();
        }
    }
}
