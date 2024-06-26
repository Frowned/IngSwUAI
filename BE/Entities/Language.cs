﻿using BE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entities
{
    public class Language : BaseEntity
    {
        public Language() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Translation> Translations { get; set; } = new List<Translation>();
    }
}
