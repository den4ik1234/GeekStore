﻿using GeekStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekStore.Data.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> Categories { get; }
    }
}
