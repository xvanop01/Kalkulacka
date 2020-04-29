
/*********************
* IVS projekt2
* 27.4.2020
* team leader: xvanop1
* xstefe11
*********************/

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
        bool number_pressed = false;//number has not been pressed yet
        bool operation_pressed = false; //no operator had been pressed yet

        /*
         @brief intializes components of the form
         */
        public Form1()
        {
            InitializeComponent();
        }



        /*
         @brief loads the form
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }


       

        /**
         @brief deletes everything and set result window to 0
         @param sender
         @param e
         */
        private void buttonce_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }




        private void buttontool_Click(object sender, EventArgs e)
        {

        }



        /**
        
            @brief prints out numbers in result.Text 
           @param sender
           @param e 
             */
        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operation_pressed == true)
                result.Text = "";
            Button b = (Button)sender;
            result.Text = result.Text + b.Text; 

        }


        /**
         * @brief deletes everything on the screen
           @param sender
           @param e 
        */
        private void buttonc_click(object sender, EventArgs e)
        {
            result.Text = "0";

        }

        /**
         @brief gives absolute value of given number 
         @param sender
         @param e 
             */
        private void button_abs_Click(object sender, EventArgs e)//absolute value 
        {
            if (result.Text == "0")
                result.Text = "ERROR";
            else
            {
                value = DanaProfessional.OperationsProfessional.Abs(double.Parse(result.Text));
                result.Text = value.ToString();
            }
        }

        /**
        @brief counts the factorial of given number
        @note number has to be positive integer    
             */
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

        /**
            @brief Perfroms all the operations that use 2 numbers
            @param sender
            @param e
        */
     private void equals_Click(object sender, EventArgs e)
        {
            if(operation_pressed)
            {


                switch (operation)//determing which opertion to perform
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
                        if(value<0 || (value%2==0 && int.Parse(result.Text)<0)) 
                            result.Text=("ERROR");
                        else
                        result.Text = DanaProfessional.OperationsProfessional.Rt(value,int.Parse(result.Text)).ToString();
                        break;
                    case "xʸ":
                        result.Text = DanaProfessional.OperationsProfessional.Exp(value, int.Parse(result.Text)).ToString();
                        break;

                }
                operation_pressed = false;
            }
   

        }

        /**
        @brief when operator  pressed parses the number pressed previously
        @param sender
        @param e   
        */
        private void operator_pressed(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            
        }
    }
    }

        
    


