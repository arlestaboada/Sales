

namespace Sales.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get; set;
        }
        #endregion
        #region constructor
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
