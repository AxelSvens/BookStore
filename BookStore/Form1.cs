using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStore
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            
            string server = "localhost";
            string database = "books";
            string user = "root";
            string password = "2Va84y80xR64#%";


            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);

        }
        private void btnStoreRead_Click(object sender, EventArgs e)
        {
            //Skriv SQL Select statement
            string strSql = $"CALL ViewBookByStore({listBox1.SelectedIndex + 1})";

            //Skapa ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Nollställer labels
            lblId.Text = "ID";
            lblTitleOrAuthor.Text = "Title";
            lblAuthor.Text = "Author";

            //Öppna kopplingen
            conn.Open();

            //Exekvera commando till DB
            MySqlDataReader reader = cmd.ExecuteReader();

            int intID = 1;

            //Använder en WhileLoop för att läsa varje rad
            while (reader.Read())
            {

                //Skriv ut ID
                //lblId.Text += Environment.NewLine + reader["books_id"];
                lblId.Text += Environment.NewLine + intID++;

                //Skriv ut Bok Titeln
                lblTitleOrAuthor.Text += Environment.NewLine + reader["books_title"];

                //Skriv ut Author Namn
                lblAuthor.Text += Environment.NewLine + reader["author_name"];

                new StoreHasBooks(Convert.ToInt32(reader["store_store_id"]), Convert.ToInt32(reader["books_books_id"]));
            }

            //Stänger kopplingen
            conn.Close();
        }

        private void btnStoreAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnStoreDelete_Click(object sender, EventArgs e)
        {
            int intIndex = listBox1.SelectedIndex;
            DeleteBooksInStoreForm fm = new DeleteBooksInStoreForm();
            fm.Show();
        }

        private void btnReadBook_Click(object sender, EventArgs e)
        {
            //Skriv SQL Select statement
            string strSql = "SELECT `books`.`books_id`, `books`.`books_title`, `books`.`author_author_id`, `author`.`author_name` " +
                            "FROM `books` JOIN `author` ON `books`.`author_author_id` = `author`.`author_id`;";

            //Skapa ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            lblAuthor.Visible= true;

            //Nollställer labels
            lblId.Text = "ID";
            lblTitleOrAuthor.Text = "Title";
            lblAuthor.Text = "Author";

            //Öppna kopplingen
            conn.Open();

            //Exekvera commando till DB
            MySqlDataReader reader = cmd.ExecuteReader();

            int intID = 1;

            //Använder en WhileLoop för att läsa varje rad
            while (reader.Read())
            {

                //Skriv ut ID
                //lblId.Text += Environment.NewLine + reader["books_id"];
                lblId.Text += Environment.NewLine + intID++;

                //Skriv ut Bok Titeln
                lblTitleOrAuthor.Text += Environment.NewLine + reader["books_title"];

                //Skriv ut Author Namn
                lblAuthor.Text += Environment.NewLine + reader["author_name"];
                
                new Book(Convert.ToInt32(reader["books_id"]), reader["books_title"].ToString(), Convert.ToInt32(reader["author_author_id"]));
            }

            //Stänger kopplingen
            conn.Close();
        }

        private void btnReadAuthor_Click(object sender, EventArgs e)
        {
            //Skriv SQL Select statement
            string strSql = "SELECT `author`.`author_id`, `author`.`author_name` " +
                            "FROM author;";

            //Skapa ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            lblAuthor.Visible= false;

            //Nollställer labels
            lblId.Text = "ID";
            lblTitleOrAuthor.Text = "Author";

            //Öppna kopplingen
            conn.Open();

            //Exekvera commando till DB
            MySqlDataReader reader = cmd.ExecuteReader();

            int intID = 1;

            //Använder en WhileLoop för att läsa varje rad
            while (reader.Read())
            {

                //Skriv ut ID
                lblId.Text += Environment.NewLine + intID++;

                //Skriv ut Author Name
                lblTitleOrAuthor.Text += Environment.NewLine + reader["author_name"];

                new Author(Convert.ToInt32(reader["author_id"]), reader["author_name"].ToString());
            }

            //Stänger kopplingen
            conn.Close();
        }

        private void btnAddBookOrAuthor_Click(object sender, EventArgs e)
        {
            AddBookOrAuthorForm fm = new AddBookOrAuthorForm();
            fm.Show();
        }

        private void btnUpdateBookOrAuthor_Click(object sender, EventArgs e)
        {
            UpdateBookOrAuthorForm fm = new UpdateBookOrAuthorForm();
            fm.Show();
        }

        private void btnDeleteBookOrAuthor_Click(object sender, EventArgs e)
        {
            DeleteBookOrAuthorForm fm = new DeleteBookOrAuthorForm();
            fm.Show();
        }

        public int listBoxIndex()
        {
            return listBox1.SelectedIndex;
        }
    }
}
