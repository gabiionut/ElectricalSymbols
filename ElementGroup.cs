using System.Collections.Generic;

namespace ElectricalSymbols
{
    public class ElementGroup : List<Element>
    {
        public string Family { get; set; }

        public ElementGroup(string family)
        {
            Family = family;
        }
    }
}