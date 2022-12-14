using MySql.Data.MySqlClient;
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
    public partial class DeleteBookOrAuthorForm : Form
    {
        MySqlConnection conn;
        public DeleteBookOrAuthorForm()
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
            //Hämtar värden från textBox
            int bookId = Convert.ToInt32(txtBookId.Text);

            //Konverterar värde till ett id
            int selectedID = Book.books[bookId - 1].Id;

            //SQL Querry
            string strSql = $"CALL DeleteBookInDB({selectedID});";

            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppnar koppling till DB, Utför Querry, Stänger koppling till DB
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();

            //Stänger fönstret
            this.Close();
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            //Hämtar värden från textBox
            int authorId = Convert.ToInt32(txtAuthorId.Text);

            //Konverterar värde till ett id
            int selectedId = Author.authors[authorId - 1].Id;

            //SQL Querry
            string strSql = $"CALL DeleteAuthorInDB({selectedId})";

            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppnar koppling till DB, Utför Querry, Stänger koppling till DB
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();

            //Stänger fönstret
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Stänger fönstret
            this.Close();
        }
    }
}
