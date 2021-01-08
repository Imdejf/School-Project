using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;

namespace SzkolnyProjekt.Model
{
    public class ToDoModel
    {
        public bool IsSelected { get; set; }
        public string Task { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
