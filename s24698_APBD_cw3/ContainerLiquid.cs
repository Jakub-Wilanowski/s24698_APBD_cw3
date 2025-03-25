using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s24698_APBD_cw3
{
    internal class ContainerLiquid : Container, IHazardNotifier
    {
        bool IsHazard { get; set; }
        public ContainerLiquid(double loadMass, int height, int depth, double ownMass, double maxLoad, bool isHazard) : base(loadMass, height, depth, ownMass, maxLoad)
        {
            IsHazard = isHazard;
            SerialNumber = "KON-L-" + NumOfContainers;
        }

        public void HazardNotification(string num)
        {
            Console.WriteLine("Hazardous operation detected in containere" + SerialNumber);
        }
        public override void Load(double m)
        {
            if(IsHazard)
            {
                if (LoadMass + m > 0.5*MaxLoad)
                {
                    HazardNotification(SerialNumber);
                }
                else
                {
                    LoadMass += m;
                }
            }
            else {
                if (LoadMass + m > 0.9 * MaxLoad)
                {
                    HazardNotification(SerialNumber);
                }
                else
                {
                    LoadMass += m;
                }
            }
        }


    }
}
