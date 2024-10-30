using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpLaborationQuality.Components
{
    public class TodoItem
    {

        public string Text { get; set; }
        public bool Completed { get; set; }

        public TodoItem(string text)
        {
            Text = text;
        }
    }
}
