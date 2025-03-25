using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s24698_APBD_cw3
{
    public class Ship
    {
        public List<Container> Containers { get; set; }
        public double MaxSpeed { get; set; }
        public int MaxWeight { get; set; }
        
        public int MaxContainerNum { get; set; }
        public Ship(double maxSpeed, int maxWeight, int maxContainerNum) {
            MaxSpeed = maxSpeed;
            MaxWeight = maxWeight;
            MaxContainerNum = maxContainerNum;
        }


    }
}
