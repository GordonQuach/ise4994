﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotArmClient
{
    /// <summary>
    /// possible units used by the system. only inches and millimeters are possible.
    /// </summary>
    public enum unit
    {
        inches, millimeters
    }

    /// <summary>
    /// possible frames of reference used by the system are kept here.
    /// only absolute and incremental are possible.
    /// </summary>
    public enum reference
    {
        absolute = 10, incremental
    }


}
