using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicphotoeditor
{   
    public partial class Form1 : Form
    {
        private string TAG;
        public Form1()
        {
            InitializeComponent();
            TAG = GetType().Name;
        }

        private void onClick(object sender, EventArgs e)
        {
            //Do something when button is clicked
            Console.WriteLine(TAG + ": onClick()");
        }
    }
}
