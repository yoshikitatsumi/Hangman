using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidHangman.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

        }
        private void Edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructionPage());
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }
        private void Create_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DBPage());
        }

        private void Select_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExitPage());
        }

        private void Avatar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LevelPage());
        }
    }
}