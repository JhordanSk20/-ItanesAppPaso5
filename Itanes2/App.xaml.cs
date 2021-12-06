using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Itanes2
{
    public partial class App : Application
    {
        //public App()
        //{
        //InitializeComponent();

        //MainPage = new MainPage();
        //}
        public App()
        {
            MainPage = new Views.BienvenidosPage
            {
                Content = new Label
                {

                    Text = "Bienvenidos a Itanes!",
                    TextColor = Color.White,
                    BackgroundColor = Color.Blue,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
