using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s24698_APBD_cw3
{
    public interface IContainer
    {
        void EmptyLoad();
        void Load(double mass);
    }
}
