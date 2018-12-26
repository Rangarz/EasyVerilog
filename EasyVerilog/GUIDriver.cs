using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyVerilog
{
    static class GUIDriver
    {
        public static Form1 form1;
        public static MainForm mainForm;

        public static void Initialize()
        {
            form1 = new Form1();
            mainForm = new MainForm();
        }
        public static void ShowGUI()
        {
            form1.Show();
            mainForm.Hide();
        }
        public static void ShowIDE()
        {
            form1.Hide();
            mainForm.Show();
        }
    }
}
