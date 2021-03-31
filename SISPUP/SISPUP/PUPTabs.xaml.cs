using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;




namespace SISPUP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PUPTabs : Xamarin.Forms.TabbedPage
    {
        public PUPTabs()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom).SetBarSelectedItemColor(Color.Maroon);
            labelDATE.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            labelDATE1.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            labelDATE2.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }
    }
}