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
using UIControls = Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
using Windows.ApplicationModel.Activation;
// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Budget_planner
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        
        public MainPage()
        {
            this.InitializeComponent();            
        }

        private void A_KeyDown(object sender, KeyRoutedEventArgs e)
        {            
           Frame.Navigate(MyUserControl1);
            
        }





        /*
         * <UserControl>
                    <TextBlock FontSize="24" FontFamily="Arial Narrow" >Счет</TextBlock>
                </UserControl>
                <UserControl>
                    <TextBlock FontSize="24" FontFamily="Arial Narrow" >Новая операция</TextBlock>
                </UserControl>
                <UserControl>
                    <TextBlock FontSize="24" FontFamily="Arial Narrow" >История</TextBlock>
                </UserControl>
         */
    }


}
