using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


//works in same application domain (trebuie serialize)

namespace lectia5
{
    [Serializable]
    class AccountIsRestrictedException : Exception
    {
        public AccountIsRestrictedException() : base()
        {
        }
        public AccountIsRestrictedException(string message) : base(message)
        {
        }

        public AccountIsRestrictedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AccountIsRestrictedException(SerializationInfo info, StreamingContext context)
            :base(info,context)
        {
        }
    }
}
