using NUnit.Framework;
using OrderManagement.Abstraction;
using OrderManagement.Concretion;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Tests.V1.Business
{
    [TestFixture]
    class ProcessMembershipTests
    {
        private IProcessMembership _iProcessMembership;

        [Test]
        public void ProcessMembership_ShouldProcessMembership_WhenActivateMembershipIsTrue()
        {
            // Arrange
            _iProcessMembership = new ProcessMembership();

            //// Act
            var response = _iProcessMembership.ActivateMembership(true);

            //// Assert
            response.Equals("Membership activated");
        }

        [Test]
        public void ProcessMembership_ShouldNotProcessMembership_WhenActivateMembershipIsFalse()
        {
            // Arrange
            _iProcessMembership = new ProcessMembership();

            //// Act
            var response = _iProcessMembership.ActivateMembership(true);

            //// Assert
            response.Equals("Membership activation failed due to an error");
        }

    }
}
