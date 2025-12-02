namespace Learning_AdvancedCSharpStudies.IndexerStudies;

public class NoteBooks(int numOfNotebooks)
{
    private readonly string[] _notebooks = new string[numOfNotebooks];

    public string this[int index]
    {
        get => _notebooks[index];
        set => _notebooks[index] = value;
    }
}