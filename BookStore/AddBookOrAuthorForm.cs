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

namespace BookStore
{
    public partial class AddBookOrAuthorForm : Form
    {
        MySqlConnection conn;
        public AddBookOrAuthorForm()
        {
            InitializeComponent();

            string server = "localhost";
            string database = "books";
            string user = "root";
            string password = "2Va84y80xR64#%";


            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";
            conn = new MySqlConnection(connString);
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            //Hämta text från textfällt
            string strTitle = txtTitle.Text;
            int intAuthor = Convert.ToInt32(txtAuthor.Text);

            //Skriva SQL Insert statment
            string strSql = $"INSERT INTO books " +
                            $"(`books_title`, `author_author_id`) " +
                            $"VALUES ('{strTitle}', {intAuthor})";

            //Skapa en MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppna koppling till Databas
            conn.Open();

            //Skicka iväg MySQLCommand till Databas
            cmd.ExecuteReader();

            //Stänga koppling till Databas
            conn.Close();

            //Stänga fönstret
            this.Close();
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            //Hämta text från textfällt
            string strName = txtAuthorName.Text;

            //Skriva SQL Insert statment
            string strSql = $"INSERT INTO author " +
                            $"(`author_name`) " +
                            $"VALUES ('{strName}')";

            //Skapa en MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppna koppling till Databas
            conn.Open();

            //Skicka iväg MySQLCommand till Databas
            cmd.ExecuteReader();

            //Stänga koppling till Databas
            conn.Close();

            //Stänga fönstret
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
