using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7
{
    class Shape
    {
        public override string ToString()
        {
            return $"I am a {this.GetType().Name}";

        }
    }
}