using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting....");
            //Program app = new Program();
            Form1 form = new Form1();
            Application.Run(form);
            
        }

        public Program() {
            // MessageBox.Show("Message", "Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // read string from keyboard to get the weight in kilo grams
            Console.WriteLine("Enter the value of weight in kilograms (kg): ");
            string w = Console.ReadLine();

            // parse the value of weight
            float fw = Single.Parse(w);

            // read string from keyboard to get the height in meters
            Console.WriteLine("Enter the value of height in meters (m): ");
            string h = Console.ReadLine();

            // parse the value of weight
            float fh = Single.Parse(h);
            
            // calculate and return the value of the bmi
            float bmi = fw / (fh * fh);
            string sbmi = bmi.ToString();

            // console log a response to show the type of weight range.
            Console.WriteLine("The BMI value is: " +  sbmi);
        }
    }
}
