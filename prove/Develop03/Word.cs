//this class stores one word, a bool value whether the word is hidden, and returns the word or underscores if hidden == true
public class Word
{
    private string _word;
    private string _hiddenword;
    private bool _hidden = false;
    public Word(string word)
    {
        _word = word;
    }
    public void Hide(bool hidden = true)
    {
        //sets hidden to true and hiddenword to a string of underscores equal in length to the original word
        _hidden = hidden;
        for (int i = 0; i < _word.Length; i++)
            {
                _hiddenword = _hiddenword + "_";
            }
    }

    public bool IsHidden()
    {
        return _hidden;
    }
    public string Out()
    {
        if (_hidden)
        {
            return _hiddenword;
        }
        else
        {
            return _word;
        }
    }
}