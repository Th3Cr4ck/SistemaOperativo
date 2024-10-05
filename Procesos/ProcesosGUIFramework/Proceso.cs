public class Proceso
{
    public int ID { get; }
    public int TiempoDeLlegada { get; set; }
    public int TiempoDeEjecucion { get; }
    public int TiempoDeInicio { get; set; }
    public int TiempoDeFin { get; set; }
    public int TiempoEnCola { get; set; }
    public int Espera {  get; set; }

    public int Paro;

    public Proceso(int tiempoDeEjecucion, ref int id)
    {
        // Crear un nuevo objeto con estos valores 
        ID = id;
        TiempoDeEjecucion = tiempoDeEjecucion;

        // Incrementar el ID
        id++;
    }




}
