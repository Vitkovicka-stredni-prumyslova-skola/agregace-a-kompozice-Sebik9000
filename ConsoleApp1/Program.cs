namespace AgregaceAKompozice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var kniha = new TridniKniha();
            var s1 = new Student("Jan", "Novák", 1);
            var s2 = new Student("Eva", "Nová", 2);

            // T01 - zápis docházky nového studenta
            Console.WriteLine("T01:");
            kniha.ZapisDochazku(s1, new DateOnly(2026, 2, 19), true);
            kniha.VypisDochazku(s1);

            // T02 - zápis docházky jako nepřítomen
            Console.WriteLine("T02:");
            kniha.ZapisDochazku(s1, new DateOnly(2026, 2, 20), false);
            kniha.VypisDochazku(s1);

            // T03 - zápis docházky pro druhého studenta
            Console.WriteLine("T03:");
            kniha.ZapisDochazku(s2, new DateOnly(2026, 2, 19), true);
            kniha.VypisDochazku(s2);

            // T04 - více záznamů pro jednoho studenta
            Console.WriteLine("T04:");
            kniha.ZapisDochazku(s1, new DateOnly(2026, 2, 21), true);
            kniha.VypisDochazku(s1);

            // T05 - výpis docházky po více zápisech
            Console.WriteLine("T05:");
            kniha.ZapisDochazku(s2, new DateOnly(2026, 2, 20), false);
            kniha.ZapisDochazku(s2, new DateOnly(2026, 2, 21), true);
            kniha.VypisDochazku(s2);

            // T06 - zápis docházky s různými daty
            Console.WriteLine("T06:");
            var s3 = new Student("Petr", "Malý", 1);
            kniha.ZapisDochazku(s3, new DateOnly(2026, 1, 1), true);
            kniha.ZapisDochazku(s3, new DateOnly(2026, 12, 31), false);
            kniha.VypisDochazku(s3);

            // T07 - EDGE: výpis docházky studenta bez záznamů
            Console.WriteLine("T07:");
            var novyStudent = new Student("Novy", "Student", 1);
            kniha.VypisDochazku(novyStudent);

            // T08 - EDGE: zápis docházky s null studentem
            Console.WriteLine("T08:");
            try
            {
                kniha.ZapisDochazku(null, new DateOnly(2026, 2, 19), true);
                Console.WriteLine("Zapis probehl");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba: " + ex.GetType().Name);
            }

            // T09 - EDGE: výpis docházky s null studentem
            Console.WriteLine("T09:");
            try
            {
                kniha.VypisDochazku(null);
                Console.WriteLine("Vypis probehl");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba: " + ex.GetType().Name);
            }

            // T10 - EDGE: zápis stejného dne dvakrát
            Console.WriteLine("T10:");
            var s4 = new Student("Test", "Duplicita", 1);
            kniha.ZapisDochazku(s4, new DateOnly(2026, 2, 19), true);
            kniha.ZapisDochazku(s4, new DateOnly(2026, 2, 19), false);
            kniha.VypisDochazku(s4);
        }
    }
}