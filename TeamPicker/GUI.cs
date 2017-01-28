using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPicker
{
    public partial class Frame : Form
    {
        private int currentPick; // team 1 starts 

        public Frame()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frame_Load(object sender, EventArgs e)
        {
            newGame();
        }

        private void butPick_Click(object sender, EventArgs e)
        {
            // if there is a selection
            if (lbPlayerPool.SelectedIndex != -1)
            { 
                // if it's Team 1's turn
                if (currentPick == 1)
                {
                    lbTeam1.Items.Add(lbPlayerPool.SelectedItem); // add player to team
                    lbPlayerPool.Items.Remove(lbPlayerPool.SelectedItem); // remove player from pool                
                    lblWhosTurn.Text = "It is Team 2's turn to choose";
                    flTeam1.BackColor = Color.Transparent;
                    flTeam2.BackColor = Color.LightGreen;
                    flTeam1.BorderStyle = BorderStyle.None;
                    flTeam2.BorderStyle = BorderStyle.FixedSingle;           
                }

                // if it's Team 2's turn
                if (currentPick == 2)
                {
                    lbTeam2.Items.Add(lbPlayerPool.SelectedItem); // add player to team
                    lbPlayerPool.Items.Remove(lbPlayerPool.SelectedItem); // remove player from pool
                    lblWhosTurn.Text = "It is Team 1's turn to choose";
                    flTeam2.BackColor = Color.Transparent;
                    flTeam1.BackColor = Color.LightGreen;
                    flTeam1.BorderStyle = BorderStyle.FixedSingle;
                    flTeam2.BorderStyle = BorderStyle.None;                    
                }

                // switch teams
                if (currentPick == 1)
                {
                    currentPick = 2; // switch
                }
                else
                {
                    currentPick = 1; // switch 
                }
            }

            // when the teams are picekd
            // if the player pool is empty
            if (!(lbPlayerPool.Items.Count > 0))
            {
                lblWhosTurn.Text = "The teams have been selected";
                flTeam1.BackColor = Color.Transparent;
                flTeam2.BackColor = Color.Transparent;
                flTeam1.BorderStyle = BorderStyle.None;
                flTeam2.BorderStyle = BorderStyle.None;
                butPick.Enabled = false; // disable pick button
                lblWhosTurn.BackColor = Color.Salmon;
            }
            else
            {
                lbPlayerPool.SelectedIndex = 0; // reset selection
            }
        }

        private void newGame()
        {
            // add all players to the player pool
            lbPlayerPool.Items.Add("google");
            lbPlayerPool.Items.Add("triqqa");
            lbPlayerPool.Items.Add("netglow");
            lbPlayerPool.Items.Add("osr");
            lbPlayerPool.Items.Add("dbooka");
            lbPlayerPool.Items.Add("trippsupp");
            lbPlayerPool.Items.Add("tazlock");
            lbPlayerPool.Items.Add("scary");
            lbPlayerPool.SelectedIndex = 0; // default selection

            // room for random first turn
            // here

            // select team 1's turn
            currentPick = 1; // team 1 starts 
            lblWhosTurn.Text = "It is Team 1's turn to choose"; // set current turn label
            flTeam1.BorderStyle = BorderStyle.FixedSingle;
            flTeam1.BackColor = Color.LightGreen;
            lblWhosTurn.BackColor = Color.Transparent;
        }

        private void butClearAll_Click(object sender, EventArgs e)
        {
            // clear all list boxes
            lbPlayerPool.Items.Clear();
            lbTeam1.Items.Clear();
            lbTeam2.Items.Clear();
        }

        private void butStartOver_Click(object sender, EventArgs e)
        {
            // clear all list boxes
            lbPlayerPool.Items.Clear();
            lbTeam1.Items.Clear();
            lbTeam2.Items.Clear();           
            newGame();
            butPick.Enabled = true;
        }
    }
}
