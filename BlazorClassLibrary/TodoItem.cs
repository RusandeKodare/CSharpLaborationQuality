using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlazorClassLibrary
{
    public class TodoItem
    {
        [Required(ErrorMessage = "Can not be empty")]
        public string Text { get; set; }
        public bool Completed { get; set; } = false;

        public TodoItem(string text)
        {
            Text = text;
        }
    }
}
