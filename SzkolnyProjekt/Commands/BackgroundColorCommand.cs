using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using SzkolnyProjekt.State.Background;
using SzkolnyProjekt.ViewModels;

namespace SzkolnyProjekt.Commands
{
    public class BackgroundColorCommand : ICommand
    {
        private readonly IBackground _background;
        public BackgroundColorCommand(IBackground background)
        {
            _background = background;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            switch(parameter)
            {
                case "1":
                    _background.CurrentColor = "Blue";
                    break;
                case "2":
                    _background.CurrentColor = "Orange";
                    break;
                case "3":
                    _background.CurrentColor = "Violet";
                    break;
            }

        }
    }
}
