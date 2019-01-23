



namespace Sales.ViewModels

{
    using System.ComponentModel;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;
    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Attributes
        private string password;
        private bool isRunning;
        private bool isEnable;
        #endregion

        #region Properties
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get {
                return this.password;
            }
            set {
                if (this.password != value)
                {
                    this.password = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.Password))
                        );
                }
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
                if (this.isRunning != value)
                {
                    this.isRunning = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.IsRunning))
                        );
                }

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
                if (this.isEnable != value)
                {
                    this.isEnable = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.IsEnabled))
                        );
                }
            }

            }
        #endregion

            #region constructors
        public LoginViewModel()
        {
            this.IsRemenbered = true;
            this.IsEnabled = true;


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
            await Application.Current.MainPage.DisplayAlert(
                                "OK",
                                "yaaaaay",
                                "Accept");
        




        }
        #endregion
    }
}

