using FireFly.Common.Enums;
using FireFly.Common.Helpers;
using FireFly.Contract.Authentication;
using FireFly.Service.Authentication;
using System.Windows;

namespace FireFly.UI
{
    public partial class Login : Window
    {
        private AuthenticationService authService;
        private Registration registration;
        private VideoPlayer videoPlayer;
        private AuthenticationHelper authHelper;

        public Login()
        {
            InitializeComponent();
            authService = new AuthenticationService();
            registration = new Registration();
            videoPlayer = new VideoPlayer();
            authHelper = new AuthenticationHelper();
        }

        private async void LoginButton(object sender, RoutedEventArgs e)
        {
            if (authHelper.IsEmailValid(textBoxEmail.Text))
            {
                var contract = new AuthenticationContract
                {
                    Email = textBoxEmail.Text,
                    Password = passwordBox.Password
                };

                var result = await authService.Login(contract);
                if (result)
                    videoPlayer.Show();
                else
                    errormessage.Text = EnumHelper.GetDescription<MessageEnum>(MessageEnum.ExistEmailOrPassword);
            }
            else
            {
                errormessage.Text = EnumHelper.GetDescription<MessageEnum>(MessageEnum.InvalidEmail);
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }

        }

        private void RegisterPageButton(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }
    }
}