﻿using System;

public class Author
{
    internal class Author
    {

        //Attribut
        /*private int id;
        private string name;*/
        


        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        

        //Statisk lista
        public static List<Author> authors = new List<Author>();

        //Konstruktor
        public Author(int id, string name)
        {
            this.Id = id;
            this.Name = name;


            //Add THIS objekt to list
            authors.Add(this);

        }
    }
}
