using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokus
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = ""; //no operator
        bool number_pressed = false;
        bool operation_pressed = false; //no operator had been pressed yet


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


       

   
        private void buttonce_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }




        private void buttontool_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operation_pressed == true)
                result.Text = "";
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;       
           
        }

        private void buttonc_click(object sender, EventArgs e)
        {
            result.Text = "0";

        }

        private void button_abs_Click(object sender, EventArgs e)
        {
            if (!number_pressed)
                result.Text = ("ERROR");
            else
            {
                value = DanaProfessional.OperationsProfessional.Abs(double.Parse(result.Text));
                result.Text = value.ToString();
            }
        }

        private void button_fact(object sender, EventArgs e)
        {
            int Check = 0;
            bool Result = Int32.TryParse(result.Text, out Check);
             if(Result==true && int.Parse(result.Text)>0)
            {
                value = DanaSimple.OperationsSimple.Factorial(int.Parse(result.Text));
                result.Text = value.ToString();
            }
             else 
                {result.Text= "ERROR";};
        }

     private void equals_Click(object sender, EventArgs e)
        {
            if(operation_pressed)
            {


                switch (operation)
                {
                    case "+":
                        result.Text = DanaSimple.OperationsSimple.Plus(value, double.Parse(result.Text)).ToString();
                        break;

                    case "-":
                        result.Text = DanaSimple.OperationsSimple.Minus(value, double.Parse(result.Text)).ToString();
                        break;
                    case "*":
                        result.Text = DanaSimple.OperationsSimple.Multi(value, double.Parse(result.Text)).ToString();
                        break;
                    case "/":
                        result.Text = DanaSimple.OperationsSimple.Div(value, double.Parse(result.Text)).ToString();
                        break;
                    case "ʸ√x":
                        result.Text = DanaProfessional.OperationsProfessional.Rt(value,int.Parse(result.Text)).ToString();
                        break;
                    case "xʸ":
                        result.Text = DanaProfessional.OperationsProfessional.Exp(value, int.Parse(result.Text)).ToString();
                        break;

                }
                operation_pressed = false;
            }
   

        }

        

        private void operator_pressed(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            
        }

     

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }

        
    


