﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARTJ.Apresentacao.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime data = DateTime.Now;
        public string Role { get; set; } //Pode ter multiplos roles 
    }
}
