using OrderManagement.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Concretion
{
    public class ProcessBook : IProcessBook
    {
        public string CreateDuplicatePackingSlip(bool createDuplicatePackingSlip)
        {
            if (createDuplicatePackingSlip)
            {
                return "Created a duplicate packing slip for the royality department";
            } else
            {
                return "Duplicate packing slip for the royality department failed due to an error";
            }
        }
    }
}
