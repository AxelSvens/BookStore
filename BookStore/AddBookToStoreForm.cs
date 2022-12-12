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
    public partial class AddBookToStoreForm : Form
    {
        MySqlConnection conn;
        public AddBookToStoreForm()
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
            int intBookId = Convert.ToInt32(txtBookId.Text);

            //Hämta ID värdet av det valda objektet
            int selectedID = StoreHasBooks.storehasbooks[intBookId - 1].Books_BooksId;

            //Anropa Stored Procuedure med det valda värdet -1's ID värde
            // SQL Querry för INSERT
            string sqlQuerry = $"INSERT INTO books "$"`author_author_id`) " +
                            $"VALUES"; {selectedID});";

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
