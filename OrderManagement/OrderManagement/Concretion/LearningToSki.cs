using OrderManagement.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Concretion
{
    public class LearningToSki : ILearningToSki
    {
        public string AddFreeFirstAidVideo(bool addFreeFirstAidVideo)
        {
            if (addFreeFirstAidVideo)
            {
                return "Added a free 'First Aid' video to the packing slip"; 
            } else
            {
                return "Adding a free 'First Aid' video to the packing slip failed due to some error, Please try again!";
            }
        }
    }
}
