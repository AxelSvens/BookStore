using System;

public class StoreHasBooks
{
    internal class StoreHasBooks
    {

        internal class StoreHasBooks
    {

        //Attribut
        /*private int store_storeId;
          private int books_booksId;
        */
        


        //Properties
        public int Store_StoreId { get; set; }
        public int Books_BooksId { get; set; }
        

        //Statisk lista
        public static List<StoreHasBooks> storehasbooks = new List<StoreHasBooks>();

        //Konstruktor
        public Author(int store_storeId, int books_booksId)
        {
            this.Store_StoreId = store_storeId;
            this.Books_BooksId = books_booksId;


            //Add THIS objekt to list
            authors.Add(this);

        }
    }

        
}
