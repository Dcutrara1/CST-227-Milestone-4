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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
                        
            // Set the row and column of Grid. 
            int Row = 0;
            int Col = 0;

            if (Grid.Easy == true)
            { Row = 9; Col = 9; }

            if (Grid.Moderate == true)
            { Row = 16; Col = 16; }

            if (Grid.Difficult == true)
            { Row = 16; Col = 30; }


            // Create 2D Array of buttons
            Button[,] buttons = new Button[Row, Col];
            CreateButtons(buttons);
        }

        public void CreateButtons(Button[,] buttons)
        {
            // Getting the number of rows in the array
            int rows = buttons.GetUpperBound(0) + 1;

            // Getting the number of columns in the array
            int columns = buttons.GetUpperBound(buttons.Rank - 1) + 1;

            // Starting row and column point
            int x = 0;
            int y = 0;

            // Instantiating all the buttons in the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(30, 30);
                    buttons[i, j].Padding = Padding.Empty;
                    buttons[i, j].Margin = Padding.Empty;
                    buttons[i, j].BackColor = SystemColors.MenuHighlight;
                    buttons[i, j].Location = new Point(x + buttons[i, j].Width + 1,
                       y + buttons[i, j].Height + 1);

                    buttons[i, j].Click += new EventHandler(Buttons_Click);
                    flowLayoutPanel1.Controls.Add(buttons[i, j]);


                    if (Grid.Easy == true)
                    {
                        flowLayoutPanel1.Location = new Point(550, 50);
                        flowLayoutPanel1.Size = new Size(275, 275);
                        flowLayoutPanel1.Controls.Add(buttons[i, j]);
                        
                    }

                    else if (Grid.Moderate == true)
                    {
                        flowLayoutPanel1.Location = new Point(450, 50);
                        flowLayoutPanel1.Size = new Size(485, 485);
                        flowLayoutPanel1.Controls.Add(buttons[i, j]);                        
                    }

                    else if (Grid.Difficult == true)
                    {
                        flowLayoutPanel1.Location = new Point(200, 50);
                        flowLayoutPanel1.Size = new Size(905, 485);
                        flowLayoutPanel1.Controls.Add(buttons[i, j]);                       
                    }                    
                }
            }
        }

        public void Buttons_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            {
                clickedButton.BackColor = SystemColors.GrayText;
            }
        }
    }
}