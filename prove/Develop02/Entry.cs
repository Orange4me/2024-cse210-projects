using System;

class Entry;
{
    private string file;

    private string date;

    private string prompt;

    private string entri;

    public Entry (string fileName, string todaysDate, string randomPrompt, string userEntri)
    {
        file = fileName;
        date = todaysDate;
        prompt = randomPrompt;
        entri = userEntri; 
    }

    public void Display()
    {
        Console.WriteLine($"{date} - {prompt} \n{entri}") 
    }
    // public string storeEntri()
    // {
    //     return $"{file} -- {date} -- {prompt} -- {entri}"
    // }
    

}