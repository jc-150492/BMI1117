using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double h = Double.Parse(this.He.Text);
            Double w = Double.Parse(this.We.Text);


            h = h / 100;

            double bmi = w / (h * h);

            String st;
            if (bmi < 18.5)
            {
                st = "痩せています。";
            }
            else if (bmi < 25)
            {
                st = "標準体重です";
            }
            else if (bmi < 30)
            {
                st = "太り気味です";
            }
            else if (bmi < 35)
            {
                st = "太っています。";
            }
            else
            {
                st = "太りすぎです。";
            }

            DisplayAlert("BIM数値", st, "OK");
        }
    }
}
