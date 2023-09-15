﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClassLibrary.Connection.ConnectionModel;

namespace WebApiClassLibrary
{
        public class Context : DbContext
        {
            public Context(DbContextOptions options) : base(options)
            {


            }
            public DbSet<FoodModels> FoodModels
            {
                get;
                set;
            }
        }
}
