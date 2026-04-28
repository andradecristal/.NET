using System;

namespace teoria5;

public class A
{
    private static int a;
    private static readonly int b;
    A() { }
    public A(int i) : this() { }
    static A() => b = 2;
    int c;
    public static void A1() => a = 1;
    public int A1(int a) => A.a + a;
    public static int A2;
    static int A3 => 3;
    private int A4() => 4;
    public int A5 { get => 5; }
    int A6 { set => c = value; }
    public int A7 { get; set; }
    public int A8 { get; } = 8;
    public int this[int i] => i;

    /*
    campo esatico a
    campo estatico de solo lectura b
    constructor de instancia A
    constructor de instancia A
    constructor estatico A
    campo de instancia c 
    matodo estatico A1
    metodo de instancia A1
    campo estatico A2
    propiedad estatica de solo lectura A3
    matodo de instancia A4
    propiedad de instancia de solo lectura A5
    propiedad de instancia de solo escritura A6
    propiedad de instancia de escritura/lectura autoimplementada A7
    propiedad de solo escritura autoimplementada A8
    indizador de instancia de sólo lectura
    */
}
