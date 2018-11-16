using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    //class Book : Parent
    //use virtual keywork to override in inherited class
    // and use word override in inherited class
    class Book
    {
        public string title;
        public string author;
        //private int pages;
        public int pages;
        public static int count = 0;

        public Book() { }

        public Book(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Creating Book " );
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            count++;
        }

        /*public int Pages {
            get { return pages; }
            set {
                if(value >= 200)
                {
                    pages = value;
                }
                else
                {
                    pages = 0;
                }
            }
        }*/
    }
}
