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
            //string connString = "config.txt";

            conn = new MySqlConnection(connString);

        }

        private void btnHsRead_Click(object sender, EventArgs e)
        {

        }

        private void btnHsAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnHsDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnGtRead_Click(object sender, EventArgs e)
        {

        }

        private void btnGtAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnGtDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReadBook_Click(object sender, EventArgs e)
        {
            GridFill("BooksViewAll");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm FormBook = new AddBookForm();
            FormBook.Show();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void btnReadAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm FormAuthor = new AddAuthorForm();
            FormAuthor.Show();
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {

        }
        

        private void GridFill(string query)
        {
            using (conn)
            {
                conn.Open();
                MySqlDataAdapter SqlDa = new MySqlDataAdapter(query, conn);
                SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                SqlDa.Fill(dtblBook);
                dgvView.DataSource = dtblBook;
            }
        }
    }
}
