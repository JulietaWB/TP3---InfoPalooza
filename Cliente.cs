class Cliente  {
    public int Dni {get;set; }
    public string Apellido {get;set;}

    public string Nombre {get;set;}

    public DateTime FechaInscripcion {get;set;}

    public string TipoEntrada {get;set;}

    public int Cantidad {get;set;}


    //Constructor
    public Cliente (int dni, string apellido, string nombre, DateTime fechaInscripcion, string tipoEntrada, int cant) 
    {
        Dni = dni;
        Apellido =apellido;
        Nombre = nombre;
        FechaInscripcion = fechaInscripcion;
        TipoEntrada = tipoEntrada;
        Cantidad = cant;
    }

}