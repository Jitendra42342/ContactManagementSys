using Microsoft.EntityFrameworkCore;
using CMS.BusinessLayer.Models;
using System;

namespace CMS.DataAccess
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
