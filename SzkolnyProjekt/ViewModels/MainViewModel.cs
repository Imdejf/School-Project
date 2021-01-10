using Company.Helper.Commands;
using MaterialDesignThemes.Wpf;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using SzkolnyProjekt.Commands;
using SzkolnyProjekt.State.Background;
using SzkolnyProjekt.State.Navigator;
using SzkolnyProjekt.ViewModels.Factories;

namespace SzkolnyProjekt.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IToDoViewModelFactory _viewModelFacotry;
        private readonly INavigator _navigator;
        private readonly IBackground _background;

        public ViewModelBase CurrentViewModel => _navigator.CurrentViewModel;
        public string CurrentColor => _background.CurrentColor;

        public ICommand UpdateCurrentViewModelCommand { get; }

        public ICommand UpdateBackgroundColor { get; }
        public MainViewModel(INavigator navigator, IToDoViewModelFactory viewModelFactory,IBackground background)
        {
            _viewModelFacotry = viewModelFactory;
            _navigator = navigator;
            _background = background;
            _background.StateChanged += Background_StateChanged;
            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(navigator, _viewModelFacotry);
            UpdateCurrentViewModelCommand.Execute(ViewType.ToDoStart);
            UpdateBackgroundColor = new BackgroundColorCommand(background);
        }
        private void Background_StateChanged()
        {
            OnPropertyChanged(nameof(CurrentColor));
        }
    }
}
