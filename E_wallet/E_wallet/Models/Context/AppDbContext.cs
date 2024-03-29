﻿using Microsoft.EntityFrameworkCore;

namespace E_wallet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<Passbook> Passbook { get; set; }
    }
}