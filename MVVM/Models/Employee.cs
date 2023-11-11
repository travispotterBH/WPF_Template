﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Template.Interface;

namespace WPF_Template.Models
{
    public class Employee: IModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
