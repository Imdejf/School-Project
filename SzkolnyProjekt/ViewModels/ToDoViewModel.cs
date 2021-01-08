using System;
using System.Collections.ObjectModel;
using SzkolnyProjekt.Model;

namespace SzkolnyProjekt.ViewModels
{
    public class ToDoViewModel : ViewModelBase
    {
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
    }
}
