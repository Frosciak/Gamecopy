using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Game
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class stats : ContentPage
    {
        public stats()
        {
            InitializeComponent();
        }

        private void EXIT_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void Dodajsile_OnClicked(object sender, EventArgs e)
        {
            
        }
    }
}