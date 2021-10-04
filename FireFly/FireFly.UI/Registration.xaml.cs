using FireFly.Common.Enums;
using FireFly.Common.Helpers;
using FireFly.Contract.Authentication;
using FireFly.Service.Authentication;
using System.Windows;

namespace FireFly.UI
{
    public partial class Registration : Window
    {
        private AuthenticationService authService;
        private VideoPlayer videoPlayer;
        private AuthenticationHelper authHelper;

        public Registration()
        {
            InitializeComponent();
            authService = new AuthenticationService();
            videoPlayer = new VideoPlayer();
            authHelper = new AuthenticationHelper();
        }


        private void LoginPageButton(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
        private void ResetButton(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            textBoxEmail.Text = string.Empty;
            passwordBox.Password = string.Empty;
            passwordBoxConfirm.Password = string.Empty;
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void SubmitButton(object sender, RoutedEventArgs e)
        {

            if (!authHelper.IsEmailValid(textBoxEmail.Text))
            {
                errormessage.Text = EnumHelper.GetDescription<MessageEnum>(MessageEnum.InvalidEmail);
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                if (passwordBox.Password.Length == 0)
                {
                    errormessage.Text = EnumHelper.GetDescription<MessageEnum>(MessageEnum.EnterPassword);
                    passwordBox.Focus();
                }
                else if (passwordBoxConfirm.Password.Length == 0)
                {
                    errormessage.Text = EnumHelper.GetDescription<MessageEnum>(MessageEnum.InvalidEmail);
                    passwordBoxConfirm.Focus();
                }
                else if (passwordBox.Password != passwordBoxConfirm.Password)
                {
                    errormessage.Text = EnumHelper.GetDescription<MessageEnum>(MessageEnum.InvalidPasswordConfirm);
                    passwordBoxConfirm.Focus();
                }
                else
                {
                    var contract = new AuthenticationContract {
                        Email = textBoxEmail.Text,
                        Password = passwordBox.Password
                    };

                    var result = await authService.Register(contract);

                    if (result)
                        videoPlayer.Show();
                    else
                        errormessage.Text = EnumHelper.GetDescription<MessageEnum>(MessageEnum.UnSuccessfulRegister);
                }
            }
        }
    }
}