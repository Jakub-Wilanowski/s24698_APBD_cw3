using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s24698_APBD_cw3
{
    internal class ContainerGas : Container, IHazardNotifier
    {
        public ContainerGas(double loadMass, int height, int depth, double ownMass, double maxLoad) : base(loadMass, height, depth, ownMass, maxLoad)
        {
        }

        public void HazardNotification()
        {
            throw new NotImplementedException();
        }
    }
}
