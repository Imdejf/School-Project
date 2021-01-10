using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using SzkolnyProjekt.Model;
using SzkolnyProjekt.ViewModels;

namespace SzkolnyProjekt.Commands
{
    public class EditTaskCommand : ICommand
    {
        private readonly ToDoViewModel _toDoViewModel;
        public EditTaskCommand(ToDoViewModel toDoViewModel)
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
            var itemSeleted = _toDoViewModel.ToDoList.Where(s => s.IsSelected).ToList();
            if(itemSeleted.Count == 1)
            {
                var item = _toDoViewModel.ToDoList.FirstOrDefault(s => s.IsSelected);
                _toDoViewModel.ToDoList.Remove(item);
                var newTask = new ToDoModel()
                {
                    IsSelected = false,
                    Task = _toDoViewModel.Task,
                };
                _toDoViewModel.ToDoList.Add(newTask);
            }
            else
            {
                MessageBox.Show("Musi być zaznaczone jedno zadanie");
            }
        }
    }
}
