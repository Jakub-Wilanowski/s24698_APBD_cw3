using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s24698_APBD_cw3
{


    public class Container : IContainer
    {
        public double LoadMass { get; set; }
        public int Height { get; set; }
        public double OwnMass { get; set; }
        public int Depth { get; set; }
        public string SerialNumber { get; set; }
        public double MaxLoad { get; set; }
        public static int NumOfContainers = 0;


        public virtual void EmptyLoad()
        {
            LoadMass = 0; 
        }

        public Container(double loadMass, int height, int depth, double ownMass, double maxLoad) {
            LoadMass = loadMass;
            Height = height;
            OwnMass = ownMass;
            Depth = depth;
            MaxLoad = maxLoad;
            SerialNumber = "KON-N-" + NumOfContainers;
            NumOfContainers++;
        }

        public virtual void Load(double m)
        {
            if(m + LoadMass > MaxLoad)
            {
                throw new OverfillException();
            }
            else { LoadMass += m; }
        }
    }
}
