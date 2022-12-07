using System;

public class Store
{
    internal class Store
    {

        //Attribut
        /*private int id;
        private string name;
        private int phoneNumber;
        private string adress;*/


        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }


        //Statisk lista
        public static List<Store> stores = new List<Store>();

        //Konstruktor
        public Store(int id, string name, int phoneNumber, string adress)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Adress = adress;


            //Add THIS objekt to list
            stores.Add(this);

        }
    }
}
