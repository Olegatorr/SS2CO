using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Screen;

namespace SS2OC3
{
    public partial class Form1 : Form
    {
        overlay overlayForm = new overlay();
        public Form1()
        {
            InitializeComponent();
            
        }


        
        public void buttonStart_Click(object sender, EventArgs e)
        {
            overlayForm.SetActive(true);
            pictureBox1.Image = SS2OC3.Properties.Resources.green2;
            overlayForm.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            overlayForm.Show();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            overlayForm.SetActive(false);
            pictureBox1.Image = SS2OC3.Properties.Resources.red2;
            overlayForm.Hide();
        }
        
    }
}