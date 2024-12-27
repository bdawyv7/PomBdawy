// This was written by me.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroProject
{
    public partial class frmEditTask : Form
    {
        string _SelectedItemName;
        public frmEditTask(string selectedItem)
        {
            InitializeComponent();

            _SelectedItemName = selectedItem;
            textBox1.Text = _SelectedItemName;
        }

        private void FocusScreen_Load(object sender, EventArgs e)
        {

        }


        private void btnOkEditTask_Click(object sender, EventArgs e)
        {
            string newItemName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newItemName))
            {
                MessageBox.Show("Please enter a valid name.");
            }
            else
            {
                frmMain mainForm = (frmMain)Application.OpenForms["frmMain"];
                mainForm.UpdateSelectedItem(newItemName);

                this.Close();
            }
        }

        private void btnCanelEditTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
