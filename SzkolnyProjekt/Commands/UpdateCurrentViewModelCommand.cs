using System;
using System.Windows.Input;
using SzkolnyProjekt.State.Navigator;
using SzkolnyProjekt.ViewModels.Factories;

namespace Company.Helper.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly INavigator _navigator;
        private readonly IToDoViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator, IToDoViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
            }
        }
    }
}
