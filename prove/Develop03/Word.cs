
public class Word
{
    private string _word;
    private bool _hidden;

    public void SetWord(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void HideWord()
    {
        _hidden = true;
    }
    public bool GetHiddenStatus()
    {
        return _hidden;
    }

    public string GetDisplayWord()
    {
        if (_hidden)
        {
            string hiddenWord = "";
            for (int i = 0; i < _word.Length; i++)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else
        {
            return _word;
        }
    }
}