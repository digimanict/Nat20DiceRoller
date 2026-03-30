using Android.App;
using Java.Awt.Font;

namespace Nat20DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int NumDice = 0;
        int NumBonus = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        //Dice Rolling logic, takes the number of dice and the type of die to roll, then adds any bonus and displays the result and the rolls.
        private void DiceRoll(int Dice)
        {
            int Total = 0;
            int Sum = 0;
            int Roll = 0;
            string DiceResults = "";
            NumDice = Int32.Parse(lblDiceNum.Text.Replace("D", ""));
            NumBonus = Int32.Parse(lblModNum.Text);
            Random rand = new Random();

            for (int i = NumDice; i > 0; i--)
            {
                Roll = rand.Next(1, Dice + 1);
                Sum = Sum += Roll;
                if (i > 1)
                {
                    DiceResults = DiceResults + Roll.ToString() + ", ";
                }
                else
                {
                    DiceResults = DiceResults + Roll.ToString();
                }
                
            }

            Total = Sum + NumBonus;
            lblResult.Text = Total.ToString();
            lblRolls.Text = DiceResults;
        }
        //Button click events for the plus and minus buttons for the number of dice and the bonus, as well as the buttons for each type of die.
        private void btnPlusDice_Clicked(object sender, EventArgs e)
        {
            NumDice = Int32.Parse(lblDiceNum.Text.Replace("D", ""));
            if (NumDice < 25)
            {
                NumDice++;
                lblDiceNum.Text = NumDice.ToString() + "D";
            }

        }

        private void btnPlusMod_Clicked(object sender, EventArgs e)
        {
            NumBonus = Int32.Parse(lblModNum.Text);
            if(NumBonus < 25)
            {
                NumBonus++;
                lblModNum.Text = NumBonus.ToString();
            }
        }

        private void btnMinusDice_Clicked(object sender, EventArgs e)
        {
            NumDice = Int32.Parse(lblDiceNum.Text.Replace("D", ""));
            if (NumDice > 1)
            {
                NumDice--;
                lblDiceNum.Text = NumDice.ToString() + "D";
            }
        }

        private void btnMinusMod_Clicked(object sender, EventArgs e)
        {
            NumBonus = Int32.Parse(lblModNum.Text);
            if (NumBonus > -25)
            {
                NumBonus--;
                lblModNum.Text = NumBonus.ToString();
            }
        }

        private void btnD2_Clicked(object sender, EventArgs e)
        {
            DiceRoll(2);
            lblFormula.Text = $"{lblDiceNum.Text}2{lblModNum.Text}";
        }

        private void btnD4_Clicked(object sender, EventArgs e)
        {
            DiceRoll(4);
            lblFormula.Text = $"{lblDiceNum.Text}4{lblModNum.Text}";
        }

        private void btnD6_Clicked(object sender, EventArgs e)
        {
            DiceRoll(6);
            lblFormula.Text = $"{lblDiceNum.Text}6{lblModNum.Text}";
        }

        private void btnD8_Clicked(object sender, EventArgs e)
        {
            DiceRoll(8);
            lblFormula.Text = $"{lblDiceNum.Text}8{lblModNum.Text}";
        }
        private void btnD10_Clicked(object sender, EventArgs e)
        {
            DiceRoll(10);
            lblFormula.Text = $"{lblDiceNum.Text}10{lblModNum.Text}";
        }
        private void btnD12_Clicked(object sender, EventArgs e)
        {
            DiceRoll(12);
            lblFormula.Text = $"{lblDiceNum.Text}12{lblModNum.Text}";
        }
        private void btnD20_Clicked(object sender, EventArgs e)
        {
            DiceRoll(20);
            lblFormula.Text = $"{lblDiceNum.Text}20{lblModNum.Text}";

        }

        private void btnD100_Clicked(object sender, EventArgs e)
        {
            DiceRoll(100);
            lblFormula.Text = $"{lblDiceNum.Text}100{lblModNum.Text}";
        }
    }
}
