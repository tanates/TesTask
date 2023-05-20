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
namespace Testtask2
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
          
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
          
            Data_box(comboBox1 );
          


        }

        private void TabConrol_Selecting(object sender, TabControlCancelEventArgs e)
        {
           
        }



        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            Loud_db(dataGridView1, comboBox1);
           

        }

        void Data_box(ComboBox comboBox1 )
        {
            string conn = @"Data Source=DESKTOP-VSQFV5I\SQLEXPRESS;Initial Catalog=TestTask;Integrated Security=True";
            try
            {
                
                SqlConnection myConnection = new SqlConnection(conn);
                myConnection.Open();
                string comm = "SELECT * From dbo.Department ORDER BY Id";
                SqlCommand command = new SqlCommand(comm, myConnection);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader[1]);
                         

                    }
                }
                
                myConnection.Close();
            }
            catch(SqlException  ex )
            {
                MessageBox.Show($"{ex}");
            }
        }
        void Grid_box(DataGridView dataGridView1)
        {
            string conn = @"Data Source=DESKTOP-VSQFV5I\SQLEXPRESS;Initial Catalog=TestTask;Integrated Security=True";

            try
            {
                SqlConnection myConnection = new SqlConnection(conn);
                myConnection.Open();
                string comm = "select distinct a.*, d.Name_department,d.Id from april a right join department d on a.DepartmentId = d.Id Where DepartmentId = 2";
                SqlCommand command = new SqlCommand(comm, myConnection);

                List<string[]> str = new List<string[]>();
                //  List<int> str_2 = new List<int>();
                // int i = 0;

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        str.Add(new string[8]);
                        str[str.Count - 1][0] = reader[1].ToString();
                        str[str.Count - 1][1] = reader[2].ToString();
                        str[str.Count - 1][2] = reader[3].ToString();
                        str[str.Count - 1][3] = reader[4].ToString();
                        str[str.Count - 1][4] = reader[5].ToString();
                        str[str.Count - 1][5] = reader[6].ToString();
                        str[str.Count - 1][6] = reader[7].ToString();
                        str[str.Count - 1][7] = reader[8].ToString();

                    }



                }
              
                myConnection.Close();
                foreach (string[] s in str)
                {
                    dataGridView1.Rows.Add(s);
                }

               
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex}");
            }
          
        }
        void Grid_box_2(DataGridView dataGridView1)
        {
            string conn = @"Data Source=DESKTOP-VSQFV5I\SQLEXPRESS;Initial Catalog=TestTask;Integrated Security=True";

            try
            {
                SqlConnection myConnection = new SqlConnection(conn);
                myConnection.Open();
                string comm = "select distinct a.*, d.Name_department,d.Id from april a right join department d on a.DepartmentId = d.Id Where DepartmentId = 1";
                SqlCommand command = new SqlCommand(comm, myConnection);

                List<string[]> str = new List<string[]>();
                //  List<int> str_2 = new List<int>();
                // int i = 0;

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        str.Add(new string[8]);
                        str[str.Count - 1][0] = reader[1].ToString();
                        str[str.Count - 1][1] = reader[2].ToString();
                        str[str.Count - 1][2] = reader[3].ToString();
                        str[str.Count - 1][3] = reader[4].ToString();
                        str[str.Count - 1][4] = reader[5].ToString();
                        str[str.Count - 1][5] = reader[6].ToString();
                        str[str.Count - 1][6] = reader[7].ToString();
                        str[str.Count - 1][7] = reader[8].ToString();

                    }



                }

                myConnection.Close();
                foreach (string[] s in str)
                {
                    dataGridView1.Rows.Add(s);
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex}");
            }

        }


        void Loud_db(DataGridView dataGridView1 , ComboBox comboBox1)
        {
           
            List<string[]> str_2 = new List<string[]>();//Содержит Id выьроного депортамента
            string conn = @"Data Source=DESKTOP-VSQFV5I\SQLEXPRESS;Initial Catalog=TestTask;Integrated Security=True";
  
            try
            {
                SqlConnection myConnection = new SqlConnection(conn);
                myConnection.Open();
                string com_1 = "select DepartmentId from april";
                SqlCommand command = new SqlCommand(com_1, myConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        str_2.Add(new string[1]);
                        str_2[str_2.Count - 1][0] = reader[0].ToString();
                    }
                    

                }
                myConnection.Close();
               switch(comboBox1.SelectedIndex)
                {
                    case 0:
                        Grid_box(dataGridView1);
                        break;
                    case 1:
                        Grid_box_2(dataGridView1);
                        break;
                }
                
            }
            catch (SqlException ex)
            {

                MessageBox.Show($"{ex}");

            }
           
            
          


        }
    }
    
}
