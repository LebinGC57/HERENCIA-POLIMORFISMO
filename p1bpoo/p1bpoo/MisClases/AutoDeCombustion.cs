using p1bpoo.MisClases;

internal class AutoDeCombustion : Vehiculo
{
    private int capacidadTanque;
    private int nivelCombustible;
    private string tipoCombustible;

    public AutoDeCombustion(int anio, string elColor, string elModelo, int capacidad, string tipo) : base(anio, elColor, elModelo)
    {
        capacidadTanque = capacidad;
        nivelCombustible = capacidad;
        tipoCombustible = tipo;
    }

    public override void acelerar(int cuanto)
    {
        base.acelerar(cuanto);
        nivelCombustible -= 1;
        Console.WriteLine("Combustible restante: {0}%", nivelCombustible);
    }

    public override void Frenar()
    {
        base.Frenar();
        nivelCombustible -= 1;
        Console.WriteLine("El auto de combustión está frenando.");
    }
  
}S