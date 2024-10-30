using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlazorClassLibrary
{
    public class TodoItem
    {

        public string Text { get; set; }
        public bool IsDone { get; set; }

        public TodoItem(string text)
        {
            Text = text;
        }
    }
}
