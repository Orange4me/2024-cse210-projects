public class static PromptGenerator
{
    List<string> randomPro = {
        "What was the highlight of your day?",
        "What are 3 things you are content about with how your week went?",
        "What set your day on the right track? When did this happen?",
        "What are you looking forward to for this week?",
        "Did you contribute/achieve any goals today? Which ones and how?"
    }

    Randomizer choice = new Randomizer();
    int index = choice.Next(randomPro.Count);
    string randomPrompt = randomPro[index];
    
}