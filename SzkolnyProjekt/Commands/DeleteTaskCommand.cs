using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using SzkolnyProjekt.ViewModels;

namespace SzkolnyProjekt.Commands
{
    public class DeleteTaskCommand : ICommand
    {
        private readonly ToDoViewModel _toDoViewModel;
        public DeleteTaskCommand(ToDoViewModel toDoViewModel)
        {
            _toDoViewModel = toDoViewModel;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var taskList = _toDoViewModel.ToDoList.Where(s => s.IsSelected).ToList();
            if(taskList.Count > 0)
            {
                foreach (var task in taskList)
                {
                    _toDoViewModel.ToDoList.Remove(task);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz przynajmniej jedno zadanie");
            }
        }
    }
}
