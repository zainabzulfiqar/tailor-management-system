﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Common
{
    public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Contact { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }          
    }
}
