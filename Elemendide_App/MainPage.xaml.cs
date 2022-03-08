using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            StackLayout st = new StackLayout();
            Button Ent_btn = new Button()
            {
                Text = "Entry",
                BackgroundColor = Color.LightGreen,
            };

            Button Timer_btn = new Button()
            {
                Text = "Timer",
                BackgroundColor = Color.LightGreen,
            };
            Button cliker = new Button()
            {
                Text = "Clicker",
                BackgroundColor = Color.LightGreen,
            };
            Button Date_btn = new Button
            {
                Text = "Date/Time",
                BackgroundColor = Color.Fuchsia
            };

            Button Frame_btn = new Button
            {
                Text = "Frame",
                BackgroundColor = Color.IndianRed
            };
            Button Image_btn = new Button
            {
                Text = "Image",
                BackgroundColor = Color.IndianRed
            };
            Button valgusfoor_btn = new Button
            {
                Text = "Valgusfoor",
                BackgroundColor = Color.IndianRed
            };
            Button xo_btn = new Button
            {
                Text = "Krestik Nolik",
                BackgroundColor = Color.IndianRed
            };
            Button rgb_btn = new Button
            {
                Text = "RGB",
                BackgroundColor = Color.IndianRed
            };



            st.Children.Add(Ent_btn);
            st.Children.Add(Timer_btn);
            st.Children.Add(cliker);
            st.Children.Add(Frame_btn);
            st.Children.Add(Image_btn);
            st.Children.Add(Date_btn);
            st.Children.Add(rgb_btn);
            st.Children.Add(xo_btn);
            st.Children.Add(valgusfoor_btn);
            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            cliker.Clicked += Cliker_Clicked;
            Frame_btn.Clicked += Frame_btn_Clicked;
            Image_btn.Clicked += Image_btn_Clicked;
            xo_btn.Clicked += xo_btn_Clicked;
            rgb_btn.Clicked += Rgb_btn_Clicked;
            valgusfoor_btn.Clicked += Valgusfoor_btn_Clicked;
        }

        private async void Rgb_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RGB());
        }

        private async void Valgusfoor_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new valgusfoor());
        }

        private async void Image_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_page());
        }

        private async void Frame_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Frame_Page());
        }

        private async void Cliker_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new cliker());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimerPage());
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ent_page());
        }
        private async void Date_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTime_Page());
        }
        private async void SS_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ent_page());
        }
        private async void xo_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new xo());
        }
    }
    
}
