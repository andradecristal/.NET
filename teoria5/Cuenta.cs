using System;

namespace teoria5;

public class Cuenta
{
    private int _monto = 0;
    private static int s_cuentasCreadas;
    private static int s_depositos;
    private static int s_extracciones;
    private static int s_extraccionesDenegadas;
    private static int s_totalDepositado;
    private static int s_totalExtraido;
    private static int s_montoTotal;
    private static List<Cuenta> s_cuentas = new List<Cuenta>();
    private int _ID ;

    public Cuenta()
    {
        s_cuentasCreadas++;
        _ID = s_cuentasCreadas;
        s_cuentas.Add(this);
        Console.WriteLine($"Se creo la cuenta ID: {_ID}");
    }

    /*public static List<Cuenta> GetCuenta()
    {
        //return new List<Cuenta>(s_cuentas);
    }*/
    public static List<Cuenta> GetCuentas() => new List<Cuenta>(s_cuentas);
    
    public static void ImprimirDetalle()
    {
        Console.WriteLine($"CUENTAS CEADAS: {Cuenta.s_cuentasCreadas,2}");
        Console.WriteLine($"DESPOSITOS: {Cuenta.s_depositos,6} - Total de depositado: {s_totalDepositado,4}");
        Console.WriteLine($"EXTRACCIONES: {Cuenta.s_extracciones,4} - Total de extracciones: {s_totalExtraido,2}");
        Console.WriteLine($"                           - Saldo: {s_montoTotal,10}");
        Console.WriteLine($"* Se denegaron {s_extraccionesDenegadas} extracciones por falta de fondos");
    }
    public Cuenta Depositar(int monto)
    {
        _monto += monto;
        s_depositos++;
        s_montoTotal += monto;
        s_totalDepositado += monto;
        Console.WriteLine($"Se deposito: {monto} en la cuenta {_ID} (Saldo={_monto})");
        return this;
    }

    public Cuenta Extraer(int monto)
    {
        if(_monto>=monto){
            _monto -= monto;
            s_extracciones++;
            s_montoTotal -= monto;
            s_totalExtraido += monto;
            Console.WriteLine($"Se extrajo: {monto} en la cuenta {_ID} (Saldo={_monto})");
        }
        else
        {
            Console.WriteLine("Operacion denegada - Saldo insufieicnte");
            s_extraccionesDenegadas++;
        }
        return this;
    }
}
