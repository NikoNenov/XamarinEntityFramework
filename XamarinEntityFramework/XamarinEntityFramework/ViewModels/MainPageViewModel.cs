//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Cat.cs" company="Curtis Instruments AG">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Main page view model 
//  </summary>
// 
//  <date>24-07-2020</date>
//  <author>nenovn</author>
//  --------------------------------------------------------------------------------------------------------------------
using Prism.Commands;
using Prism.Navigation;

namespace XamarinEntityFramework.ViewModels
{
  public class MainPageViewModel : BaseViewModel
  {

    /// <summary>
    /// Display all blog entries command
    /// </summary>
    public DelegateCommand ShowBlogEntriesCommand { get; }

    public MainPageViewModel(INavigationService navigationService) : base(navigationService)
    {
      Title = "Xamarin & Entity Framework";

      ShowBlogEntriesCommand = new DelegateCommand(ShowBlogEntries);
    }

    /// <summary>
    /// Show blog entries
    /// </summary>
    private void ShowBlogEntries()
    {
      // TODO
    }
  }
}
