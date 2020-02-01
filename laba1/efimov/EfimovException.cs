using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efimov
{
    class EfimovException : Exception
    {
        public EfimovException(string message)
            : base(message)
        {
        }
    }
}
