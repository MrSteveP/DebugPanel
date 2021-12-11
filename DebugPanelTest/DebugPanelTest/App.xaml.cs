using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DebugPanelTest
{
    public partial class App : Application
    {
        public static ObservableCollection<string> DebugLog { get; set; } = new ObservableCollection<string>();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

            AddDebugLog("");
            AddDebugLog("Testing testing" + Environment.NewLine);
            AddDebugLog("Testing testing 123" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
            AddDebugLog("Testing testing 456" + Environment.NewLine);
        }

        public static void AddDebugLog(string log)
        {
            if (DebugLog.Count >= 20)
            {
                DebugLog.RemoveAt(0);
            }

            DebugLog.Add(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + Environment.NewLine + log);
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
