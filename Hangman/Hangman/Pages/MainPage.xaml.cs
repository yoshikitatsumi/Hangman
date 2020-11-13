using AndroidHangman.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndroidHangman
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private void Instruction_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructionPage());
        }

        private void Profile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }
        private void DB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DBPage());
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExitPage());
        }

        private void StartGame_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LevelPage());
        }



    }
}
