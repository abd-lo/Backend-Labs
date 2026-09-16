using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
      
        float CalculateSizePrice()
        {
            if (rdLarge.Checked)
                return Convert.ToSingle(rdLarge.Tag);

            else if (rdMeduim.Checked)
                return Convert.ToSingle(rdMeduim.Tag);

            else
                return Convert.ToSingle(rdSmall.Tag);

        

        }

        float CalculateCrustPrice()
        {
            if (rdThinCrust.Checked)
                return Convert.ToSingle(rdThinCrust.Tag);

            else 
                return Convert.ToSingle(rdThickCrust.Tag);

        }


        float CalculateToppingPrice()
        {
            float Price = 0;

            if (chExtraChees.Checked)
                Price+= Convert.ToSingle(chExtraChees.Tag);

            if (chGreenpeppers.Checked)
                Price+= Convert.ToSingle(chGreenpeppers.Tag);

            if (chMushrooms.Checked)
                Price+= Convert.ToSingle(chMushrooms.Tag);

            if (chOlives.Checked)
                Price+= Convert.ToSingle(chOlives.Tag);

            if (chOnion.Checked)
                Price+= Convert.ToSingle(chOnion.Tag);

            if (chTomatoes.Checked)
                Price+= Convert.ToSingle(chTomatoes.Tag);

            return Price;
        }
        float CalculateWhereToEatPrice()
        {
            if (rdEatIn.Checked)
                return Convert.ToSingle(rdEatIn.Tag);
            else
                return Convert.ToSingle(rdTakeOut.Tag);

        }
        
        float CalculateTotalPrice()
        {
            return CalculateCrustPrice() + CalculateSizePrice() + CalculateToppingPrice()+ CalculateWhereToEatPrice();
     }

        void UpdateTotalPrice()
        {
            lbPrice.Text = "$" + Convert.ToString( CalculateTotalPrice());
        }
 

        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rdSmall.Checked)
            { 
                lbSize.Text = "Small";
                return;
            }

            if (rdMeduim.Checked)
            {

                lbSize.Text = "Medium";
                return;
            }

            if (rdLarge.Checked)
            { 
                lbSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rdThickCrust.Checked)
            {
                lbCrustType.Text = rdThickCrust.Text;
                return;
            }

            else
            {

                lbCrustType.Text = "Thin Crust";
                return;
            }

        }

        void UpdateToppings()
        {


            string stToppings="";

            if (chExtraChees.Checked)
                stToppings= chExtraChees.Text;

            if (chGreenpeppers.Checked)
                stToppings += ","+chGreenpeppers.Text;

           if (chMushrooms.Checked)
                stToppings += ","+chMushrooms.Text;


            if (chOlives.Checked)
                stToppings += ","+chOlives.Text;


            if (chOnion.Checked)
                stToppings += ","+chOnion.Text;


            if (chTomatoes.Checked)
                stToppings += "," +chTomatoes.Text;

            if (stToppings.StartsWith(","))
            {
                stToppings= stToppings.Substring(1, stToppings.Length-1);
            }


            if (stToppings == "")
                stToppings = "No Toppings";
            lbToppings.Text = stToppings;
        }

        void UpdateWhereToEat()
        {
            if (rdEatIn.Checked)
            {
                lbWhereToEat.Text = rdEatIn.Text;
            }
            else
                lbWhereToEat.Text = rdTakeOut.Text;
        }

        void UpdateOrderSummary()
        {
            UpdateTotalPrice();
            UpdateCrust();
            UpdateSize();
            UpdateToppings();
            UpdateWhereToEat();
        }

        void ResetForm()
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbTooppings.Enabled = true;
            btnOrderPizza.Enabled = true;
            gbWhereToEat.Enabled = true;


            rdMeduim.Checked = true;
            rdThinCrust.Checked = true;
            rdEatIn.Checked = true;

            chExtraChees.Checked = false;
            chGreenpeppers.Checked = false;
            chOlives.Checked = false;
            chOnion.Checked = false;
            chTomatoes.Checked = false;
            chMushrooms.Checked = false;
        }

        //SizeRadipButtons
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }
   //CrustRadioButtons
        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
    

        }
        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lbCrustType.Text = rdThickCrust.Text;

        }
        //WhereToEat
        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lbWhereToEat.Text = rdEatIn.Text;
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lbWhereToEat.Text = rdTakeOut.Text;

        }
//Toppings
        private void chExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice() ;
            UpdateToppings();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are u sure","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Done!");
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbTooppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled= false;   

            }
         else
                MessageBox.Show("Order Cancelled ", "Cancel");


        }


        private void chMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chGreenpeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {


            ResetForm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();

        }
    }
}
