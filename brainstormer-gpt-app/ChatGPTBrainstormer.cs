using RestSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ChatGPTBrainstormer
{
    private string _apiKey;
    private const string ApiEndpoint = "https://api.openai.com/v1/engines/text-davinci-002/completions";

    public ChatGPTBrainstormer(string apiKey)
    {
        _apiKey = apiKey;
    }

    public async Task<List<string>> GenerateIdeasAsync(string topic, int ideaCount = 5)
    {
        var client = new RestClient(ApiEndpoint);
        var request = new RestRequest();

        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Authorization", $"Bearer {_apiKey}");

        var prompt = $"Generate {ideaCount} unique and creative ideas related to {topic}:";
        request.AddJsonBody(new
        {
            prompt = prompt,
            n = ideaCount,
            max_tokens = 50
        });

        var response = await client.ExecuteAsync(request, Method.Post);

        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            throw new ApplicationException($"Failed to generate ideas. API response: {response.Content}");
        }

        var responseObject = JObject.Parse(response.Content);
        var choices = responseObject["choices"];

        var ideas = new List<string>();
        foreach (var choice in choices)
        {
            ideas.Add(choice["text"].ToString().Trim());
        }

        return ideas;
    }
}