﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ButtonState.Models
{
    public class ButtonModel
    {
        public int State { get; set; }

        public ButtonModel(int state)
        {
            State = state;
        }
    }
}