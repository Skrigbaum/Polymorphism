﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        public Square(int length) : base(length, length)
        {
        }
        public string ToString()
        {
          return "I am a square";
        }
    }
}
