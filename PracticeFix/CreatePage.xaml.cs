using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticeFix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePage : ContentPage
    {
        public CreatePage()
        {
            InitializeComponent();
        }
        void canael_click(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MainPage());
        }
        void confirm_click(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}