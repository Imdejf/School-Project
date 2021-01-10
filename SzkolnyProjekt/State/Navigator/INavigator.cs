using System;
using SzkolnyProjekt.ViewModels;

namespace SzkolnyProjekt.State.Navigator
{
    public enum ViewType
    {
        ToDoStart,
    }
    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
