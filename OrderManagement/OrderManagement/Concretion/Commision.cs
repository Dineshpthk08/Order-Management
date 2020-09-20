using OrderManagement.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Concretion
{
    public class Commision : ICommision
    {
        public string CommisionPayment()
        {
            return "Commision payment to Agent Initiated";
            // Commision logic goes here!
        }
    }
}
