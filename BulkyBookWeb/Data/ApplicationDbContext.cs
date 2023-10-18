using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // We need to create Category Table inside Database
        // whatever model you want to create in database
        // you need to create a DbSet here
        // Table Name = Categories
        // There are two models, 1- code first 2- detabase first
        // here we are using code first because we are writting the code of our model
        // and base of that model, we are creting database
        // but in database first, database is already creeated 
        // and base on that you will scaffolding models
        public DbSet<Category> Categories { get; set; }

        // for exceuting the changes in database and table, you need to add a migration
        // type the following in Package manager Console:
        // add-migration "name"
        // Once you verfied the migration looks good, you can use:
        // update-database to push migration to the  database

    }
}
