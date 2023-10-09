using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;

public class EfRepositoryBase<TContext> 
{
    protected readonly TContext _context;

    public EfRepositoryBase(TContext context) 
    {
        _context = context;
    }
}
