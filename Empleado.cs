namespace Empleados;

public class Emplead{
    private string  nombre;
    private string apellido;
private DateTime fecNac = DateTime.Now;
    private char estadoCivil;
    private double sueldo;

    private Cargos cargo;
   
    public string Nombre
    {
        get
        {
            return nombre;
        }
    }

    public string Apellido
    {
        get
        {
            return apellido;
        }
    }

    public DateTime Fecnac
    {
        get
        {
            return fecNac;
        }
    }

    public char Estadocivil
    {
        get
        {
            return estadoCivil;    
        }
    }

    public double Sueldo
    {
        get
        {
            return sueldo;
        }
    }

    public Cargos Cargo
    {
        get
        {
            return cargo;
        }
    }

}

 public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }