﻿using System.Windows.Forms;

namespace HorseBetRace.Data.AllPunters
{
    public abstract class Punter
    {
        public string NotBetYet { get; set; } = " has not placed a bet.";
        public string Busted { get; set; } = " BUSTED!";
        public string MaxBet { get; set; } = " Max Bet $";
        public abstract string PunterName { get; set; } // The punters name
        public abstract Bet MyBet { get; set; }  // An instance of Bet() that has punters bet
        public abstract int Cash { get; set; } // How much money punter has
        public abstract RadioButton MyRadioButton { get; set; } //Radiobutton
        public abstract Label MyLabel { get; set; } //Label

        public void UpdateLabels() // Set my label to my bets description and the label on the radio button to show the punters cash
        {
            MyLabel.Text = MyBet.GetDescription();
        }

        public void PlaceBet(int betAmount, int horseToWin) // Place a new bet and store it in my bet field
        {
            //Place a new bet and store it
            //return true if punter had enough money to bet
            /*if (Cash >= betAmount)
            {
                MyBet = new Bet()
                {
                    Amount = betAmount,
                    Horse = horseToWin,
                    Bettor = this
                };

                UpdateLabels();

                return true;
            }*/
            //return false if punter did not have enough cash
            /*else
            {
                MessageBox.Show(PunterName + @" doesn't have enough to bet");
                return false;
            }*/

            //Displays error message if bet amount is greater than available cash
            if (Cash < betAmount)
            {
                MessageBox.Show($"{PunterName} doesn't have enough to bet");
            }
            else //else place a new bet and store it
            {
                MyBet = new Bet {Amount = betAmount, Horse = horseToWin, Bettor = this};
                UpdateLabels();
            }
        }

    }
}