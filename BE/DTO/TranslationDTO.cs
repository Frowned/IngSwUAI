﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DTO
{
    public class TranslationDTO
    {
        public int LabelId { get; set; }
        public string LabelName { get; set; }
        public int LanguageId { get; set; }
        public string TranslatedText { get; set; }

    }
}
