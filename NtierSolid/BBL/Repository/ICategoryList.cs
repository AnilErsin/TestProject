﻿using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Repository
{
    public interface ICategoryList
    {
        List<Category> GetListCategory();
    }
}
