using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FirstApp
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
            new Label {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Welcome to Xamarin Forms!"
                }
              }
            };

            MainPage = new ContentPage
            {
                Content = layout
            };

            
            /// Adding a button
            Button button = new Button
            {
                Text = "Click Me"
            };

            button.Clicked += async (s, e) =>
            {
                await MainPage.DisplayAlert("Alert", "You Clicked me", "OK");
            };

            layout.Children.Add(button);

            var layout1 = new StackLayout
            {
                Orientation = StackOrientation.Vertical
            };

            layout1.Children.Add(new Label { Text = "Enter your name: " });
            layout1.Children.Add(new Entry());
            layout1.Children.Add(new Button { Text = "OK"});


            /*
            protected override void OnStart()
            {
                // Handle when your app starts
            }

            protected override void OnSleep()
            {
                // Handle when your app sleeps
            }

            protected override void OnResume()
            {
                // Handle when your app resumes
            }
            */
        }
    }
}
