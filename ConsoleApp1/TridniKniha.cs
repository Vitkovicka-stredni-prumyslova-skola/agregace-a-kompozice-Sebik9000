namespace AgregaceAKompozice
{
    public class TridniKniha
{
    private readonly Dictionary<Student, List<ZaznamDochazky>> _dochazka;

    public TridniKniha()
    {
        _dochazka = new Dictionary<Student, List<ZaznamDochazky>>();
    }


    public void ZapisDochazku(Student s, DateOnly datum, bool pritomen)
    {
        if(s == null) throw new ArgumentNullException(nameof(s));

        if (!_dochazka.ContainsKey(s))
        {
            _dochazka[s] = new List<ZaznamDochazky>();
        }
        _dochazka[s].Add(new ZaznamDochazky(datum, pritomen));
    }

    public void VypisDochazku(Student s)
    {
        if(s == null) throw new ArgumentNullException(nameof(s));

        if (!_dochazka.ContainsKey(s) || _dochazka[s].Count == 0) 
        {
            Console.WriteLine("Žádné záznamy.");
            return;
        }

        Console.WriteLine($"Docházka pro {s}:");

        foreach (var zaznam in _dochazka[s])
        {
            Console.WriteLine(zaznam);
        }
    }
}
}