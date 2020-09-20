using NUnit.Framework;
using OrderManagement.Abstraction;
using OrderManagement.Concretion;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Tests.V1.Business
{
    [TestFixture]
    class MembershipUpgradeTests
    {
        private IMembershipUpgrade _iMembershipUpgrade;

        [Test]
        public void MembershipUpgrade_MembershipUpgradeSuccess_WhenUpgradeMembershipIsTrue()
        {
            // Arrange
            _iMembershipUpgrade = new MembershipUpgrade();

            //// Act
            var response = _iMembershipUpgrade.UpgradeMembership(true);

            //// Assert
            response.Equals("Upgrade applied");
        }

        [Test]
        public void MembershipUpgrade_MembershipUpgradeFails_WhenUpgradeMembershipIsFalse()
        {
            // Arrange
            _iMembershipUpgrade = new MembershipUpgrade();

            //// Act
            var response = _iMembershipUpgrade.UpgradeMembership(false);

            //// Assert
            response.Equals("Upgrade failed due to an error");
        }
    }
}
