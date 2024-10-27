using System.Linq;
public class Scripture
{
    private List<Word> _quote = new List<Word>();
    private Reference _reference;

    public Scripture(string quote, Reference reference)
    {
        //splits the string of the scripture quote by spaces and
        //creates word objects from them, then adds them to the list
        string[] strings= quote.Split(" ");
        foreach (string s in strings)
        {
            Word word = new Word(s);
            _quote.Add(word);
        }
        //adds the reference to the scripture object
        _reference = reference;
    }
    public Scripture((string, Reference) gotten)
    {
        string[] strings= gotten.Item1.Split(" ");
        foreach (string s in strings)
        {
            Word word = new Word(s);
            _quote.Add(word);
        }
        //adds the reference to the scripture object
        _reference = gotten.Item2;
    }
    public string Out()
    {
        string output;
        output = _reference.Out() + " ";
        foreach (Word word in _quote)
        {
            output = output + word.Out() + " ";
        }
        return output;
    }
    public bool Hide(int x)
    {
        Random random= new Random();

        List<Word> hidable = _quote.Where(obj => !obj.IsHidden()).ToList(); //filters out hidden words
        int actual = Math.Min(x, hidable.Count); //makes sure this function wont try to hide more words than it can
        hidable = hidable.OrderBy(obj => random.Next()).ToList();
        if (actual == 0)
        {
            return true;
        }
        for (int i = 0; i < actual; i++)
        {
            hidable[i].Hide();
        }
        return false;
    }

    public static (string, Reference) Get(string path)
    {
        Random random = new Random();
        string[] lines = System.IO.File.ReadAllLines(path);
        string line = lines[random.Next(lines.Length)];
        string[] refarray = line.Split("/")[0].Split(" ");
        Reference reference= new Reference(refarray[0], refarray[1], refarray[2]);
        if (refarray.Length > 3)
        {
            reference.SetEnd(refarray[3]);
        }
        return (line.Split("/")[1], reference);
    }
}