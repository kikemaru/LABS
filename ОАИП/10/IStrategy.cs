﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viborSortQuickSort
{
    public interface IStrategy
    {
        int[] Algorithm(int[] mas, bool flag = true);
    }
}
