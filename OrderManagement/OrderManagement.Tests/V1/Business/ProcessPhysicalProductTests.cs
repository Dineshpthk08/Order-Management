using NUnit.Framework;
using OrderManagement.Abstraction;
using OrderManagement.Concretion;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Tests.V1.Business
{
    [TestFixture]
    public class ProcessPhysicalProductTests
    {

        private IProcessPhysicalProduct _iProcessPhysicalProduct;

        [Test]
        public void PhysicalProduct_ShouldReturnSuccess_WhenGeneratePackingSlipIsTrue()
        {
            // Arrange
            _iProcessPhysicalProduct = new ProcessPhysicalProduct();

            //// Act
            var response = _iProcessPhysicalProduct.GeneratePackingSlip(true);

            //// Assert
            response.Equals("Generated a packing slip for shipping");
        }

        [Test]
        public void PhysicalProduct_ShouldReturnFailure_WhenGeneratePackingSlipIsFalse()
        {
            // Arrange
            _iProcessPhysicalProduct = new ProcessPhysicalProduct();

            //// Act
            var response = _iProcessPhysicalProduct.GeneratePackingSlip(false);

            //// Assert
            response.Equals("Packing slip for shipping is not generated due to some error");
        }
    }
}
