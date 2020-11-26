using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hangman
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        // Setting public ints.
        public int score = 0;
        public int gem = 0;

        public ProfilePage()
        {
            InitializeComponent();

            //setting Avatar as 1, gender 1=male, 2=female.
            int gender = 1;
            Image avatar = new Image
            {
                Source = "Avatar" + gender + ".jpg"
            };
            //setting Labels of Player Name and User Name as PName and UName, Score and Gems as UScore at 0 and UGems at 0.

            Label PName = new Label
            {
                Text = "",
                FontSize = 15,
                TextColor = Color.DarkBlue
            };

            Label UName = new Label
            {
                Text = "",
                FontSize = 15,
                TextColor = Color.DarkBlue
            };

            Label UScore = new Label
            {
                Text = "Score: " + Convert.ToString(score),
                FontSize = 20,
                TextColor = Color.Orange
            };

            Label UGems = new Label
            {
                Text = "Gems: " + Convert.ToString(gem),
                FontSize = 20,
                TextColor = Color.Green
            };

            //Buttons of Save and Delete as btnSave and btnDelete. 
            Button btnSave = new Button
            {
                Text = "Save",
                TextColor = Color.Blue
            };
            btnSave.Clicked += Save_Clicked;
            Button btnDelete = new Button
            {
                Text = "Delete",
                TextColor = Color.Red
            };
            btnDelete.Clicked += Delete_Clicked;

            Content = new StackLayout
            {
                Children =
            {
                avatar,
                new StackLayout
                {
                    HorizontalOptions = LayoutOptions.Center,
                    Children =
                    {
                        PName,
                        UName,
                        UScore,
                        UGems,
                        btnSave,
                        btnDelete,
                    }
                }
            }
            };

        }

        // Button navigations
        private void Save_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new SavePage());
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new DeletePage());
        }

    }
}