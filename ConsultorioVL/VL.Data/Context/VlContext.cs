using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VL.Core.Domain;

namespace VL.Data.Context
{
    public class VlContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public VlContext(DbContextOptions options) : base(options)
        {

        }
    }
}
