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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        public OrderPage()
        {
            this.InitializeComponent();
            btAddToOrder.Click += Button_Click;
            btHome.Click += Button_Click;
            btSubmitOrder.Click += Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var bt = sender as Button;
            if (bt == btHome)
            {
                var page = new MainPage();
                this.Frame.Navigate(typeof(MainPage), page);
            } else if(bt == btAddToOrder)
            {
            } else if(bt == btSubmitOrder)
            {
            }
        }
    }

}
