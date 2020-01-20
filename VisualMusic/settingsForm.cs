using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualMusic
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        public Color GetColorEmpty
        {
            get { return colorEmpty.Color; }
        }

        public Color GetColorFull
        {
            get { return colorFull.Color; }
        }

        public int GetCol
        {
            get { return Convert.ToInt32(valCol.Text); }
        }

        public int GetRow
        {
            get { return Convert.ToInt32(valRow.Text); }
        }

        private void valRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void valCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void butFull_Click(object sender, EventArgs e)
        {
            colorFull.ShowDialog();
            butFull.BackColor = colorFull.Color;
        }

        private void butEmpty_Click(object sender, EventArgs e)
        {
            colorEmpty.ShowDialog();
            butEmpty.BackColor = colorEmpty.Color;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
