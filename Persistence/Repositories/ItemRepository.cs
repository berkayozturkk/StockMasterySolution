﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;

public class ItemRepository : EfRepositoryBase<BaseDbContext>
{
    public ItemRepository(BaseDbContext context) : base(context)
    {

    }

    
}
