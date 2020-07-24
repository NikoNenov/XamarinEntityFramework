using Prism.Navigation;

namespace XamarinEntityFramework.ViewModels
{
  public class MainPageViewModel : BaseViewModel
  {
    public MainPageViewModel(INavigationService navigationService)
        : base(navigationService)
    {
      Title = "Main Page";
    }
  }
}
