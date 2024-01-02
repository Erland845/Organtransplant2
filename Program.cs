namespace Organtransplant2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kåre Kåre = new Kåre(kidney: 2, name: "Kåre");
            Bernt Bernt = new Bernt(kidney: 0, name: "Bernt");
            Kåre.PrintInfoKåre();
            Bernt.PrintInfoBernt();
            Console.WriteLine("Hei Kåre, Bernt er på sykehus med ødelagte nyrer. Ønsker du å gi bort en?");
            KidneyXchange(Kåre, Bernt);

            Kåre.PrintInfoKåre();
            Bernt.PrintInfoBernt();

        }
        static void KidneyXchange(Kåre giver, Bernt receiver)
        {
            var input = Console.ReadLine();
            if (input == "Ja")
            {
                giver.Donatekidney(1);
                receiver.ReceiveKidney(1);

                Console.WriteLine("Kåre har gitt bort en nyre til bernt, og Bernt overlevde");

            }
            else
            {
                Console.WriteLine("Bernt døde");
            }

        }
    }
}