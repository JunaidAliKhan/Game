using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.ModernWarfare);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();
            this.Text = "Game";
            this.button1.Text = "START";
            this.button2.Text = "EXIT";
            
            this.CancelButton = this.button2;
            this.AcceptButton = this.button1;

            this.button1.FlatStyle = FlatStyle.Popup;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.button1.Cursor = Cursors.Hand;
            this.button2.Cursor = Cursors.Hand;
            this.button1.ForeColor = Color.DarkGray;
            this.button2.ForeColor = Color.DarkGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.Show();
            player.Stop();
            this.Hide();

        }
       
    }
}
