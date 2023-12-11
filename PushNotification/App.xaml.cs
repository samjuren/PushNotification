using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.Debug;

namespace PushNotification
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            OneSignal.Debug.LogLevel = LogLevel.VERBOSE;
            OneSignal.Initialize(appId: "SUA CHAVE");
            OneSignal.Notifications.RequestPermissionAsync(fallbackToSettings: true);

            MainPage = new AppShell();
        }
    }
}


//MINHA CHAVE: a059805e-f88e-4140-baf0-637d54a42ad8