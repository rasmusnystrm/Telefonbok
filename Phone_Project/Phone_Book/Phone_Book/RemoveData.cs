using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class RemoveData : Form
    {
        public RemoveData()
        {
            InitializeComponent();
        }

        // Hanterar händelsen när "Stäng" knappen klickas
        private void button2_Click(object sender, EventArgs e)
        {
            // Stänger formen när knappen klickas
            this.Close();
        }

        // Hanterar händelsen när "Ta bort" knappen klickas
        private void button1_Click(object sender, EventArgs e)
        {
            // Skapar en anslutning till databasen
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = InfoDb.accdb";
            conn.Open();

            // Skapar ett SQL-kommando för att ta bort data från databasen baserat på förnamn
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "delete from InfoTable where Fname='" + textBox2.Text + "'";
            comm.Connection = conn;

            // Utför SQL-kommandot för att ta bort data från databasen
            comm.ExecuteNonQuery();

            // Stänger anslutning till databasen
            conn.Close();

            // Döljer den aktuella formen
            this.Hide();

            // Visar ett bekräftelsemeddelande om att data har tagits bort
            MessageBox.Show("Data successfully removed!");
        }
    }
}
