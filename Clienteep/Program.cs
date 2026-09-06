
public class Vehiculo
{
    private int codigo;
    private string placa;
    private string marca;
    private string modelo;
    private double capacidad;
    private string estado;
    private double costoOperativo;

﻿public class Repartidor
{
    private int codigo;
    private string nombre;
    private string telefono;
    private string licencia;
    private string estado;
    private int entregasRealizadas;
    private double calificacio
      

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Placa
    {
        get { return placa; }
        set { placa = value; }
    }

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public double Capacidad
    {
        get { return capacidad; }
        set { capacidad = value; }
    }


    public string Licencia
    {
        get { return licencia; }
        set { licencia = value; }
    }


    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }


    public double CostoOperativo
    {
        get { return costoOperativo; }
        set { costoOperativo = value; }
    }

    public Vehiculo()
    {
        estado = "Disponible";
    }

    public Vehiculo(int codigo, string placa, string marca,
                    string modelo, double capacidad,
                    double costoOperativo)
    {
        this.codigo = codigo;
        this.placa = placa;
        this.marca = marca;
        this.modelo = modelo;
        this.capacidad = capacidad;
        this.costoOperativo = costoOperativo;
        estado = "Disponible";
    }

    public virtual bool PuedeTransportar(double peso)
    {
        return peso <= capacidad;

    public int EntregasRealizadas
    {
        get { return entregasRealizadas; }
        set { entregasRealizadas = value; }
    }

    public double Calificacion
    {
        get { return calificacion; }
        set { calificacion = value; }
    }

    public Repartidor()
    {
        estado = "Disponible";
        entregasRealizadas = 0;
        calificacion = 0;
    }

    public Repartidor(int codigo, string nombre, string telefono,
                      string licencia)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.telefono = telefono;
        this.licencia= licencia;
        estado = "Disponible";
        entregasRealizadas = 0;
        calificacion = 0;

    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Código: " + Codigo);

        Console.WriteLine("Placa: " + Placa);
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Capacidad: " + Capacidad + " kg");
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Costo operativo: Q" + CostoOperativo);

        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Teléfono: " + Telefono);
        Console.WriteLine("Licencia: " + Licencia);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Entregas realizadas: " + EntregasRealizadas);
        Console.WriteLine("Calificación: " + Calificacion);

    }
}