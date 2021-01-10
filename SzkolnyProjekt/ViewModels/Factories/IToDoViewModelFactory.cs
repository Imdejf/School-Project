using SzkolnyProjekt.State.Navigator;

namespace SzkolnyProjekt.ViewModels.Factories
{
    public interface IToDoViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
