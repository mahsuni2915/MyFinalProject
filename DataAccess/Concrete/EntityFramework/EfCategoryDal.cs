﻿using Core.DataAccess.EntitiyFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntitiyRepositoryBase<Category, NorthwindContext>,ICategoryDal
    {

    }
   
    
}
