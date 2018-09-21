﻿using System;
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
        DataTable titlesTable;

        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            var connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jchen\source\repos\BookShelf\Books.accdb;
                                Persist Security Info = False;";

            // create conection
            conn = new OleDbConnection(connString);
            conn.Open();

            // create sql command
            titlesCommand = new OleDbCommand("Select * from Titles",conn);

            // run the sql code
            titlesAdapter = new OleDbDataAdapter();
            titlesAdapter.SelectCommand = titlesCommand;

            // create data table and fill the table with the query result
            titlesTable = new DataTable();
            titlesAdapter.Fill(titlesTable);

            // bind controls with data
            txtTitle.DataBindings.Add("Text", titlesTable, "Title");
            txtYear.DataBindings.Add("Text", titlesTable, "Year_Published");
            txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
            txtPubID.DataBindings.Add("Text", titlesTable, "PubID");

            // close connection
            conn.Close();
            conn.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();

           
        }
    }
}
