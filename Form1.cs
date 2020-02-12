using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3_Console_Input_WinForms
{
    public partial class MainForm : Form
    {
        string name;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtInput.Text;
            IbMessage.Text = ($"Greetings {name}!");

        }
    }
}
