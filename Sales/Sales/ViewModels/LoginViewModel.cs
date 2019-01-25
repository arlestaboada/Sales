



namespace Sales.ViewModels

{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Sales.Views;
    using Xamarin.Forms;
    public class LoginViewModel :BaseViewModel
    {

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnable;
        #endregion

        #region Properties
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                SetValue(ref this.email, value);
            }
        }
        public string Password
        {
            get {
                return this.password;
            }
            set {
                SetValue(ref this.password, value);
            }
        }
        public bool IsRunning
        {
            get
            {
                return this.isRunning;
            }
            set
            {
                SetValue(ref this.isRunning, value);
            }
        }
        public bool IsRemenbered
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get
            {
                return this.isEnable;
            }
            set
            {
                SetValue(ref this.isEnable, value);
            }

        }
        #endregion

            #region constructors
        public LoginViewModel()
        {
            this.IsRemenbered = true;
            this.IsEnabled = true;
            this.Email = "arles@gmail.com";
            this.Password = "1234";


        }
        #endregion
        #region command


        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }


        }



        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an Password",
                    "Accept");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "arles@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect",
                    "Accept");
                this.Password = string.Empty;

                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;
            this.Email = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());


        }
        #endregion
    }
}

