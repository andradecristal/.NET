using System;

namespace teoria5;

public class Persona
{
    public string nombre {get; set;}
    public char sexo {get; set;}
    public int dni {get; set;}
    public DateTime nacimiento {get; set;}
    public int edad
    {
        get
        {
            return DateTime.Now.Year-nacimiento.Year;
        }
    }

    public Persona(string nombre, char sexo, int dni, DateTime nacimiento)
    {
        this.nombre=nombre;
        this.sexo=sexo;
        this.dni=dni;
        this.nacimiento=nacimiento;
    }

    public Object? this[int i] 
    {
        get{
            return i switch{
                0 => nombre,
                1 => sexo,
                2 => dni,
                3 => nacimiento,
                4 => edad,
                _ => null,
            };
        }
        set{
            switch (i){
                case 0: nombre=(string?)value; break;
                case 1: sexo=(char)value; break;
                case 2: dni=(int)value; break;
                case 3: nacimiento=(DateTime)value; break;
                case 4: break;
                default: throw new IndexOutOfRangeException("Índice de tripulación no válido.");
            };
        }
    }
}
