using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutsDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnContentView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoContentView());
        }

        private async void btnFrame_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoFrame());
        }

        private async void btnScrollView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoScrollView());
        }

        private async void btnStackLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoStackLayout());
        }

        private async void btnGrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoGrid());
        }

        private async void btnAbsolutLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoAbsoluteLayout());
        }

        private async void btnRelativeLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoRelativeLayout());
        }
    }
}
