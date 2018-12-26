using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyVerilog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Welcome";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string text = "";
                FileHandler.OpenFileAbsolute(openFileDialog1.FileName, out text);
                

                listBox1.Items.Clear();
                foreach(string s in OpenedFilesHandles.OpenedFilesNames)
                {
                    listBox1.Items.Add(s);
                }
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                toolStripStatusLabel1.Text = "Loaded file: " + OpenedFilesHandles.OpenedFilesNames[listBox1.SelectedIndex];

                textBox1.Text = text;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            OpenedFilesHandles.SaveText(index, textBox1.Text);
            toolStripStatusLabel1.Text = "Text changed, consider saving...";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            textBox1.Text = OpenedFilesHandles.GetText(index);
            toolStripStatusLabel1.Text = "Editing: " + OpenedFilesHandles.OpenedFilesNames[listBox1.SelectedIndex];
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Running the compiler...";
            string errors = "";
            int exitCode;
            ExecutionHandler.CompileAll(out exitCode, out errors);
            if (exitCode != 0)
                textBox2.Text = "ExitCode: " + exitCode + " Errors: " + errors;
            else
                textBox2.Text = "Compiled Succesfully.";
            toolStripStatusLabel1.Text = "Finished compiling";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                FileHandler.CreateFileAbsolute(OpenedFilesHandles.GetFullName(i), OpenedFilesHandles.GetText(i));
            }
            toolStripStatusLabel1.Text = "Saved all changes successfully";
        }

        private void simulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Running the simulator...";
            string errors = "";
            string output = "";
            int exitCode;
            ExecutionHandler.Simulate(out exitCode, out errors, out output);
            if (exitCode != 0 && exitCode != -1)
                textBox2.Text = "ExitCode: " + exitCode + " Errors: " + errors;
            else 
                textBox2.Text = "Finished " + output;
            toolStripStatusLabel1.Text = "Finished simulation";
        }

        private void waveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Drawing Wave...";
            ExecutionHandler.DrawWave();
            toolStripStatusLabel1.Text = "Wave Drawing Ended";
        }
    }
}
