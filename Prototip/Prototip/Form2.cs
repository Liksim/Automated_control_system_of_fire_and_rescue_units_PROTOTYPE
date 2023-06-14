using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototip
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 owner)
        {
            form1 = owner;
            
           
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            


            // Create and initialize a Button.
            Button button1 = new Button();

            button1.Text = ButtonName.Text;
            //button1.Click += ((Form1)Owner).textToSpeechButton_Click;

            // Set the button to return a value of OK when clicked.
            button1.DialogResult = DialogResult.OK;

            // Add the button to the form.
            //((Form1)Owner).Controls.Add(button1);

            form1.address.Text = ButtonName.Text;
        }
    }
}
