using System;
using System.Collections.Generic;
using System.Text;

namespace SzkolnyProjekt.State.Background
{
    public class Background : IBackground
    {
        private string _currentColor;
        public string CurrentColor 
        { 
            get
            {
                return _currentColor;
            }
            set
            {
                _currentColor = value;
                StateChanged?.Invoke();
            }
        }
        public event Action StateChanged;
    }
}
