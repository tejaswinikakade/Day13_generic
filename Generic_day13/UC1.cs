﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_day13
{
    class UC1
    {
        public static int Maxint(int First, int second, int third)
        {
            if (First.CompareTo(second) > 0 && First.CompareTo(third) > 0)
            {
                return First;

            }

            if (second.CompareTo(First) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }

            if (third.CompareTo(second) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }

            throw new Exception("First Number , Second Number , Third Number are Same");
        }

    }
}
