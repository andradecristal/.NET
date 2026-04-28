using System;


namespace teoria5;

public class ListaDePersonas
{
    private List<Persona> _lista = new List<Persona>();
    public void Agregar(Persona p)
    {
        _lista.Add(p);
    }

    public Persona? this[int i]
    {
        get
        {
            Persona? per=_lista.Find(p => p.dni == i);
            return per;
        }
    }

    public List<string>? this[char i]
    {
        get
        {
            List<string>? lista = _lista.Where(p => p.nombre.StartsWith(i)).Select(p => p.nombre).ToList();
            return lista;
        }
    }
}