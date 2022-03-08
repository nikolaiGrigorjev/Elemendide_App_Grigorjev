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
    public partial class DateTime_Page : ContentPage
    {
        Label lbl;
        DatePicker dp;
        TimePicker tp;
        public DateTime_Page()
        {
            lbl = new Label { Text = "Vali mingi kuupäeva" };
            dp = new DatePicker
            {
                Format = "D",
                MinimumDate = DateTime.Now.AddDays(-5),
                MaximumDate = DateTime.Now.AddDays(5)
            };
            dp.DateSelected += Dp_DateSelected;
            tp = new TimePicker
            {
                Time = new TimeSpan(12, 0, 0)
            };
            tp.PropertyChanged += Tp_PropertyChanged;
            AbsoluteLayout abs = new AbsoluteLayout
            {
                Children={lbl,dp,tp}
            };

            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0.1, 0.2, 100, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(dp, new Rectangle(0.1, 0.2, 100, 50));
            AbsoluteLayout.SetLayoutFlags(dp, AbsoluteLayoutFlags.PositionProportional);


            Content = abs;


        }
        

        private void Tp_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lbl.Text = "Oli valitud aeg:" + tp.Time;
            
            
            
        }

        private void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            lbl.Text = "Oli valitud" + e.NewDate.ToString("G");
        }


    }
}
