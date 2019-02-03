﻿



namespace Sales.ViewModels
{
    using System.Collections.Generic;
    using Sales.Models;
    public class MainViewModel
    {
        
      

        #region Properties
        public List<Land> LandsList
        {
            get;
            set;
        }

        #endregion
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public LandsViewModel Lands
        {
            get;
            set;
        }
        public LandViewModel Land
        {
            get;
            set;
        }
        #endregion
        #region constructor
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion
        #region singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
