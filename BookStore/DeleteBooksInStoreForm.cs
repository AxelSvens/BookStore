using Google.Protobuf.WellKnownTypes;
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
            //Användaren anger nummret Count för den person som den vill ta bort.

            int ListIndex = Index.index[0];
            
            int intBookId = Convert.ToInt32(txtBookId.Text);

            //Hämta ID värdet av det valda objektet
            int selectedID = StoreHasBooks.storehasbooks[intBookId - 1].Books_BooksId;

            //Anropa Stored Procuedure med det valda värdet -1's ID värde
            // SQL Querry för INSERT
            string sqlQuerry = $"CALL DeleteBookInStore({ListIndex}, {selectedID});";

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
