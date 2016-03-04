﻿using System.Data.Entity;

namespace MyBooksAPI.Models
{
    public class MyBooksApiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyBooksApiContext() : base("name=MyBooksAPIContext")
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    
    }
}
