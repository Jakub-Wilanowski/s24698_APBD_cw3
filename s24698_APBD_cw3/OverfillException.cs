using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace s24698_APBD_cw3
{
    internal class OverfillException : Exception
    {
        public OverfillException()
        {
        }

        public OverfillException(string? message) : base(message)
        {
        }

        protected OverfillException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
