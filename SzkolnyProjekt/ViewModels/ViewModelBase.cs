using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SzkolnyProjekt.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyString)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyString));
        }
    }
}
