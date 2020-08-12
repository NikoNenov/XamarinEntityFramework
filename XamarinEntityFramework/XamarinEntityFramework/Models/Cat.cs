//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Cat.cs" company="Curtis Instruments AG">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Cat data model
//  </summary>
// 
//  <date>24-07-2020</date>
//  <author>nenovn</author>
//  --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace XamarinEntityFramework.Models
{
  public class Cat
  {
    [Key] public int CatId { get; set; }

    public string Name { get; set; }

    public int MeowsPerSecond { get; set; }
  }
}