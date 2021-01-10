using System;
using SzkolnyProjekt.State.Navigator;

namespace SzkolnyProjekt.ViewModels.Factories
{
    public class ToDoViewModelFactory : IToDoViewModelFactory
    {
        private readonly CreateViewModel<ToDoViewModel> _toDoViewModel;

        public ToDoViewModelFactory(
            CreateViewModel<ToDoViewModel> toDoViewModel)
        {
            _toDoViewModel = toDoViewModel;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch(viewType)
            {
                case ViewType.ToDoStart:
                    return _toDoViewModel();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel", "ViewType");
            }
        }
    }
}
