﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPointsBankServices.Models
{
    public class AdminInfo
    {
        public string AdminFName { get; set; }
        public string AdminLName { get; set; }
        public string AdminEmail { get; set; }

       // public static    
    }

    public class AdminSignIn
    {
        public string AdminEmail { get; set; }
        public string AdminToken { get; set; }
    }
}
