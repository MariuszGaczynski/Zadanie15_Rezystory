using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie15_Rezystory
{
    public partial class MainForm : Form
    {
        byte firstNumber, secondNumber;
        decimal multiplier, tolerance;
        bool band1Set, band2Set, band3Set, band4Set = false;

        

        public MainForm()
        {
            InitializeComponent();

        }

        

        private void comboFirstBand_SelectedIndexChanged(object sender, EventArgs e)
        { 
                if (comboFirstBand.SelectedIndex > -1)
                {
                    //lblResistanceValue.Text = String.Format("Pozycja {0} - kolor {1}",
                    //    comboFirstBand.SelectedIndex, comboFirstBand.SelectedItem);

                    switch (comboFirstBand.SelectedIndex)
                    {

                        case 0:
                            pnlFirstBand.BackColor = Color.Black;
                            firstNumber = 0;
                            break;
                        case 1:
                            pnlFirstBand.BackColor = Color.FromArgb(128, 58, 10);
                            firstNumber = 1;
                            break;
                        case 2:
                            pnlFirstBand.BackColor = Color.Red;
                            firstNumber = 2;
                            break;
                        case 3:
                            pnlFirstBand.BackColor = Color.DarkOrange;
                            firstNumber = 3;
                            break;
                        case 4:
                            pnlFirstBand.BackColor = Color.Yellow;
                            firstNumber = 4;
                            break;
                        case 5:
                            pnlFirstBand.BackColor = Color.Green;
                            firstNumber = 5;
                            break;
                        case 6:
                            pnlFirstBand.BackColor = Color.Blue;
                            firstNumber = 6;
                            break;
                        case 7:
                            pnlFirstBand.BackColor = Color.DarkViolet;
                            firstNumber = 7;
                            break;
                        case 8:
                            pnlFirstBand.BackColor = Color.LightGray;
                            firstNumber = 8;
                            break;
                        case 9:
                            pnlFirstBand.BackColor = Color.AntiqueWhite;
                            firstNumber = 9;
                            break;
                        default:
                                break;

                    }
                }

            band1Set = true;
            if (band1Set == true && band2Set == true &&
                band3Set == true && band4Set == true)
            {
                btnProceed.Enabled = true;
            }

            lblResistanceValue.Text = String.Empty;

        } // koniec kombo pierwszego paska

        

        private void comboSecondBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSecondBand.SelectedIndex > -1)
            {
                

                switch (comboSecondBand.SelectedIndex)
                {
                    
                    case 0:
                        pnlSecondBand.BackColor = Color.Black;
                        secondNumber = 0;
                        break;
                    case 1:
                        pnlSecondBand.BackColor = Color.FromArgb(128, 58, 10);
                        secondNumber = 1;
                        break;
                    case 2:
                        pnlSecondBand.BackColor = Color.Red;
                        secondNumber = 2;
                        break;
                    case 3:
                        pnlSecondBand.BackColor = Color.DarkOrange;
                        secondNumber = 3;
                        break;
                    case 4:
                        pnlSecondBand.BackColor = Color.Yellow;
                        secondNumber = 4;
                        break;
                    case 5:
                        pnlSecondBand.BackColor = Color.Green;
                        secondNumber = 5;
                        break;
                    case 6:
                        pnlSecondBand.BackColor = Color.Blue;
                        secondNumber = 6;
                        break;
                    case 7:
                        pnlSecondBand.BackColor = Color.DarkViolet;
                        secondNumber = 7;
                        break;
                    case 8:
                        pnlSecondBand.BackColor = Color.LightGray;
                        secondNumber = 8;
                        break;
                    case 9:
                        pnlSecondBand.BackColor = Color.AntiqueWhite;
                        secondNumber = 9;
                        break;
                    default:
                        break;

                }
            }

            band2Set = true;
            if (band1Set == true && band2Set == true &&
                band3Set == true && band4Set == true)
            {
                btnProceed.Enabled = true;
            }

            lblResistanceValue.Text = String.Empty;

        } // koniec kombo drugiego paska



        private void comboThirdBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboThirdBand.SelectedIndex > -1)
            {


                switch (comboThirdBand.SelectedIndex)
                {
                    
                    case 0:
                        pnlThirdBand.BackColor = Color.Fuchsia;
                        multiplier = 0.001m;
                        break;
                    case 1:
                        pnlThirdBand.BackColor = Color.FromArgb(192, 192, 192);
                        multiplier = 0.01m;
                        break;
                    case 2:
                        pnlThirdBand.BackColor = Color.FromArgb(207, 181, 59);
                        multiplier = 0.1m;
                        break;
                    case 3:
                        pnlThirdBand.BackColor = Color.Black;
                        multiplier = 1m;
                        break;
                    case 4:
                        pnlThirdBand.BackColor = Color.FromArgb(128, 58, 10);
                        multiplier = 10m;
                        break;
                    case 5:
                        pnlThirdBand.BackColor = Color.Red;
                        multiplier = 100m;
                        break;
                    case 6:
                        pnlThirdBand.BackColor = Color.DarkOrange;
                        multiplier = 1000m;
                        break;
                    case 7:
                        pnlThirdBand.BackColor = Color.Yellow;
                        multiplier = 10000m;
                        break;
                    case 8:
                        pnlThirdBand.BackColor = Color.Green;
                        multiplier = 100000m;
                        break;
                    case 9:
                        pnlThirdBand.BackColor = Color.Blue;
                        multiplier = 1000000m;
                        break;
                    case 10:
                        pnlThirdBand.BackColor = Color.DarkViolet;
                        multiplier = 10000000m;
                        break;
                    case 11:
                        pnlThirdBand.BackColor = Color.LightGray;
                        multiplier = 100000000m;
                        break;
                    case 12:
                        pnlThirdBand.BackColor = Color.AntiqueWhite;
                        multiplier = 1000000000m;
                        break;
                    default:
                        break;

                }
            }

            band3Set = true;
            if (band1Set == true && band2Set == true &&
                band3Set == true && band4Set == true)
            {
                btnProceed.Enabled = true;
            }

            lblResistanceValue.Text = String.Empty;


        } // koniec kombo trzeciego paska


        private void comboFourthBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFourthBand.SelectedIndex > -1)
            {


                switch (comboFourthBand.SelectedIndex)
                {
                    
                    case 0:
                        pnlFourthBand.BackColor = Color.White;
                        tolerance = 20m;
                        break;
                    case 1:
                        pnlFourthBand.BackColor = Color.FromArgb(192, 192, 192);
                        tolerance = 10m;
                        break;
                    case 2:
                        pnlFourthBand.BackColor = Color.FromArgb(207, 181, 59);
                        tolerance = 5m;
                        break;
                    case 3:
                        pnlFourthBand.BackColor = Color.FromArgb(128, 58, 10);
                        tolerance = 1m;
                        break;
                    case 4:
                        pnlFourthBand.BackColor = Color.Red;
                        tolerance = 2m;
                        break;
                    case 5:
                        pnlFourthBand.BackColor = Color.DarkOrange;
                        tolerance = 0.05m;
                        break;
                    case 6:
                        pnlFourthBand.BackColor = Color.Yellow;
                        tolerance = 0.02m;
                        break;
                    case 7:
                        pnlFourthBand.BackColor = Color.Green;
                        tolerance = 0.5m;
                        break;
                    case 8:
                        pnlFourthBand.BackColor = Color.Blue;
                        tolerance = 0.25m;
                        break;
                    case 9:
                        pnlFourthBand.BackColor = Color.DarkViolet;
                        tolerance = 0.1m;
                        break;
                    case 10:
                        pnlFourthBand.BackColor = Color.LightGray;
                        tolerance = 0.01m;
                        break;
                    default:
                        break;

                }
            }

            band4Set = true;
            if (band1Set == true && band2Set == true &&
                band3Set == true && band4Set == true)
            {
                btnProceed.Enabled = true;
            }

            lblResistanceValue.Text = String.Empty;

        } // koniec kombo czwartego paska


        private void btnProceed_Click(object sender, EventArgs e)
        {
            int number = firstNumber * 10 + secondNumber;
            decimal resistanceValue = ((decimal)number * multiplier) / 1000;

            lblResistanceValue.Text = resistanceValue.ToString() + "kΩ    " + "±" + tolerance + "%";


        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            lblResistanceValue.Text = String.Empty;
            comboFirstBand.ResetText();
            comboSecondBand.ResetText();
            comboThirdBand.ResetText();
            comboFourthBand.ResetText();
            band1Set = false;
            band2Set = false;
            band3Set = false;
            band4Set = false;
            btnProceed.Enabled = false;
            pnlFirstBand.BackColor = Color.White;
            pnlSecondBand.BackColor = Color.White;
            pnlThirdBand.BackColor = Color.White;
            pnlFourthBand.BackColor = Color.White;
        }

    } 
    
}
