using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using SlideOverKit;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DebugPanelTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DebugPanelButton : PopupPage
    {
        public DebugPanelButton()
        {
            InitializeComponent();
            BackgroundColor = Color.Transparent;
            BackgroundInputTransparent = true;
            CloseWhenBackgroundIsClicked = false;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        public void Open_Tapped(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new DebugPanelPopup());
        }
    }
}