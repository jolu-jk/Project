using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UP0401Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RegistryKey rk = Registry.CurrentUser;
            RegistryKey reskey = rk.OpenSubKey("LabKey", true);

            BackColor = Color.FromArgb(int.Parse(reskey.GetValue("Color", Color.White.ToArgb()).ToString()));
            TEXT.Text = reskey.GetValue("Text").ToString();
            Width = int.Parse(reskey.GetValue("WeightForm", 808).ToString());
            Height = int.Parse(reskey.GetValue("HeightForm", 477).ToString());

            reskey.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser;
            RegistryKey reskey = rk.OpenSubKey("LabKey", true);
            reskey.SetValue("Color", BackColor.ToArgb());
            reskey.SetValue("Text", TEXT.Text);
            reskey.SetValue("WeightForm", Size.Width);
            reskey.SetValue("HeightForm", Size.Height);
            reskey.Close();
        }

        private void Colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Colors.SelectedItem)
            {
                case "Pink":
                        BackColor = Color.Pink;
                        break;
                case "Maroon":
                        BackColor = Color.Maroon;
                        break;
                case "Gray":
                        BackColor = Color.Gray;
                        break;
                case "Black":
                        BackColor = Color.Black;
                        break;
                case "Green":
                    BackColor = Color.Green;
                        break;
            }

        }

        private void TEXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
