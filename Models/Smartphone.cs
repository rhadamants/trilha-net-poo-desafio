namespace DesafioPOO.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    private  string Modelo { get; }
    private string IMEI { get; }
    private int Memoria { get; }

    protected Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine($"Ligando para {Numero}...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
}