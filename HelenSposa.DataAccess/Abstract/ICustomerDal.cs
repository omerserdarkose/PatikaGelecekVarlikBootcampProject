﻿using HelenSposa.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelenSposa.DataAccess.Abstract
{
    interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
