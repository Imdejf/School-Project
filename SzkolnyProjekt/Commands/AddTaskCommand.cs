using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using SzkolnyProjekt.Model;
using SzkolnyProjekt.ViewModels;

namespace SzkolnyProjekt.Commands
{
    public class AddTaskCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly ToDoViewModel _toDoViewModel;
        public AddTaskCommand(ToDoViewModel toDoViewModel)
        {
            _toDoViewModel = toDoViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        { 
            try
            {
                string task = _toDoViewModel.Task;
                DateTime dateCreated = _toDoViewModel.DateCreated = DateTime.Now;
                if (task != null)
                {
                    if (task.Length > 6)
                    {
                        var toDo = new ToDoModel()
                        {
                            IsSelected = false,
                            Task = task,
                            DateCreated = dateCreated
                        };
                        _toDoViewModel.ToDoList.Add(toDo);
                    }
                    else { MessageBox.Show("Minimum 6 znaków"); }
                }
                else
                {
                    MessageBox.Show("Nie podałeś zadania");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
