namespace AgregaceAKompozice
{
    public class Student
{
    public string Jmeno { get; }
    public string Prijmeni { get; }
    public int Rocnik { get; }

    public Student(string jmeno, string prijmeni, int rocnik)
    {
        if (string.IsNullOrWhiteSpace(jmeno))
            throw new ArgumentException("Jméno nesmí být prázdné nebo obsahovat pouze bílé znaky.", nameof(jmeno));
        if (string.IsNullOrWhiteSpace(prijmeni))
            throw new ArgumentException("Příjmení nesmí být prázdné nebo obsahovat pouze bílé znaky.", nameof(prijmeni));
        if (rocnik <= 0)
            throw new ArgumentOutOfRangeException(nameof(rocnik), "Ročník musí být kladné číslo.");
        Jmeno = jmeno.Trim();
        Prijmeni = prijmeni.Trim();
        Rocnik = rocnik;
    }

    public override string ToString() => $"{Prijmeni} {Jmeno} {Rocnik}. ročník";
    {
    }
}
}