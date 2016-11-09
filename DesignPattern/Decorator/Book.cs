using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Book : LibraryItem
    {
        private string _author { get; set; }
        private string _title { get; set; }

        public Book(string name, string title, int NumCopies)
        {
            this._author = name;
            this._title = title;
            this.NumCopies = NumCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);  
        }
    }
}
