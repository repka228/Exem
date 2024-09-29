using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exem
{
    public interface INterfaceTask3
    {
        public string Task1();
        public string Task1(int target);
        int this[int ind] { get; }
        public string Name { get; }
    }
}
