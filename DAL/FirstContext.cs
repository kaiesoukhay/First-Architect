﻿using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class FirstContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

           


            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=| DataDirectory |\Data\Test.mdf;Integrated Security=True");
        }

        public DbSet<User> Users { get; set; }
        
    }
}
