using System;
using System.Collections.Generic;
using System.Text;

using Crainiate.Diagramming;

namespace Crainiate.Diagramming.Testing.Units
{
    internal class SubElement: Element 
    {
        private string _testString;
        private int _testInt;

        public SubElement()
        {

        }

        public string TestString
        {
            get { return _testString; }
            set { _testString = value; }
        }

        public int TestInt
        {
            get { return _testInt; }
            set { _testInt = value; }
        }

    }
}
