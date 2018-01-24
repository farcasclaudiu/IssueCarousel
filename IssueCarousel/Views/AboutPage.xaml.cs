using System;

using Xamarin.Forms;

namespace IssueCarousel
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            car1.IsVisible = true;
        }
    }
}
