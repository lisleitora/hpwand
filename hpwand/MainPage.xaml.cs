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

        async Task BlinkAsync(Color cor ,String nome,int size = 60) {
            lnome.Text = nome;
            lnome.FontSize = size;
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
            BlinkAsync(Color.CornflowerBlue,"Patronus");
        }
        void Button_Red(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.IndianRed,"Expelliarmus");
        }
        void Button_Green(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.GreenYellow,"Avada Kedavra");
        }
        void Button_Yellow(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.LightGoldenrodYellow,"Wingardium Leviosa",40);
        }
        void Button_White(System.Object sender, System.EventArgs e)
        {
            BlinkAsync(Color.White,"Lumos");
        }
    }
}
