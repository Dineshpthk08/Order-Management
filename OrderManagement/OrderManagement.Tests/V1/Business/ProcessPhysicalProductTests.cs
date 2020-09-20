using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Tests.V1.Business
{
    [TestFixture]
    public class ProcessPhysicalProductTests
    {
        //private IProcessPhysicalProduct iProcessPhysicalProduct;

        [Test]
        [TestCase(true, ExpectedResult = "Generated a packing slip for shipping")]
        [TestCase(false, ExpectedResult = "Packing slip for shipping is not generated due to some error")]
        public string PhysicalProduct_ShouldReturnSuccess_WhenGeneratePackingSlipIsTrue(bool generatePackingSlip)
        {
            //// Arrange/Act
            //_basicDataFixture = new BasicDataFixture();
            //_testServer = new TestServerFixture(BuildTestRegistryForSuccess());

            //var response = _testServer.Client.GetAsync(string.Format("/primefactor?number={0}", number)).Result;
            //var body = response.Content.ReadAsStringAsync().Result;

            //// Assert
            //response.StatusCode.Should().Be(HttpStatusCode.OK);

            //_basicDataFixture.Dispose();
            //_testServer.Dispose();            //// Arrange/Act
            //_basicDataFixture = new BasicDataFixture();
            //_testServer = new TestServerFixture(BuildTestRegistryForSuccess());

            //var response = _testServer.Client.GetAsync(string.Format("/primefactor?number={0}", number)).Result;
            //var body = response.Content.ReadAsStringAsync().Result;

            //// Assert
            //response.StatusCode.Should().Be(HttpStatusCode.OK);

            //_basicDataFixture.Dispose();
            //_testServer.Dispose();

            return body;
        }
    }
}
