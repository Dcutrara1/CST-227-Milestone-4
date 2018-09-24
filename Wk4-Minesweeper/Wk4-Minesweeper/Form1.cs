using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk4_Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (EasyButton.Checked == true)
            { Grid.Easy = true; Grid.Moderate = false; Grid.Difficult = false; }

            if (ModerateButton.Checked == true)
            { Grid.Moderate = true; Grid.Easy = false; Grid.Difficult = false; }

            if (DifficultButton.Checked == true)
            { Grid.Difficult = true; Grid.Easy = false; Grid.Moderate = false; }

            Form2 form = new Form2();           
            form.Show();
            
            
        }
    }
}
