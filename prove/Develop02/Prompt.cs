public class Prompt
{
    public Random _randomProducer = new Random();
    public List<string> _promptList = [
    "What are you most grateful for today?",
    "How are you feeling today, and what might be influencing your mood?",
    "What was the best part of your day, and why did it stand out?",
    "What was something difficult you faced today, and how did you handle it?",
    "What is one thing you learned or appreciated today?"];
    public int _selectPromptIndex;

    public string GeneratePrompt()
    {
        string prompt = "";
        _selectPromptIndex = _randomProducer.Next(0, _promptList.Count);
        prompt = _promptList[_selectPromptIndex];
        return prompt;
    }
}