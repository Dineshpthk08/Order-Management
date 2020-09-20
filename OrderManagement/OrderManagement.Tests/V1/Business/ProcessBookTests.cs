using NUnit.Framework;
using OrderManagement.Abstraction;
using OrderManagement.Concretion;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Tests.V1.Business
{
    [TestFixture]
    public class ProcessBookTests
    {
        private IProcessBook _iProcessBook;

        [Test]
        public void ProcessBook_ShouldProcessBook_WhenCreateDuplicatePackingSlipIsTrue()
        {
            // Arrange
            _iProcessBook = new ProcessBook();

            //// Act
            var response = _iProcessBook.CreateDuplicatePackingSlip(true);

            //// Assert
            response.Equals("Created a duplicate packing slip for the royality department");
        }

        [Test]
        public void ProcessBook_ShouldNotProcessBook_WhenCreateDuplicatePackingSlipIsFalse()
        {
            // Arrange
            _iProcessBook = new ProcessBook();

            //// Act
            var response = _iProcessBook.CreateDuplicatePackingSlip(false);

            //// Assert
            response.Equals("Duplicate packing slip for the royality department failed due to an error");
        }
    }
}
