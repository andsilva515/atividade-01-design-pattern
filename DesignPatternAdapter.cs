// Interface Esperada (Alvo)

public interface ITomada2Pinos
{
    void Conectar();
}


// Classe Incompatível (Adaptee)

public class Tomada3Pinos
{
    public void Conectar3Pinos()
    {
        Console.WriteLine("Conectado usando tomada de 3 pinos.");
    }
}

// Adaptador

public class AdaptadorTomada : ITomada2Pinos
{
    private readonly Tomada3Pinos _tomada3Pinos;

    public AdaptadorTomada(Tomada3Pinos tomada3Pinos)
    {
        _tomada3Pinos = tomada3Pinos;
    }

    public void Conectar()
    {
        Console.WriteLine("Adaptador convertendo de 2 pinos para 3 pinos...");
        _tomada3Pinos.Conectar3Pinos();
    }
}

// Exemplo de Uso

class Program
{
    static void Main(string[] args)
    {
        // Dispositivo com tomada de 3 pinos
        Tomada3Pinos tomada3 = new Tomada3Pinos();

        // Adaptador permite que ele funcione como uma tomada de 2 pinos
        ITomada2Pinos adaptador = new AdaptadorTomada(tomada3);

        // Cliente usa a interface esperada
        adaptador.Conectar();
    }
}
