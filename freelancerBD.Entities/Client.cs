﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    public class Client
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime JoiningDate { get; set; }
        public double Balance { get; set; }
        public string Address { get; set; }
        public string Region { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }

    }
}
