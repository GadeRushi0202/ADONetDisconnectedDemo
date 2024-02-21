using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetDisconnectedDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Write Query
                string qry = "Select * from Dept";//name of table in db
                                                  //Assign query to adapter -->Will fire the Query
                da = new SqlDataAdapter(qry, con);
                //craeted object of dataset
                ds = new DataSet();
                //Fil() will fire the select query and load data in the ds
                //Dept is a name given to the table in Dataset
                da.Fill(ds, "Dept");
                comboDept.DataSource = ds.Tables["Dept"];
                comboDept.DisplayMember = "dname";
                comboDept.ValueMember = "did";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataSet GetEmployees()
        {
            string qry = "select * from Employee";
            //assign Query
            da=new SqlDataAdapter(qry, con);
            //when app load the in DataSet , We need to manage the pk also
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //SCB will track the dataset and update queries to the DataAdapter
            builder = new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "Employee");//This name given to the Dataset table
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                ds = GetEmployees();
                //create new row to add record
                DataRow row = ds.Tables["Employee"].NewRow();
                //assign value to the row
                row["name"] = textName.Text;
                row["email"] = textEmail.Text;
                row["age"] = textAge.Text;
                row["salary"] = textSalary.Text;
                row["did"] = comboDept.SelectedValue;
                //attach this row in Dataset table
                ds.Tables["Employee"].Rows.Add(row);
                //Upadate the changs from Dataset to  DB
                int result = da.Update(ds.Tables["Employee"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                ds = GetEmployees();
                //Find the row
                DataRow row = ds.Tables["Employee"].Rows.Find(textId.Text);
                if(row != null)
                {
                    row["name"] = textName.Text;
                    row["email"] = textEmail.Text;
                    row["age"] = textAge.Text;
                    row["salary"] = textSalary.Text;
                    row["did"]= comboDept.SelectedValue;
                   
                    //Upadate the changs from Dataset to  DB
                    int result = da.Update(ds.Tables["Employee"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Id not Matched");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                ds = GetEmployees();
                //Find the row
                DataRow row = ds.Tables["Employee"].Rows.Find(textId.Text);
                if (row != null)
                {
                    //delete the current row from Dataset table
                    row.Delete();
                    //Upadate the changs from Dataset to  DB
                    int result = da.Update(ds.Tables["Employee"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Id not Matched");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                dataGridView1.DataSource = ds.Tables["Employee"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                string qry = "select e.*,d.dname from Employee e inner join dept d on d.did = e.did";
                da = new SqlDataAdapter(qry, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                da.Fill(ds, "emp");
                DataRow row = ds.Tables["emp"].Rows.Find(textId.Text);
                if (row != null)
                {
                    textName.Text = row["name"].ToString();
                    textEmail.Text = row["email"].ToString();
                    textAge.Text = row["age"].ToString();
                    textSalary.Text = row["salary"].ToString();
                    comboDept.Text = row["dname"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
