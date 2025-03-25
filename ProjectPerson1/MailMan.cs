class MailMan : Person
{
    private string _mail;
    public MailMan(string mail, string firstname, string lastname, int age)
    : base(firstname, lastname, age)
    {
        _mail = mail;
    }

    public string DisplayMailManInfo()
    {
        return $"{_mail}, Info: {DisplayPersonInfo()}";
    }
}