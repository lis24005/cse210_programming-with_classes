using System;
using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string PromptLine;
    public string Response;
    public string Date;

    public void SetNewEntry()
    {
        Prompt gen_prompt = new Prompt();
        PromptLine = gen_prompt.GeneratePrompt();
        Console.WriteLine(PromptLine);
        Response = Console.ReadLine();
        Date = DateTime.Now.Year.ToString();

    }

    
}

