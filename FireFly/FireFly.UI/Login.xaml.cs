using FireFly.Contract.Authentication;
using FireFly.Service.Authentication;
using System.Text.RegularExpressions;
using System.Windows;

namespace FireFly.UI
{
    public partial class Login : Window
    {
        AuthenticationService authService;

        public Login()
        {
            InitializeComponent();
            authService = new AuthenticationService();
        }

        Registration registration = new Registration();
        VideoPlayer videoPlayer = new VideoPlayer();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                var contract = new AuthenticationContract { Email = textBoxEmail.Text, Password = passwordBox1.Password };
                var result = authService.Login(contract);

                if (result)
                    videoPlayer.Show();
                else
                    errormessage.Text = "Sorry! Please enter existing email/password.";
            }
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }
    }
}