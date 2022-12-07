using System;

public class Author
{
    internal class Author
    {

        //Attribut
        /*private int id;
        private string name;
        private string lastname;
        private int age;*/


        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        //Statisk lista
        public static List<Author> authors = new List<Author>();

        //Konstruktor
        public Author(int id, string name, string lastname, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;


            //Add THIS objekt to list
            authors.Add(this);

        }
    }
}
