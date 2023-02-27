using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // Global Variabales go here
        List<Player> players = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name, team, position;
            int age;

            name = nameInput.Text;
            team = teamInput.Text;
            position = positionInput.Text;
            age = Convert.ToInt32(ageInput.Text);

            Player addedPlayer = new Player(name, team, position, age);
            players.Add(addedPlayer);

            outputLabel.Text = "";

            foreach (Player player in players)
            {
                outputLabel.Text += $"  {player.name}  {player.team}  {player.position}  {player.age}\n";
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions. 
            //---------------------------

        }

        private void showButton_Click(object sender, EventArgs e)
        {

        }
    }
}
