﻿using Netflix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Entities
{
    public class Category :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
