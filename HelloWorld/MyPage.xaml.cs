using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MyPage : ContentPage
    {
        public string Name { get; set; } = "Helloz";
        public MyPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void Button_OnClicked(object sender, System.EventArgs e)
        {
            string text = MainEntry.Text;

            if (string.IsNullOrEmpty(text))
            {
                Name = "Hello Null";
            }
            else
            {
                Name = $"Hello {text}";
            }
            await DisplayAlert("Title", Name, "Ok");
        }

        async void Button_GoButtonScreen(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyPage3());
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            MainLabel.Text = MainEntry.Text;
        }
    }
}
