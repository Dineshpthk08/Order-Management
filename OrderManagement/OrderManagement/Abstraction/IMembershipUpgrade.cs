﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Abstraction
{
    public interface IMembershipUpgrade
    {
        string UpgradeMembership(bool upgradeMembership);
    }
}
