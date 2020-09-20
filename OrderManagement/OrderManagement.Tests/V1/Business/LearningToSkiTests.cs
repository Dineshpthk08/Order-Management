using NUnit.Framework;
using OrderManagement.Abstraction;
using OrderManagement.Concretion;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Tests.V1.Business
{
    [TestFixture]
    class LearningToSkiTests
    {
        private ILearningToSki _iLearningToSki;

        [Test]
        public void LearningToSki_ShouldProcessLearningToSki_WhenAddFreeFirstAidVideoIsTrue()
        {
            // Arrange
            _iLearningToSki = new LearningToSki();

            //// Act
            var response = _iLearningToSki.AddFreeFirstAidVideo(true);

            //// Assert
            response.Equals("Added a free 'First Aid' video to the packing slip");
        }

        [Test]
        public void LearningToSki_ShouldNotProcessLearningToSki_WhenAddFreeFirstAidVideoIsFalse()
        {
            // Arrange
            _iLearningToSki = new LearningToSki();

            //// Act
            var response = _iLearningToSki.AddFreeFirstAidVideo(true);

            //// Assert
            response.Equals("Adding a free 'First Aid' video to the packing slip failed due to some error, Please try again!");
        }
    }
}
