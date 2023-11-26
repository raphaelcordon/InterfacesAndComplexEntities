namespace Project.Entity.People;

public class EmailAddress
{
    public EmailAddress(string email)
    {
        Email = email;
    }
    private string _emailAddress;

    public string Email
    {
        get => _emailAddress;
        set
        {
            if (value == null)
            {
                throw new FormatException("Email cannot be null");
            }

            if (!value.Contains('@'))
            {
                throw new FormatException("Format not compatible with email address");
            }

            _emailAddress = value;
        }
    }
}