using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosApp
{
    internal class TodoItem
    {
        private string title;
        private bool isCompleted;
        private int id;

        public String Title { get { return title; } }
        public bool Completed { get { return isCompleted; } set { this.isCompleted = value; } }

        public TodoItem(int id, String title, bool isCompleted) {
            this.title = title;
            this.isCompleted = isCompleted;
            this.id = id;
        }
    }
}
