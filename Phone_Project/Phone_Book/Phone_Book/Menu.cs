using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Hanterar händelsen när "Lägg till" knappen klickas
        private void button1_Click(object sender, EventArgs e)
        {
            // Öppnar en ny form för att lägga till data i telefonboken
            AddData frmAdd = new AddData();
            frmAdd.ShowDialog();
        }

        // Hanterar händelsen när "Ta bort" knappen klickas
        private void button2_Click(object sender, EventArgs e)
        {
            // Öppnar en ny form för att ta bort data från telefonboken
            RemoveData frmDel = new RemoveData();
            frmDel.ShowDialog();
        }

        // Hanterar händelsen när "Visa" knappen klickas
        private void button3_Click(object sender, EventArgs e)
        {
            // Öppnar en ny form för att visa data i telefonboken
            ShowData frmShow = new ShowData();
            frmShow.ShowDialog();
        }
    }
}
