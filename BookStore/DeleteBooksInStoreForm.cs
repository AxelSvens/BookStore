﻿using Google.Protobuf.WellKnownTypes;
using MySqlConnector;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class DeleteBooksInStoreForm : Form
    {
        MySqlConnection conn;
        public DeleteBooksInStoreForm()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "books";
            string user = "root";
            string password = "2Va84y80xR64#%";


            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";
            conn = new MySqlConnection(connString);
            
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            int listIndex = fm.listBoxIndex();
            //Skriv SQL Select statement
            string strSql = $"CALL ViewBookByStore({})";

            //Skapa ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppna kopplingen
            conn.Open();

            //Exekvera commando till DB
            MySqlDataReader reader = cmd.ExecuteReader();

            //Använder en WhileLoop för att läsa varje rad
            while (reader.Read())
            {
                new StoreHasBooks(Convert.ToInt32(reader["store_store_id"]), Convert.ToInt32(reader["books_books_id"]));
            }

            //Stänger kopplingen
            conn.Close();
            

            //Användaren anger nummret Count för den person som den vill ta bort.

            int intBookId = Convert.ToInt32(txtBookId.Text);

            //Hämta ID värdet av det valda objektet
            int selectedID = StoreHasBooks.storehasbooks[intBookId - 1].Books_BooksId;

            //Anropa Stored Procuedure med det valda värdet -1's ID värde
            // SQL Querry för INSERT
            string sqlQuerry = $"CALL DeleteBookInStore({listIndex}, {selectedID});";

            // Skapa MySQLCOmmand objekt
            conn.Open();
            MySqlCommand cmda = new MySqlCommand(sqlQuerry, conn);

            //Exekvera MySQLCommand.
            cmda.ExecuteReader();

            //Stänger kopplingen
            conn.Close();

            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
