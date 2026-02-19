using System.ComponentModel;

public class Scripture
{
    private string _scripture;
    Word newWord = new Word();
    private List<Word> words = new List<Word>();
    Random rand1 = new Random();
    public void ScriptureToWords(string text)
    {
        string[] toWords = text.Split(' ', ',', ';',':','.','*','(',')');
        foreach (string x in toWords)
        {
            Word w = new Word();
            w.SetWord(x);
            words.Add(w);
        }

    }
    public void HideWords()
    {
        int wordCount = words.Count();
        int amountHidden = 0;
        int visibleCount = 0;
        foreach (Word w in words)
        {
            if (!w.GetHiddenStatus())
            {
                visibleCount++;
            }
        }
        int toHide = Math.Min(3, visibleCount);
        
        while (amountHidden < toHide)
        {
            int random = rand1.Next(0, wordCount);
            if (!words[random].GetHiddenStatus())
            {
                words[random].HideWord();
                amountHidden++;
            }
        }
    }
    public string GetDisplayScripture()
    {
        string finalScripture = "";
        for (int i = 0; i < words.Count; i++)
        {
            finalScripture += " ";
            finalScripture += words[i].GetDisplayWord();
        }
        return finalScripture.Trim();
    }
    public bool CheckAllWordsHidden()
    {
        foreach (Word w in words)
        {
            if (!w.GetHiddenStatus())
            {
                return false;
            }
        }
        return true;
    }
}