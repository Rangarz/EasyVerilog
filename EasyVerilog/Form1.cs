using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyVerilog
{
    public partial class Form1 : Form
    {
        
        public static class Globals
        {

            public static string Initiator_var= null; // Modifiable
            public static string Target_var = null;
            public static string Time_var = null;
            public static string Words_var = null;

            public static string LST_Init_var = null; // Modifiable
            public static string LST_Target_var = null;


        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Getting the Textboxes Values
            Globals.Words_var = WordstextBox.Text;
            Globals.Time_var = TimetextBox.Text;

            if (Globals.Initiator_var == null)
            {
                MessageBox.Show("Please Choose an Initiator");
                return;
            }

            if (Globals.Target_var == null)
            {
                MessageBox.Show("Please Choose a Target");
                return;
            }

            if (Globals.Time_var == null)
            {
                MessageBox.Show("Please Choose enter a valid time");
                return;
            }

            if (Globals.Words_var == null)
            {
                MessageBox.Show("Please Choose enter a valid number of Words");
                return;
            }


            

            string Action = "-" + Globals.Initiator_var + " is sending " + Globals.Words_var + " words to " + Globals.Target_var + " at time " + Globals.Time_var ;

            TransQueue.Items.Add(Action);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DevA_Click(object sender, EventArgs e)
        {
            if (Init.Checked == true)
            {
                if (Globals.LST_Init_var == "Device A")
                {
                    DevA.Text = "Device A";
                }
                else if (Globals.LST_Init_var == "Device B")
                {
                    DevB.Text = "Device B";
                }
                else if (Globals.LST_Init_var == "Device C")
                {
                    DevC.Text = "Device C";
                }

                Globals.Initiator_var = "Device A";
                DevA.Text = "Device A(Initiator)";
                Globals.LST_Init_var = "Device A";
            }

            else if (Target.Checked == true)
            {
                if (Globals.LST_Target_var == "Device A")
                {
                    DevA.Text = "Device A";
                }
                else if (Globals.LST_Target_var == "Device B")
                {
                    DevB.Text = "Device B";
                }
                else if (Globals.LST_Target_var == "Device C")
                {
                    DevC.Text = "Device C";
                }

                Globals.Target_var = "Device A";
                DevA.Text = "Device A(Target)";
                Globals.LST_Target_var = "Device A";
            }

            else
            {
                MessageBox.Show("Please Specify the Device Type");
            }
        }

        private void DevB_Click(object sender, EventArgs e)
        {
            if (Init.Checked == true)
            {
                if (Globals.LST_Init_var == "Device A")
                {
                    DevA.Text = "Device A";
                }
                else if (Globals.LST_Init_var == "Device B")
                {
                    DevB.Text = "Device B";
                }
                else if (Globals.LST_Init_var == "Device C")
                {
                    DevC.Text = "Device C";
                }

                Globals.Initiator_var = "Device B";
                DevB.Text = "Device B(Initiator)";
                Globals.LST_Init_var = "Device B";
            }

            else if (Target.Checked == true)
            {
                if (Globals.LST_Target_var == "Device A")
                {
                    DevA.Text = "Device A";
                }
                else if (Globals.LST_Target_var == "Device B")
                {
                    DevB.Text = "Device B";
                }
                else if (Globals.LST_Target_var == "Device C")
                {
                    DevC.Text = "Device C";
                }

                Globals.Target_var = "Device B";
                DevB.Text = "Device B(Target)";
                Globals.LST_Target_var = "Device B";
            }

            else
            {
                MessageBox.Show("Please Specify the Device Type");
            }

        }

        private void DevC_Click(object sender, EventArgs e)
        {
            if (Init.Checked == true)
            {
                if (Globals.LST_Init_var == "Device A")
                {
                    DevA.Text = "Device A";
                }
                else if (Globals.LST_Init_var == "Device B")
                {
                    DevB.Text = "Device B";
                }
                else if (Globals.LST_Init_var == "Device C")
                {
                    DevC.Text = "Device C";
                }

                Globals.Initiator_var = "Device C";
                DevC.Text = "Device C(Initiator)";
                Globals.LST_Init_var = "Device C";
            }

            else if (Target.Checked == true)
            {

                if (Globals.LST_Target_var == "Device A")
                {
                    DevA.Text = "Device A";
                }
                else if (Globals.LST_Target_var == "Device B")
                {
                    DevB.Text = "Device B";
                }
                else if (Globals.LST_Target_var == "Device C")
                {
                    DevC.Text = "Device C";
                }



                Globals.Target_var = "Device C";
                DevC.Text = "Device C(Target)";
                Globals.LST_Target_var = "Device C";
            }

            else
            {
                MessageBox.Show("Please Specify the Device Type");
            }
        }

        private void easyVerilog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
