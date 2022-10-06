namespace Core.Security.Enums;

public enum AuthenticatorType
{
    None = 0, // Simple email & password authentication
    Email = 1, // From any email platform authentication
    Otp = 2 // From various software based 2-factor authentication
}