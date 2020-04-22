using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeEngine;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Engine engine = new Engine();

        private Button lastButton;

        public Form1()
        {
            InitializeComponent();
            checkStatus();
        }

        private void checkStatus()
        {
            switch (engine.status)
            {
                case Engine.GameStatus.PlayerOPlays:
                    label2.Text = "playing: Player O";
                    break;
                case Engine.GameStatus.PlayerXPlays:
                    label2.Text = "playing: Player X";
                    break;
                case Engine.GameStatus.PlayerOWins:
                    label2.Text = "Player O won the game!";
                    break;
                case Engine.GameStatus.PlayerXWins:
                    label2.Text = "Player X won the game!";
                    break;
                default:
                    label2.Text = "no one is playing";
                    break;
            }
        }

        private void AddTic(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Er is geklikt!");
            lastButton = (Button) sender;


            switch (engine.status)
            {
                case Engine.GameStatus.PlayerOPlays:
                    if (engine.ChooseCell(lastButton.AccessibleName))
                    {
                        label3.Text = "";
                        lastButton.Text = "O";
                    }
                    else
                    {
                        label3.Text = "You can't choose that cell";
                    }
                    break;

                case Engine.GameStatus.PlayerXPlays:
                    if (engine.ChooseCell(lastButton.AccessibleName))
                    {
                        label3.Text = "";
                        lastButton.Text = "X";
                    }
                    else
                    {
                        label3.Text = "You can't choose that cell";
                    }
                    break;
            }
            Console.WriteLine(engine.Board());
            engine.CheckForWin();
            checkStatus();
        }

        private void Restart(object sender, EventArgs e)
        {
            engine.Restart();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            checkStatus();
        }
    }
}
