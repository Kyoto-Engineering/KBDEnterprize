﻿using PhonebookApp.DbGateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace PhonebookApp.Reports
{
    public partial class ListOfContactByReligion : Form
    {

        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int relid;
        public ListOfContactByReligion()
        {
            InitializeComponent();
        }

        private void ListOfContactByReligion_Load(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "SELECT ReligionName FROM Religion ORDER BY ReligionId";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    religionComboBox.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void religionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(religionComboBox.Text))
            {
                try
                {

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ctk = "SELECT ReligionId FROM Religion WHERE ReligionName = @d1";

                    cmd = new SqlCommand(ctk);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@d1", religionComboBox.Text);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        relid = Convert.ToInt32(rdr["ReligionId"]);

                    }

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            getButton.Enabled = false;



            if (!string.IsNullOrWhiteSpace(religionComboBox.Text))
            {
                 if (workingRadioButton.Checked)
                {
                    GetWorking();
                    Clear();
                }
                else
                {
                    MessageBox.Show(@"Please Choose an Option");
                }
            }
            else
            {
                MessageBox.Show(@"Please Select a Religion");
            }

            getButton.Enabled = true;
        }

        private void Clear()
        {
            religionComboBox.SelectedIndex = -1;
            
            workingRadioButton.Checked = false;
        }

        private void GetWorking()
        {
            ParameterField paramField1 = new ParameterField();


            //creating an object of ParameterFields class
            ParameterFields paramFields1 = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue1 = new ParameterDiscreteValue();

            //set the parameter field name
            paramField1.Name = "id";

            //set the parameter value
            paramDiscreteValue1.Value = relid;

            //add the parameter value in the ParameterField object
            paramField1.CurrentValues.Add(paramDiscreteValue1);

            //add the parameter in the ParameterFields object
            paramFields1.Add(paramField1);
            ReportViewer f2 = new ReportViewer();
            TableLogOnInfos reportLogonInfos = new TableLogOnInfos();
            TableLogOnInfo reportLogonInfo = new TableLogOnInfo();
            ConnectionInfo reportConInfo = new ConnectionInfo();
            Tables tables = default(Tables);
            //	Table table = default(Table);
            var with1 = reportConInfo;
            with1.ServerName = "tcp:KyotoServer,49172";
            with1.DatabaseName = "KBDEnterprizeDecember";
            with1.UserID = "sa";
            with1.Password = "SystemAdministrator";
            ListofAllContactsByReligion cr = new ListofAllContactsByReligion();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }

            f2.crystalReportViewer1.ParameterFieldInfo = paramFields1;
            f2.crystalReportViewer1.ReportSource = cr;
            this.Visible = false;

            f2.ShowDialog();
            this.Visible = true;
        }

        
    }
}
