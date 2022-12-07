using System;

public class Book
{
    internal class Book
    {

        //Attribut
        /* private int id;
         private int publishYear;
         private int price;
         private string title;*/


        //Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public int Price { get; set; }


        //Statisk lista<¨-
        //,.'
        public static List<Book> books = new List<Book>();

        //Konstruktor
        public Book(int id, string title, int publishYear, int price)
        {
            this.Id = id;
            this.Title = title;
            this.PublishYear = publishYear;
            this.Price = price;


            //Add THIS objekt to list
            books.Add(this);

        }
    }
}
