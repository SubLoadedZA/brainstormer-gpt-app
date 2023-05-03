using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Replace with your OpenAI API key
        var apiKey = "";
        var chatGPTBrainstormer = new ChatGPTBrainstormer(apiKey);

        Console.WriteLine("Enter a topic to generate ideas:");
        var topic = Console.ReadLine();

        var ideas = await chatGPTBrainstormer.GenerateIdeasAsync(topic);

        Console.WriteLine("\nGenerated ideas:");
        foreach (var idea in ideas)
        {
            Console.WriteLine("- " + idea);
        }
    }
}