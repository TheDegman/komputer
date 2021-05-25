using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace komputer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        //public static string email;
        //public static string lozinka;
        
        public SignUp()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("komputer.Images.LOGO.png");
        }

        private async void signUp_Clicked(object sender, EventArgs e)
        {
            //EMAIL.Text = email;
            //LOZINKA1.Text = lozinka;
            
            await Navigation.PushAsync(new MainPage(EMAIL.Text, LOZINKA1.Text));


        }
    }
}