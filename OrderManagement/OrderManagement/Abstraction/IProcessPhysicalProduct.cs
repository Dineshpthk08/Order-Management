using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Abstraction
{
    public interface IProcessPhysicalProduct
    {
        string GeneratePackingSlip(bool generatePackingSlip);
    }
}
