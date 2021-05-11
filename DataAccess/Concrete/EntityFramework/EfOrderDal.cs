﻿using Core.DataAccess;
using Core.DataAccess.EntitiyFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal: EfEntitiyRepositoryBase<Order, NorthwindContext>,IOrderDal
    {
    }
}
