
﻿using System;

public class Cliente
{
    private string codigo;
    private string nombre;
    private string telefono;
    private string correo;
    private string direccion;
    private int cantidadSolicitudes;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    public string Correo
    {
        get { return correo; }
        set { correo = value; }
    }

    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }

    public int CantidadSolicitudes
    {
        get { return cantidadSolicitudes; }
        set { cantidadSolicitudes = value; }
    }

    public Cliente(string codigo, string nombre, string telefono,
                   string correo, string direccion)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        Correo = correo;
        Direccion = direccion;
        CantidadSolicitudes = 0;
    }

    public void AumentarSolicitudes()
    {
        CantidadSolicitudes++;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Codigo: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Telefono: " + Telefono);
        Console.WriteLine("Correo: " + Correo);
        Console.WriteLine("Direccion: " + Direccion);
        Console.WriteLine("Solicitudes realizadas: " + CantidadSolicitudes);
    }
}
