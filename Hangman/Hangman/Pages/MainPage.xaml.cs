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
            /*
              Website: stackoverflow
              Title: How to terminate a Xamarin application?
              url: https://stackoverflow.com/questions/29257929/how-to-terminate-a-xamarin-application
              */
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void StartGame_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LevelPage());
        }



    }
}
