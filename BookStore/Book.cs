using System;

public class Book
{
    internal class Book
    {

        //Attribut
        /* private int id;
         private string title;
         private int authorId;*/


        //Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }   


        //Statisk lista
        
        public static List<Book> books = new List<Book>();

        //Konstruktor
        public Book(int id, string title, int AuthorId)
        {
            this.Id = id;
            this.Title = title;
            this.Price = price;
            this.AuthorId = AuthorId;
               


            //Add THIS objekt to list
            books.Add(this);

        }
    }
}
