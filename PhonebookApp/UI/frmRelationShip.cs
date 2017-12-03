﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhonebookApp.DbGateway;
using PhonebookApp.LogInUI;

namespace PhonebookApp.UI
{
    public partial class frmRelationShip : Form
    {
        private  SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs=new ConnectionString();
        public string user_id;
        public frmRelationShip()
        {
            InitializeComponent();
        }
  
        private void frmRelationShip_Load(object sender, EventArgs e)
        {
            user_id = frmLogin.uId.ToString();      
        }

        private void btnSaveRelationship_Click(object sender, EventArgs e)
        {
            if (txtRelationship.Text == "")
            {
                MessageBox.Show("Please Enter  Relationship ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRelationship.Focus();
                return;
            }
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RelationShip from RelationShips where RelationShip='" + txtRelationship.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("This RelationShips  Already Exists in the List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRelationship.Clear();
                    txtRelationship.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "insert into RelationShips(RelationShip, UserId, DateAndTime) values(@d1,@d2,@d3)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", txtRelationship.Text);
                cmd.Parameters.AddWithValue("@d2", user_id);
                cmd.Parameters.AddWithValue("@d3", DateTime.UtcNow.ToLocalTime());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRelationship.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRelationship_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveRelationship_Click(this, new EventArgs());
            }
        }
    }
}
