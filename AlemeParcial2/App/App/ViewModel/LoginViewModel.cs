using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.ViewModel
{
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
            get { return new RelayCommand(cmdRegister); }
        }
        private async void cmdRegister()
        {
            if (String.IsNullOrEmpty(Content))
            {
                await App.Current.MainPage.DisplayAlert("Register empty", "Please input register", "Accept");
                return;
            }
            IsRunning = true;
        }
        #endregion

    }
}
