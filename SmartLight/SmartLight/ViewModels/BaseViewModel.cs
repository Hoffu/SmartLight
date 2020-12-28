using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using SmartLight.Models;
using SmartLight.Services;

namespace SmartLight.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        string mainBackgroundImage = "active.png";
        public string MainBackgroundImage
        {
            get { return mainBackgroundImage; }
            set { SetProperty(ref mainBackgroundImage, value); }
        }

        private bool _isVisible = true;        
        public bool IsVisible
        {
            get { return _isVisible; }
            set { SetProperty(ref _isVisible, value); }
        }

        public void changeVisibleState()
        {
            Console.WriteLine(IsVisible);
            if (IsVisible) { IsVisible = false; }
            else { IsVisible = true; }
            Console.WriteLine(IsVisible);
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
