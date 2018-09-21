using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShelf
{
    public partial class frmTitles : Form
    {
        OleDbConnection conn;
        OleDbCommand titlesCommand;
        OleDbDataAdapter titlesAdapter;  

        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            var connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ysong\source\repos\BookShelf\Books.accdb;
                                Persist Security Info = False;";

            conn = new OleDbConnection(connString);
            conn.Open();
            titlesCommand = new OleDbCommand("Select * from Titles",conn);
            titlesAdapter = new OleDbDataAdapter();
            titlesAdapter.SelectCommand = titlesCommand;

            conn.Close();
            conn.Dispose();
            titlesAdapter.Dispose();
        }
    }
}
