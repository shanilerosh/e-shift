﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.utility
{
    internal class ComboBoxItem
    {
        public string? Text { get; set; }
        public string? Value { get; set; }

        public override string? ToString()
        {
            return Text;
        }
    }
}
