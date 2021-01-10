using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SzkolnyProjekt.Commands;
using SzkolnyProjekt.Model;

namespace SzkolnyProjekt.ViewModels
{
    public class ToDoViewModel : ViewModelBase
    {
        #region ObservableCollection
        private ObservableCollection<ToDoModel> _toDoList = new ObservableCollection<ToDoModel>();
        public ObservableCollection<ToDoModel> ToDoList
        {
            get
            {
                return _toDoList;
            }
            set
            {
                _toDoList = value;
                OnPropertyChanged(nameof(ToDoList));
            }
        }
        #endregion
        #region Properties
        private string _task;
        public string Task
        {
            get
            {
                return _task;
            }
            set
            {
                _task = value;
                OnPropertyChanged(nameof(Task));
            }
        }
        private DateTime _dateCreated;
        public DateTime DateCreated
        {
            get
            {
                return _dateCreated;
            }
            set
            {
                _dateCreated = value;
                OnPropertyChanged(nameof(DateCreated));
            }
        }
        #endregion
        #region Command
        public ICommand AddTaskCommand { get; set; }
        public ICommand DeleteTaskCommand { get; set; }
        public ICommand EditTaskCommand { get; set; }
        #endregion
        public ToDoViewModel()
        {
            AddTaskCommand = new AddTaskCommand(this);
            DeleteTaskCommand = new DeleteTaskCommand(this);
            EditTaskCommand = new EditTaskCommand(this);
        }
    }
}
