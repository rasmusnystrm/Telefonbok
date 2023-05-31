using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }

        // Hanterar händelsen när "Stäng" knappen klickas
        private void button2_Click(object sender, EventArgs e)
        {
            // Stänger formen när knappen klickas
            this.Close();
        }

        // Hanterar händelsen när "Visa" knappen klickas
        private void button1_Click(object sender, EventArgs e)
        {
            // Skapar en anslutning till databasen
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = InfoDb.accdb";
            conn.Open();

            // Skapar ett SQL-kommando för att välja all data från InfoTable
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Select * from InfoTable";
            comm.Connection = conn;

            // Skapar en OleDbDataAdapter och ansluter den till SQL-kommandot
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;

            // Skapar en DataTable och fyller den med data från databasen
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Använder DataTable som datakälla för DataGridView för att visa datan från telefonboken
            dataGridView1.DataSource = dt;

            // Stänger anslutning till databasen
            conn.Close();
        }
    }
}
