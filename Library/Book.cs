using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : IComparable<Book>
    {
        //Constructor
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Author = authors;
        }

        //Properties of the class
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Author { get; private set; }

        //Comparing the book with Icomparable inerface method CompareTo()
        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if(result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }


        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
       

    }
}
