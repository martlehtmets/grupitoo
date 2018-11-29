using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace grupitoo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            load_items();
        }

        private void load_items()
        {
            Frame1.Navigate(typeof(Pealeht));
        }

        private void navigationview1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void navigationview1_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            string alamleht =  args.InvokedItem.ToString();
            if (alamleht != null)
            {
                switch (alamleht)
                {

                    case "Pealeht":
                        Frame1.Navigate(typeof(Pealeht));
                        break;

                    case "Tunniplaan":
                        Frame1.Navigate(typeof(Tunniplaan));
                        break;

                    case "Kontakt":
                        Frame1.Navigate(typeof(kontakt));
                        break;


                    case "Järelvastamine":
                        Frame1.Navigate(typeof(järelvastamine));
                        break;

                    case "Bussiajad":
                        Frame1.Navigate(typeof(bussiajad));
                        break;
                }
            }
        }
    }
}