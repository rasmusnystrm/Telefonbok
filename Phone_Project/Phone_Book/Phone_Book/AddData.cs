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
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        // Hanterar händelsen när "Stäng" knappen klickas
        private void button2_Click(object sender, EventArgs e)
        {
            // Stänger formen när knappen klickas
            this.Close();
        }

        // Hanterar händelsen när "Lägg till" knappen klickas
        private void button1_Click(object sender, EventArgs e)
        {
            // Skapar en anslutning till databasen
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = InfoDb.accdb";
            conn.Open();

            // Skapar ett SQL-kommando för att lägga till data i databasen
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "insert into InfoTable(Fname, Lname, Klass, Telefonnummer, Mail) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            comm.Connection = conn;

            // Utför SQL-kommandot för att lägga till data i databasen
            comm.ExecuteNonQuery();

            // Stänger anslutning till databasen
            conn.Close();

            // Döljer den aktuella formen
            this.Hide();

            // Visar ett bekräftelsemeddelande om att data har sparats
            MessageBox.Show("Data successfully saved!");
        }
    }
}
