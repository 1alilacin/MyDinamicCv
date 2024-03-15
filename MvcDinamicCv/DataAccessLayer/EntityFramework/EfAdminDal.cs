﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
        public EfAdminDal(Context context) : base(context)
        {
        }
    }
}