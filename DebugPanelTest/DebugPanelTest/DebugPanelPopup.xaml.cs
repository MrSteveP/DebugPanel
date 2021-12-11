using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DebugPanelTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DebugPanelPopup : PopupPage
    {
        public DebugPanelPopup()
        {
            InitializeComponent();
            PageUp.TranslationY = DeviceDisplay.MainDisplayInfo.Height;
            Open_Tapped(this, new EventArgs());

            DebugOutput.Text = string.Join(Environment.NewLine, App.DebugLog);
            App.DebugLog.CollectionChanged += DebugLog_CollectionChanged;
        }

        private void DebugLog_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            DebugOutput.Text = string.Join(Environment.NewLine, App.DebugLog);
        }

        private void Clear_Tapped(object sender, System.EventArgs e)
        {
            App.DebugLog.Clear();
        }

        public async void Close_Tapped(object sender, System.EventArgs e)
        {
            await PageUp.TranslateTo(0, DeviceDisplay.MainDisplayInfo.Height, 500, Easing.SinIn);
            await PopupNavigation.Instance.PopAsync();
        }

        public async void Open_Tapped(object sender, System.EventArgs e)
        {
            await PageUp.TranslateTo(0, 0, 500, Easing.SinIn);
        }
    }
}