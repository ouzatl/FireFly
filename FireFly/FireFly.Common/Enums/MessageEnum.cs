using System.ComponentModel;

namespace FireFly.Common.Enums
{
    public enum MessageEnum
    {
        [Description("Sorry! Please enter existing email/password.")]
        ExistEmailOrPassword,
        [Description("Enter a valid email.")]
        InvalidEmail,
        [Description("Enter password.")]
        EnterPassword,
        [Description("Confirm password must be same as password.")]
        InvalidPasswordConfirm,
        [Description("Sorry!Please enter different email.")]
        UnSuccessfulRegister,
    }
}
