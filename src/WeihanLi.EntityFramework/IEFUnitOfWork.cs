﻿using Microsoft.EntityFrameworkCore;
using WeihanLi.Common.Data;

namespace WeihanLi.EntityFramework
{
    public interface IEFUnitOfWork<out TDbContext> : IUnitOfWork where TDbContext : DbContext
    {
        TDbContext DbContext { get; }
    }
}
