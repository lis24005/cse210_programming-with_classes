using System.Security.Cryptography.X509Certificates;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseInitial;
    private int? _verseFinal;

    public void SetReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseInitial = verse;
        _verseFinal = null;
    }
    public void SetReference(string book, int chapter, int verse1, int verse2)
    {
        _book = book;
        _chapter = chapter;
        _verseInitial = verse1;
        _verseFinal = verse2;
    }
    public string GetDisplayReference()
    {
        if (_verseFinal == null)
        {
            return $"{_book} {_chapter}: {_verseInitial}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verseInitial}-{_verseFinal}";
        }
    }
}
