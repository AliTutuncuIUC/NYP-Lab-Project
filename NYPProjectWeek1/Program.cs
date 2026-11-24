public enum CihazTuru
{
    Lamba,
    Klima,
    GuvenlikSistemi
}

abstract class Cihaz
{
    private string _kimlik;

    public string Kimlik
    {
        get => _kimlik;

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Kimlik boş olamaz.");
            }
            _kimlik = value;
        }
    }
    public string Ad {get; private set;}
    public CihazTuru CihazTuru {get; private set;}
    public bool AcikMi {get; private set;}

    protected Cihaz(string kimlik, string ad, CihazTuru cihazTuru)
    {
        Kimlik = kimlik;
        Ad = ad;
        CihazTuru = cihazTuru;
        AcikMi = false;
    }

    public void Ac()
    {
        AcikMi = true;
    }

    public void Kapa()
    {
        AcikMi = false;
    }

    public void BilgileriGoster()
    {
        Console.WriteLine($"Cihaz Adı: {Ad}\nCihaz Kimliği: {Kimlik}\nCihaz Türü: {CihazTuru}\nCihaz Durumu: {AcikMi}");
    }    
}

class Program
{
    static void Main()
    {

    }
}
