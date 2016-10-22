using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace UITestSample2
{
    public class App : Application
    {
        public App()
        {
            var hellowWorld = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions  = LayoutOptions.Center
                
            };

            var hellowBtn = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                Text = "Say Hello",
                ClassId = "btn"
            };

            hellowBtn.Clicked += (sender, args) =>
            {
                hellowWorld.Text = "Hello World!!";
            };
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                       hellowWorld,
                       hellowBtn
                    }
                }
            };
        }

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
    }
}
