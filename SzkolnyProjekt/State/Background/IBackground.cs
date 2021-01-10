using System;
using System.Collections.Generic;
using System.Text;

namespace SzkolnyProjekt.State.Background
{
    public enum Color
    { 
    Red,
    Blue,
    Violet
    }

    public interface IBackground
    {
        public string CurrentColor { get; set; }
        event Action StateChanged;
    }
}
