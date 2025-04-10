class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("west Utahvill", "Utahvill", "NewMexico", "USA");
        Lecture lecture = new Lecture("Baking Lecture", "Come learn to bake!", "September, 6", "6:30 pm", address1, "Rob lumpner", 60);

        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();
        lecture.DisplayFullDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();
        Console.WriteLine();

        Address address2 = new Address("sevro St", "Iopall", "New Jersey", "USA");
        Reception reception = new Reception("Good Work!", "Come to the reception!", "June, 21", "12:00 pm", address2, "Sampleemail@Thisisfake.com");

        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();
        reception.DisplayShortDescription();
        Console.WriteLine();

        Address address3 = new Address("Junk Road", "Dirtison", "missouri", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Party", "We are having Cake And a waterslide.", "July 1", "2:45 pm", address3, "The weather will be Sunny with light winds.");

        Console.WriteLine(outdoorGathering.StandardDetails());
        Console.WriteLine();
        outdoorGathering.DisplayFullDetails();
        Console.WriteLine();
        outdoorGathering.DisplayShortDescription();
        Console.WriteLine();

    }
}