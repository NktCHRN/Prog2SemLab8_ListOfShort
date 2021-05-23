using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfShortLib
{
    public class Node
    {
        public short Number { get; internal set; }  // short number
        internal Node Next { get; set; }            // next node
    }
}
