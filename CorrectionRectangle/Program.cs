namespace CorrectionRectangle;

class Rectangle {
    private int largeur;
    private int longueur;

    

    public int Largeur { get => largeur; set => largeur = value; }
    public int Longueur { get => longueur; set => longueur = value; }

    public Rectangle(int largeur, int longueur)
    {
        this.largeur = largeur;
        this.longueur = longueur;
    }

    public Rectangle() { }

    public int Perimetre()
    {
        return 2 * largeur + 2 * longueur;
    }

    public int Aire()
    {
        return largeur * longueur;
    }

    public bool EstCarre()
    {
        return largeur == longueur;
    }

    public void AfficherRectangle()
    {
        Console.WriteLine("Largeur: {0} - Longueur: {1} - Perimetre: {2} - Aire: {3} - {4}", largeur, longueur, Perimetre(), Aire(), EstCarre() ? "C'est un carré" : "Ce n'est pas un carré");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Largeur = 10;
        rectangle.Longueur = 11;
        rectangle.AfficherRectangle();
        int maLargeur=0;
        int maLongueur=0;
        bool bError=true;
        do
        {
            try
            {
                bError = false;
                Console.WriteLine("Saisir une largeur:");
                string line = Console.ReadLine();
                maLargeur = int.Parse(line);
            }
            catch (FormatException e)
            {
                bError = true;
                Console.WriteLine("Ce n'est pas un nombre");
            }
        } while (bError);
        do
        {
            try
            {
                bError = false;
                Console.WriteLine("Saisir une longueur:");
                string line = Console.ReadLine();
                maLongueur = int.Parse(line);
                if (maLongueur < maLargeur)
                {
                    bError = true;
                    Console.WriteLine("Saisir une longueur inferieure à la largeur");
                }
            }
            catch (FormatException e)
            {
                bError = true;
                Console.WriteLine("Ce n'est pas un nombre");
                Console.WriteLine(e.Message);
            }
        } while (bError);
        Rectangle rectangleSaisi = new Rectangle(maLargeur, maLongueur);
        rectangleSaisi.AfficherRectangle();

        Console.Read();
    }
}

