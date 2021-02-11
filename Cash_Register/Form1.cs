using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
//Clara
//Feb 11, 2021
//Cash Register program
namespace Cash_Register
{
    public partial class Form1 : Form
    {
        //Global variables  
        double paintbrushCost = 5.15;
        double polymerClayCost = 4.00;
        double erasorCost = 3.25;

        double paintbrushs;
        double polymerClay;
        double erasor;

        double subTotalCost;
        double taxValue = 0.13;
        double amountTendered;

        double taxAmount;
        double finalPrice;
        double changeAmount;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate totals funtion
            mainReceiptLabel.BackColor = Color.White;
            mainReceiptLabel.Text = "";

            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources._517754__danlucaz__game_fx_10);
                player.Play();

                paintbrushs = Convert.ToDouble(textBoxPaintbrush.Text);
                polymerClay = Convert.ToDouble(textBoxClay.Text);
                erasor = Convert.ToDouble(textBoxErasor.Text);

                subTotalCost = paintbrushs * paintbrushCost + erasor * erasorCost + polymerClay * polymerClayCost;
                taxAmount = taxValue * subTotalCost;
                finalPrice = taxAmount + subTotalCost;

                calculateTotalLabel.Text += $" {subTotalCost.ToString("C")}";
                calculateTaxLabel.Text += $" {taxAmount.ToString("C")}";
                calculateTotalsLabel.Text += $" {finalPrice.ToString("C")}";
            }
            catch
            {
                SoundPlayer Player = new SoundPlayer(Properties.Resources._493163__breviceps__buzzer_sounds_wrong_answer_error);
                Player.Play();

                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.BackColor = Color.Red;
                ;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void calculateTotalLabel_Click(object sender, EventArgs e)
        {
            calculateTotalLabel.Text = $"{finalPrice.ToString("C")}";
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            //Calculate change funtion
            mainReceiptLabel.BackColor = Color.White;
            mainReceiptLabel.Text = "";
            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources._517754__danlucaz__game_fx_10);
                player.Play();

                amountTendered = Convert.ToDouble(tenderedTextBox.Text);
                changeAmount = amountTendered - finalPrice;
                ChangeLabelCalculation.Text = $" {changeAmount.ToString("C")}";
            }
            catch
            {
                SoundPlayer Player = new SoundPlayer(Properties.Resources._493163__breviceps__buzzer_sounds_wrong_answer_error);
                Player.Play();

                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.Text += $"\n\n xxxx NUMBERS ONLY xxxx";
                mainReceiptLabel.BackColor = Color.Red;
                ;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            calculateTaxLabel.Text = $"{taxAmount.ToString("C")}";
        }
        private void label5_Click(object sender, EventArgs e)
        {
            calculateTotalsLabel.Text = $"{finalPrice.ToString("C")}";
        }
        private void label6_Click(object sender, EventArgs e)
        {
            ChangeLabelCalculation.Text = $"{changeAmount.ToString("C")}";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxErasor_TextChanged(object sender, EventArgs e)
        {

        }
        private void RecieptButton_Click(object sender, EventArgs e)
        {
            //Print Receipt function
            SoundPlayer player = new SoundPlayer(Properties.Resources._345056__azumarill__epson_receipt_printer3);
            player.Play();

            mainReceiptLabel.Text += $"\n                Amazingly Cheap Art Shop .inc";
            Refresh();
            Thread.Sleep(500);

            mainReceiptLabel.Text += $"\n\n                   Reciept Number 2048";
            Refresh();
            Thread.Sleep(500);

            mainReceiptLabel.Text += $"\n\n         Paintbrushes         x {paintbrushs} @ {paintbrushCost.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            mainReceiptLabel.Text += $"\n          PolymerClay          x {polymerClay} @ {polymerClayCost.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            mainReceiptLabel.Text += $"\n         Bunny Erasors       x {erasor} @ {erasorCost.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            mainReceiptLabel.Text += $"\n\n         Subtotal           {subTotalCost.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            mainReceiptLabel.Text += $"\n         Tax                      {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            mainReceiptLabel.Text += $"\n         Total                  {finalPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            mainReceiptLabel.Text += $"\n\n         Tendered        {amountTendered.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            mainReceiptLabel.Text += $"\n          Change            {changeAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            mainReceiptLabel.Text += $"\n\n\n          Have a Fantastic Day!!!";
            Refresh();
            Thread.Sleep(500);
        }
        private void neOrderButton_Click(object sender, EventArgs e)
        {
            //New order/clear function
            mainReceiptLabel.BackColor = Color.White;

            textBoxPaintbrush.Text = "";
            textBoxClay.Text = "";
            textBoxErasor.Text = "";

            calculateTotalLabel.Text = "";
            calculateTaxLabel.Text = "";
            calculateTotalsLabel.Text = "";

            tenderedTextBox.Text = "";
            ChangeLabelCalculation.Text = "";
            mainReceiptLabel.Text = "";
        }
        private void oddButton_Click(object sender, EventArgs e)
        {
            //Extra button color change background
            SoundPlayer player = new SoundPlayer(Properties.Resources._221766__waveplay__game_fx);
            player.Play();

            this.BackColor = Color.DeepPink;
            mainReceiptLabel.Text += $"\n\n CONGRAGULATIONS!!!!!!";
            Refresh();
            Thread.Sleep(500);
            mainReceiptLabel.Text += $"\n\n You found the hidden color!";
            Refresh();
            Thread.Sleep(500);
            mainReceiptLabel.Text += $"\n\n Good Job";
            Refresh();
            Thread.Sleep(500);
            mainReceiptLabel.Text += $"\n\n Now go pay for your puchase";
            Refresh();
            Thread.Sleep(500);
        }
        private void textBoxPaintbrush_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
