

class Job
{
    private string _companyName;

    private string _jobTitle;

    private int _startYear;

    private int _endYear;

    public Job(string companyName, string jobTitle , int startYear , int endYear)
    {
        _companyName = companyName;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void DisplayJob()
    {
        Console.WriteLine($"Job information: {_companyName}, Title: {_jobTitle}, Start: {_startYear}, End: {_endYear}");
    }
}