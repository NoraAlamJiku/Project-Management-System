﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagementApp.Models
{
    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Tasks> Taskss { get; set; }
    }
}