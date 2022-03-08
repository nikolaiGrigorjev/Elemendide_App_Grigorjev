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
    public partial class valgusfoor : ContentPage
    {
        Frame fr0, fr1, fr2;
        Button btn0, btn1;
        Label lbl0, lbl1, lbl2;
        public valgusfoor()
        {

            fr0 = new Frame
            {
                
                BorderColor = Color.FromRgb(20, 120, 255),
                CornerRadius = 20,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            fr1 = new Frame
            {

                BorderColor = Color.FromRgb(20, 120, 255),
                CornerRadius = 20,
                VerticalOptions = LayoutOptions.FillAndExpand
                
            };
            fr2 = new Frame
            {

                BorderColor = Color.FromRgb(20, 120, 255),
                CornerRadius = 20,
                
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            btn0 = new Button
            {
                Text = "sisse"
                

            };

            btn0.Clicked += Btn0_Clicked;


            btn1 = new Button
            {
                Text = "välja"

            };
            

            btn1.Clicked += Btn1_Clicked;

            lbl0 = new Label
            {
                
                
            };
            

            lbl1 = new Label
            {
                
            };

            lbl2 = new Label
            {
                

            };


            StackLayout st = new StackLayout
            {
                Children = {btn0,btn1,fr0,fr1,fr2,lbl0,lbl1,lbl2}
            };
            st.Children.Add(btn0);
            st.Children.Add(btn1);
            st.Children.Add(lbl0);
            st.Children.Add(lbl1);
            st.Children.Add(lbl2);
            st.Children.Add(fr1);
            st.Children.Add(fr2);
            
            Content = st;

        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            
            fr0.BackgroundColor = Color.Gray;
            fr1.BackgroundColor = Color.Gray;
            fr2.BackgroundColor = Color.Gray;
        }

        private async void Btn0_Clicked(object sender, EventArgs e)
        {
            while (true)
            {
                fr0.BackgroundColor = Color.Red;
                await Task.Delay(1000);
                fr0.BackgroundColor = Color.Gray;
                fr1.BackgroundColor = Color.Yellow;
                await Task.Delay(1000);
                fr1.BackgroundColor = Color.Gray;
                fr2.BackgroundColor = Color.Green;
                await Task.Delay(1000);
                fr2.BackgroundColor = Color.Gray;
            }
           

        }
    }
}