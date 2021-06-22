﻿using Core.DataAccess;
using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntitiyRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
