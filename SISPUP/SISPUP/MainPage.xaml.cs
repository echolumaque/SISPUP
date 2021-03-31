using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SISPUP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCLEAR_Clicked(object sender, EventArgs e)
        {
            entrySNO.Text = "";
            entryPW.Text = "";
            dateBDAY.Date = System.DateTime.Now;
        }

        private async void BtnLOGIN_ClickedAsync(object sender, EventArgs e)
        {
            //if (entrySNO.Text == "2019-14161-MN-0" && entryPW.Text == "koekoe" && dateBDAY.Date.Month == 4 && dateBDAY.Date.Day == 20 && dateBDAY.Date.Year == 2020)
            //{
                var tabs = new PUPTabs();
                await Navigation.PushModalAsync(tabs);
            //}
            //else
            //{
            //    await DisplayAlert("Notice", "Invalid credentials", "Okay");
            //}
        }
    }
}