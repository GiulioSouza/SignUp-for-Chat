using DbConnect.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect
{
    public class ChatContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        { }
    }
}
