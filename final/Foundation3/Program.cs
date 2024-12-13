using System;

class Program
{
    static void Main(string[] args)
    {
            // Create an Address object (shared for demonstration)
            Address commonAddress = new Address("123 Main St", "Springfield", "IL", "62704");

            // Create a Lecture event
            Lecture lecture = new Lecture(
                "Dr. Jane Doe",
                100,
                "Tech Talk",
                "A lecture on AI trends",
                2024, 12, 20, 18, 30,
                commonAddress
            );

            // Create a Reception event
            Reception reception = new Reception(
                "rsvp@example.com",
                "Annual Gala",
                "A formal evening event",
                2024, 12, 25, 19, 0,
                commonAddress
            );

            // Create an Outdoor Gathering event
            OutdoorGathering outdoorGathering = new OutdoorGathering(
                "Sunny",
                "Spring Picnic",
                "An outdoor community gathering",
                2024, 5, 15, 11, 0
            );
            Address outdoorAddress = new Address("Central Park", "New York", "NY", "10024", outdoorGathering);
            // Display details for each event

            // Lecture
            Console.WriteLine("Lecture Details:");
            Console.WriteLine(lecture.StandardDetails() + "\n");
            Console.WriteLine(lecture.FullDetails() + "\n");
            Console.WriteLine(lecture.ShortDescription() + "\n");
            Console.WriteLine();

            // Reception
            Console.WriteLine("Reception Details:");
            Console.WriteLine(reception.StandardDetails() + "\n");
            Console.WriteLine(reception.FullDetails() + "\n");
            Console.WriteLine(reception.ShortDescription() + "\n");
            Console.WriteLine();

            // Outdoor Gathering
            Console.WriteLine("Outdoor Gathering Details:");
            Console.WriteLine(outdoorGathering.StandardDetails() + "\n");
            Console.WriteLine(outdoorGathering.FullDetails() + "\n");
            Console.WriteLine(outdoorGathering.ShortDescription() + "\n");
    }
}