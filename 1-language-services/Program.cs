using Azure;
using Azure.AI.TextAnalytics;
using System;

namespace _1_language_services;

class Program
{
    private static readonly AzureKeyCredential credentials = new AzureKeyCredential("<KEY>");
    private static readonly Uri endpoint = new Uri("https://<servicename>.cognitiveservices.azure.com/");
    static void Main(string[] args)
    {
        var client = new TextAnalyticsClient(endpoint, credentials);
        SentimentAnalysisExample(client);
        Console.ReadKey();
    }

    static void SentimentAnalysisExample(TextAnalyticsClient client) {
        string inputText = "hello there how are things my friend!!!??";
        DocumentSentiment docSentiment = client.AnalyzeSentiment(inputText);
        Console.WriteLine($"Doc sentiment: {docSentiment.Sentiment}");
    }
}
