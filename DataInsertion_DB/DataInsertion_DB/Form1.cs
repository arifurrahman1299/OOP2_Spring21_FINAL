﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataInsertion_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCourse(object sender, EventArgs e)
        {
            string c_code = tbCCode.Text;
            string c_name = tbCName.Text;

            string connString = @"server=desktop-cb0xx\sqlexpress;Database=OOP_Final;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("insert into courses value('{0}','{1}')", c_code, c_name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if(r>0)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Data Didn't Inserted");
            }
            conn.Close();
        }
    }
}
