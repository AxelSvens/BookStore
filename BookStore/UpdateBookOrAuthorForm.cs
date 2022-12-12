using MySqlConnector;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class UpdateBookOrAuthorForm : Form
    {
        MySqlConnection conn;
        public UpdateBookOrAuthorForm()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "books";
            string user = "root";
            string password = "2Va84y80xR64#%";


            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";
            conn = new MySqlConnection(connString);
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            
            //Skriv SQL Select statement
            string strSql = "SELECT `books`.`books_id`, `books`.`books_title`, `books`.`author_author_id`, `author`.`author_name` " +
                            "FROM `books` JOIN `author` ON `books`.`author_author_id` = `author`.`author_id`;";

            //Skapa ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppna kopplingen
            conn.Open();

            //Exekvera commando till DB
            MySqlDataReader reader = cmd.ExecuteReader();

            //Använder en WhileLoop för att läsa varje rad
            while (reader.Read())
            {

                new Book(Convert.ToInt32(reader["books_id"]), reader["books_title"].ToString(), Convert.ToInt32(reader["author_author_id"]));
            }

            conn.Close();

            //Användaren anger nummret Count för den bok de vill uppdatera.

            string bookTitle = txtTitle.Text;
            int authorId = Convert.ToInt32(txtAuthor.Text);

            
            int intBookId = Convert.ToInt32(txtBookId.Text);

            //Hämta ID värdet av det valda objektet

            int selectedID = Book.books[intBookId - 1].Id;
            //int selectedAuthor = Author.authors[]

            //Anropa Stored Procuedure med det valda värdet -1's ID värde
            // SQL Querry för UPDATE
            string sqlQuerry = $"UPDATE `books`.`books` " +
                               $"SET `books_title` = '{bookTitle}', `author_author_id` = {authorId} " +
                               $"WHERE(`books_id` = {selectedID});";

            // Skapa MySQLCOmmand objekt
            conn.Open();
            MySqlCommand cmda = new MySqlCommand(sqlQuerry, conn);

            //Exekvera MySQLCommand.
            cmda.ExecuteReader();

            //Stänger kopplingen
            conn.Close();

            this.Close();

        }

        private void btnAuthorUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
