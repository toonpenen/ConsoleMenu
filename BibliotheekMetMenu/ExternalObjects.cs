using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuPresentation
{
    class ExternalObject 
    {
        public int SomeInt { get; set; }
        public string SomeString { get; set; }

        public override string ToString()
        {
            return $"External Object desc.:\nActual int value: {SomeInt}\nActual string value: {SomeString}";
        }
    }
}

