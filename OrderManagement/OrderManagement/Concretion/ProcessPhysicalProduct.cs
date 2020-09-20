using OrderManagement.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Concretion
{
    public class ProcessPhysicalProduct : IProcessPhysicalProduct
    {
        public string GeneratePackingSlip(bool generatePackingSlip)
        {
            if (generatePackingSlip)
            {
                return "Generated a packing slip for shipping";
            } else
            {
                return "Packing slip for shipping is not generated due to some error";
            }
            
            // Generate packing slip logic goes here.
        }
    }
}
