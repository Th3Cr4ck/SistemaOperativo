using System;
public class GeneradorDeProcesos
{
    public static Proceso RandomProcess(ref int id)
    {
        Random generador = new Random();

        int numeroRandom = generador.Next(1, 11);
        Proceso proceso = new Proceso(numeroRandom, ref id);

        return proceso;
    }
}
