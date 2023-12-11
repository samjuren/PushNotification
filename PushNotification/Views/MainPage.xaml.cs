using OneSignalSDK.DotNet;

namespace PushNotification
{
    public partial class MainPage : ContentPage
    {
        private Guid _externalId = Guid.Parse(input: "a059805e-f88e-4140-baf0-637d54a42ad8");

        public MainPage()
        {
            InitializeComponent();
        }
        public void AddExternalId()
        {
            OneSignal.Login(externalId: _externalId.ToString());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            AddExternalId();
        }
    }
}
