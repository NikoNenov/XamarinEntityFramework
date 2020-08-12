//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Cat.cs" company="Curtis Instruments AG">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Blog data model
//  </summary>
// 
//  <date>24-07-2020</date>
//  <author>nenovn</author>
//  --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace XamarinEntityFramework.Models
{
  public class Blog
  {
    [Key]
    public int BlogId { get; set; }
    public string Url { get; set; }
    public int Rating { get; set; }

    public override string ToString()
    {
      return Url;
    }
  }
}
