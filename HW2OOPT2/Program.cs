namespace HW2OOPT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Violin", "Four strings, played with a bow");
            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();

            Trombone trombone = new Trombone("Trombone", "Brass instrument, uses a slide to change pitch");
            trombone.Show();
            trombone.Sound();
            trombone.Desc();
            trombone.History();

            Ukulele ukulele = new Ukulele("Ukulele", "Four strings, small guitar-like instrument");
            ukulele.Show();
            ukulele.Sound();
            ukulele.Desc();
            ukulele.History();

            Cello cello = new Cello("Cello", "Large string instrument, played between the knees");
            cello.Show();
            cello.Sound();
            cello.Desc();
            cello.History();
        }
    }
}