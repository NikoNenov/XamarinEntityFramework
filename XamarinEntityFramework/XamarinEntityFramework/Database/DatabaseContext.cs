//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Cat.cs" company="Curtis Instruments AG">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Database context
//  </summary>
// 
//  <date>24-07-2020</date>
//  <author>nenovn</author>
//  --------------------------------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using XamarinEntityFramework.Models;

namespace XamarinEntityFramework.Database
{
  public class DatabaseContext : DbContext
  {
    private readonly string _databasePath;

    public DbSet<Cat> Cats { get; set; }

    public DbSet<Blog> Blogs { get; set; }

    /// <summary>
    /// Database context constructor
    /// </summary>
    /// <param name="databasePath"></param>
    public DatabaseContext(string databasePath)
    {
      _databasePath = databasePath;
    }

    /// <summary>
    /// Configuring event
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite($"Filename={_databasePath}");
    }

  }
}
