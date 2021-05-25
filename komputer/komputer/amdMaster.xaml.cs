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
    public partial class amdMaster : MasterDetailPage
    {
        public amdMaster()
        {
            InitializeComponent();
        }
        public void skola(object sender, EventArgs e)

        {

            Detail = new NavigationPage(new CPU());

            IsPresented = false; //objasniti značenje?

        }

        private void hoby(object sender, EventArgs e)

        {

            Detail = new NavigationPage(new GPU());

            IsPresented = false;

        }

        private void faks(object sender, EventArgs e)

        {

            Detail = new NavigationPage(new RAM());

            IsPresented = false;

        }
    }
}