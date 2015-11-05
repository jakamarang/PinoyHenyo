using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pinoyhenyo
{
    public partial class Form3 : Form
    {
        private MySqlConnection conn;
        public char[] guess = new char[100];
        string jacob;
        public int a=0;

        public string cword;
        public int count = 0;
        
       
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            string host = "localhost";
            string user = "root";
            string password = "";
            string dbname = "phenyo";

            string connStr = String.Format(" server = {0}; user id = {1}; password = {2}; database={3}; pooling=false", host, user, password, dbname);

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Connecting.");
            }
            button1.Visible = false;
        }


      

        private void pass()
        {
            textBox1.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            dataGridView2.Visible = false;
            textBox2.Visible = false;
            timer1.Enabled = false;
            label1.Text = "2:00";
        
            dataGridView2.Rows.Clear();
            a = 0;
            sec = 59; min = 1;

     

        }
        private void prelim()
        {
            textBox1.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            dataGridView2.Visible = true;
            textBox2.Visible = true;
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = "Your Text Here...";
        
        }

        int min = 1;
        int sec = 60;


       

        public int f1, f2,score=0,cong=0;
        private void proc()
        {
          
             
                if (jacob == cword)
                {
                     dataGridView2.Rows.Add();
                     dataGridView2[0, a].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                     dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                     dataGridView2.AutoResizeRows();
                     score+=10;
                     label3.Text = score.ToString();
                     dataGridView2[0, a].Value = "Congratulations!".ToString(); a++; cong = 1; 
                     timer1.Enabled = false;
                    
                }
            
       
            else
            {
                MySqlDataReader reader = null;   
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM word ", conn); ;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    if (reader.GetString(f1) == jacob && jacob != "")
                    {
                        count++;
                        dataGridView2.Rows.Add();
                     
                        dataGridView2[0,a].Style.Alignment= DataGridViewContentAlignment.MiddleRight;
             
                        dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                        dataGridView2.AutoResizeRows();
                       
                        dataGridView2[0, a].Value = "Yes".ToString(); a++;
                        }

                   
                }

                reader.Close();
                            
              if (count == 0)
                {
                    count = 0;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                      if (reader.GetString(f2) == jacob && jacob != "" )
                        {
                            count++;
                            dataGridView2.Rows.Add();


                            dataGridView2[0,a].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                       
                            dataGridView2.AutoResizeRows();
                            dataGridView2[0, a].Value = "Maybe".ToString(); a++;
                            
                            
                        }
                     


                    }
                    reader.Close();

                  if (count == 0 || jacob == null)
                    
                    {
                        dataGridView2.Rows.Add();
                       
              
                        dataGridView2[0,a].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                 
                        dataGridView2.AutoResizeRows();
                        dataGridView2[0, a].Value = "No".ToString(); a++;
                        
                    }
                
               
                  
              
                  }
              count = 0;

             
             }

                           
        }


        private void button1_Click(object sender, EventArgs e)
        {

            
            jacob = textBox2.Text;
            dataGridView2.Rows.Add();
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView2[0, a].Value = jacob.ToString() + "?"; a++;
            textBox2.Clear();
            
            
            proc();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox2.ForeColor = Color.Black;
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            if (sec == 0 && min !=0) { min = 0; sec = 59; }
            if (min == 0 && sec ==0) 
            {
                timer1.Enabled = false;
                if (cong != 1)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2[0, a].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                    dataGridView2.AutoResizeRows();
                    dataGridView2[0, a].Value = "Game Over!".ToString();
                }
            
            }
            if (sec < 10) { label1.Text = min + ":0" + sec; }
            else
            {
                label1.Text = min + ":" + sec;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button5.Visible = true;
            timer1.Enabled = false;

            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button5.Visible = false;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pass();
        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int n = 0;
        private void button11_Click_1(object sender, EventArgs e)
        {
            //button 1
            cword = "pineapple";
            n = 1; f1 = 0; f2 = 1;
            next();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //button 2
            cword = "pig";
            n = 2; f1 = 2; f2 = 3;
            next();
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cword = "camera";
            n = 3; f1 = 4; f2 = 5;
            next();
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cword = "carpet";
            n = 4; f1 = 6; f2 = 7;
            next();
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cword = "carpet";
            n = 5; f1 = 6; f2 = 7;
            next();
        }
        private void next()
        {
            button6.Text = n.ToString();
            button6.Visible = true;
            button1.Visible = true;
            prelim();
            timer1.Enabled = true;
        
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cword = "dauis";
            n = 6; f1 = 8; f2 = 9;
            next();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cword = "siopao";
            n = 7; f1 = 10; f2 = 11;
            next();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            cword = "rib";
            n = 8; f1 = 12; f2 = 13;
            next();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }
      

      
       
        }
    
}
