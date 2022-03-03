using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace hpwand
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async Task BlinkAsync(Color cor) {

            lbackground.BackgroundColor = cor;
            await Task.Delay(70);
            lbackground.BackgroundColor = Color.Black;
            await Task.Delay(70);
            lbackground.BackgroundColor = cor;
            await Task.Delay(50);
            lbackground.BackgroundColor = Color.Black;
            await Task.Delay(50);
            lbackground.BackgroundColor = cor;
            await Task.Delay(80);
            lbackground.BackgroundColor = Color.Black;
        }

        void Button_Blue(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.CornflowerBlue);
        }
        void Button_Red(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.IndianRed);
        }
        void Button_Green(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.GreenYellow);
        }
        void Button_Yellow(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.LightGoldenrodYellow);
        }
        void Button_White(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.White);
        }
    }
}
