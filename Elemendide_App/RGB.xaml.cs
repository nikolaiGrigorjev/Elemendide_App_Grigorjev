using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RGB : ContentPage
    {
        Label lbl;
        Label lbl2;
        Label lbl3;
        
        Slider sld;
        Slider sld2;
        Slider sld3;
        
        
         
        Button btn;
        BoxView box;

        public RGB()
        {
            lbl = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            box = new BoxView()
            {
                Color = Color.Black,
                WidthRequest = 400,
                HeightRequest = 350,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            sld = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 30,

                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Red

            };
            sld.ValueChanged += OnSlideValueChanged;


            sld2 = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 30,

                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Green
            };
            sld2.ValueChanged += OnSlideValueChanged;
            

            sld3 = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 30,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Blue
            };
            sld3.ValueChanged += OnSlideValueChanged;




            btn = new Button
            {
                Text = "random",
            };
            btn.Clicked += Btn_Clicked;




            StackLayout st = new StackLayout { Children = { box, sld, lbl, sld2, lbl2, sld3, lbl3, btn } };
            Content = st;



        }

       

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Random r = new Random();
            box.Color = Color.FromRgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));


        }

        private void OnSlideValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == sld)
            {
                lbl.Text = String.Format("Red = {0:X2}", (int)e.NewValue);
            }
            else if (sender == sld2)
            {
                lbl2.Text = String.Format("Green = {0:X2}", (int)e.NewValue);
            }
            else if (sender == sld3)
            {
                lbl3.Text = String.Format("Blue = {0:X2}", (int)e.NewValue);
            }



            box.Color = Color.FromRgb((int)sld.Value,
                                      (int)sld2.Value,
                                      (int)sld3.Value);
        }
    }
}