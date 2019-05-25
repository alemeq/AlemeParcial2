using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Services;
    using Xamarin.Forms;
    using global::App.Models;

    using Views;
    class LoginViewModel : BaseViewModel
    {

        #region variables
        string content;
        bool isrunning;
        bool isenabled;

        #endregion

        #region propiedades
        public string Content
        {
            get { return this.content; }
            set { SetValue(ref this.content, value); }
        }
        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }
        public bool IsEnabled
        {
            get { return this.isenabled; }
            set { SetValue(ref this.isenabled, value); }
        }
        #endregion

        #region comandos
        public ICommand LoginCommand

        {
            get
            {
                return new RelayCommand(cmdLogin);
            }
        }

        private async void cmdLogin()

        {

            if (String.IsNullOrEmpty(content))
            {
                await App.Current.MainPage.DisplayAlert("note content",
                                "Please enter your content",
                                "Accept");
                return;
            }
            IsRunning = true;
            IsEnabled = false;

            
            #endregion


        }
    }
}
