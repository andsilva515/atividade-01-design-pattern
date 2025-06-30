// Estrutura Básica

public class Logger
{
    private static Logger _instancia;
    private static readonly object _lock = new object();

    // Construtor privado impede instanciação externa
    private Logger()
    {
        Console.WriteLine("Logger inicializado.");
    }

    // Propriedade pública para acessar a instância
    public static Logger Instancia
    {
        get
        {
            // Garante thread safety
            lock (_lock)
            {
                if (_instancia == null)
                {
                    _instancia = new Logger();
                }
                return _instancia;
            }
        }
    }

    // Método de exemplo
    public void Log(string mensagem)
    {
        Console.WriteLine($"[LOG] {mensagem}");
    }
}

// Exemplo de Uso

class Program
{
    static void Main(string[] args)
    {
        Logger log1 = Logger.Instancia;
        log1.Log("Primeira mensagem.");

        Logger log2 = Logger.Instancia;
        log2.Log("Segunda mensagem.");

        // Verifica se são a mesma instância
        Console.WriteLine($"log1 e log2 são a mesma instância? {log1 == log2}");
    }
}





