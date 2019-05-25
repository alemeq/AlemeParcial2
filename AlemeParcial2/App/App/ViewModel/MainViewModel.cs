using System;
using System.Collections.Generic;
using System.Text;

namespace App.ViewModel
{
    class MainViewModel
    {
        #region Properties

        public string Token { get; set; }

        public string TokenType { get; set; }

        #endregion

        #region ViewModels
        public LoginViewModel Register { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Register = new LoginViewModel();
        }
        #endregion

        #region Singleton
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

