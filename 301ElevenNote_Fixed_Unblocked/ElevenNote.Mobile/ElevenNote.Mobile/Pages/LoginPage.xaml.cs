using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ElevenNote.Mobile.Pages
{
    public partial class LoginPage : ContentPage
    {
        #region Properties

        public string Username { get; set; }
        public string Password { get; set; }

        #endregion

        #region Constructor

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        #endregion

        #region Event Handlers

        protected async void btnLogin_Clicked(Object sender, EventArgs args)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                await DisplayAlert("Whoops", "You must enter both a username and password.", "OK");
            }
            else
            {
                // Attempt to log them in.
                var apiKey = App.NoteServiceProvider.Login(Username, Password);
                if (!string.IsNullOrEmpty(apiKey))
                {
                    App.ApiKey = apiKey;
                    App.Notes = App.NoteServiceProvider.GetAll(App.ApiKey);
                    await DisplayAlert("Cool", "We're good here.", "OK");

                    //Navigation.PushAsync(new NavigationPage(new NotesView()), true);
                }
                else
                {
                    await DisplayAlert("Whoops", "Login failed.", "Bummer");
                }
            }
        }

        #endregion

    }
}
