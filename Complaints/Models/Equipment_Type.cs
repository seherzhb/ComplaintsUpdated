﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Complaints.Models
{
    public class  Equipment_Type
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public bool Active;
    }
}