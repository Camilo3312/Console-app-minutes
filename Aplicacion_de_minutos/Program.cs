using System;

namespace Aplicacion_de_minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            C_Tigo Tigo = new C_Tigo();
            C_Movistar Movistar = new C_Movistar();
            C_Claro Claro = new C_Claro();
            C_Paquetes Paquetes = new C_Paquetes();

            int mtigo = Tigo.Tigo_Min;
            int mclaro = Claro.Claro_Min;
            int mmovistar = Movistar.Movistar_Min;
            int resultado = 0;

            Console.WriteLine("Sistema de recargas");
           

            var Suitch = "1";

            while (Suitch == "1") {
            
                Console.WriteLine("Introduzca la opción");
                Console.WriteLine("(1) Para Recarga");
                Console.WriteLine("(2) Para Paquetes");
                Console.WriteLine("(3) Para Paquetes y recarga");

                int Opcion = Convert.ToInt32(Console.ReadLine());  

                // Recarga normal
                if (Opcion == 1)
                {
                    Console.WriteLine("Recarga");

                    /*valido el numero telefonico*/
                    Console.Write("¿Cual es su numero celular? ");
                    var Num_Celular = Console.ReadLine();
                    bool Evaluar = true;
                    long Nume_Celular = 0;
                    while (Evaluar != false)
                    {
                        try
                        {
                            Nume_Celular = Convert.ToInt64(Num_Celular);
                            Evaluar = false;

                        }
                        catch
                        {
                            Console.WriteLine("Por favor digite solo numeros\n");
                            Console.Write("¿Cual es su numero celular? ");
                            Num_Celular = Console.ReadLine();
                        }

                    }

                    /*--------------*/
        
                    Console.Write("Ingrese el operador ");

                    int Operador = Convert.ToInt32(Console.ReadLine());

                    if (Operador == 1)
                    {
                        Console.WriteLine("Tigo");

                        Console.Write("Valor de recarga de celular: ");

                        var Valor = Console.ReadLine();
                        int Valor_Recarga = 0;

                        Evaluar = true;
                        while (Evaluar != false)
                        {
                            try
                            {
                                Valor_Recarga = Convert.ToInt32(Valor);
                                Evaluar = false;
                            }
                            catch
                            {
                                Console.WriteLine("Por favor digite solo numeros");
                                Console.Write("Valor de recarga de celular: ");

                                Valor = Console.ReadLine();
                            }

                        }

                        if (Valor_Recarga >= 20000)
                        {
                            Valor_Recarga = Valor_Recarga * 2;
                            resultado = Valor_Recarga / mtigo;
                            Console.WriteLine("Número: {0}", Nume_Celular);
                            Console.WriteLine("Operador: Tigo");
                            Console.WriteLine("¡Hemos doblado tus minutos! Minutos: {0}", resultado);
                        }
                        else
                        {
                            resultado = Valor_Recarga / mtigo;
                            Console.WriteLine("Numero: {0}", Nume_Celular);
                            Console.WriteLine("Operador: Tigo");
                            Console.Write("Minutos: {0}", resultado);
                        }


                    }                

                    else if (Operador == 2)
                    {
                        Console.WriteLine("Claro");

                        Console.Write("Valor de recarga de celular: ");

                        var Valor = Console.ReadLine();
                        int Valor_Recarga = 0;

                        Evaluar = true;
                        while (Evaluar != false)
                        {
                            try
                            {
                                Valor_Recarga = Convert.ToInt32(Valor);
                                Evaluar = false;
                            }
                            catch
                            {
                                Console.WriteLine("Por favor digite solo numeros\n");
                                Console.Write("Valor de recarga de celular: ");

                                Valor = Console.ReadLine();
                            }

                        }

                        if (Valor_Recarga >= 20000)
                        {
                            Valor_Recarga = Valor_Recarga * 2;
                            resultado = Valor_Recarga / mclaro;
                            Console.WriteLine("Numero: {0}", Nume_Celular);
                            Console.WriteLine("Operador: Claro");
                            Console.Write("¡Hemos doblado tus minutos! Minutos: {0}", resultado);
                        }
                        else
                        {
                            resultado = Valor_Recarga / mclaro;
                            Console.WriteLine("Numero: {0}", Nume_Celular);
                            Console.WriteLine("Operador: Claro");
                            Console.Write("Minutos: {0}", resultado);
                        }

                    }

                    else if (Operador == 3)
                    {
                        Console.WriteLine("Movistar");

                        Console.Write("Valor de recarga de celular: ");

                        var Valor = Console.ReadLine();
                        int Valor_Recarga = 0;

                        Evaluar = true;
                        while (Evaluar != false)
                        {
                            try
                            {
                                Valor_Recarga = Convert.ToInt32(Valor);
                                Evaluar = false;
                            }
                            catch
                            {
                                Console.WriteLine("Por favor digite solo numeros\n");
                                Console.Write("Valor de recarga de celular: ");

                                Valor = Console.ReadLine();
                            }

                        }
                        if (Valor_Recarga >= 20000)
                        {
                            Valor_Recarga = Valor_Recarga * 2;
                            resultado = Valor_Recarga / mmovistar;
                            Console.WriteLine("Numero: {0}", Nume_Celular);
                            Console.WriteLine("Operador: Movistar");
                            Console.Write("¡Hemos doblado tus minutos! Minutos: {0}", resultado);
                        }
                        else
                        {
                            resultado = Valor_Recarga / mmovistar;
                            Console.WriteLine("Numero: {0}", Nume_Celular);
                            Console.WriteLine("Operador: Movistar");
                            Console.Write("Minutos: {0}", resultado);
                        }
                    }


                }

                // Paquetes
                else if (Opcion == 2)

                {
                    Console.WriteLine("Paquetes");

                    /*valido el numero telefonico*/
                    Console.Write("¿Cual es su numero celular?\n ");
                    var Num_Celular = Console.ReadLine();
                    bool Evaluar = true;
                    long Nume_Celular = 0;
                    while (Evaluar != false)
                    {
                        try
                        {
                            Nume_Celular = Convert.ToInt64(Num_Celular);
                            Evaluar = false;

                        }
                        catch
                        {
                            Console.WriteLine("Por favor digite solo numeros\n");
                            Console.Write("¿Cual es su numero celular? ");
                            Num_Celular = Console.ReadLine();
                        }

                    }

                    Console.Write("Seleccione el tipo de paquete\n");
                    Console.Write("(1) Diario\n");
                    Console.Write("(2) Mensual\n");

                    int Opcion_paquete = Convert.ToInt32(Console.ReadLine());

                    if (Opcion_paquete == 1)
                        
                    {
                        Console.Write("Diario");

                        Console.Write("Ingrese el operador ");
                        int Operador = Convert.ToInt32(Console.ReadLine());
                        if( Operador == 1)
                        {
                            Console.Write("Valor del paquete (3.000) Movistar\n ");
                            Console.Write("Ingrese (si) o (no) para aceptar o rechazar el pago\n ");

                            var Aceptar_pago = Console.ReadLine();

                            if (Aceptar_pago == "si")
                            {
                                int Valor_Recarga = 0;

                                Valor_Recarga = Paquetes.Paquete_Diario;

                                resultado = Valor_Recarga / mmovistar;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Movistar");
                                Console.Write("Datos: {0}", resultado + " MB");
                            }  
                        }

                        else if (Operador == 2)
                        {
                            Console.Write("Valor del paquete (3.000) Claro\n ");
                            Console.Write("Ingrese (si) o (no) para aceptar o rechazar el pago\n ");

                            var Aceptar_pago = Console.ReadLine();

                            if (Aceptar_pago == "si")
                            {
                                int Valor_Recarga = 0;

                                Valor_Recarga = Paquetes.Paquete_Diario;

                                resultado = Valor_Recarga / mclaro;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Claro");
                                Console.Write("Datos: {0}", resultado + " MB");
                            }
                        }

                    }
                    else if (Opcion_paquete == 2)
                    {
                        Console.Write("Mensual");

                        Console.Write("Ingrese el operador ");
                        int Operador = Convert.ToInt32(Console.ReadLine());
                        if (Operador == 1)
                        {
                            Console.Write("Valor del paquete (20.000) Movistar\n ");
                            Console.Write("Ingrese (si) o (no) para aceptar o rechazar el pago\n ");

                            var Aceptar_pago = Console.ReadLine();

                            if (Aceptar_pago == "si")
                            {
                                int Valor_Recarga = 0;

                                Valor_Recarga = Paquetes.Paquete_Mensual;

                                Valor_Recarga = Valor_Recarga * 2;
                                resultado = Valor_Recarga / mmovistar;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Movistar");
                                Console.Write("¡Hemos doblado tus datos! Datos: {0}", resultado + " MB");
                            }

                        }
                        else if (Operador == 2)
                        {
                            Console.Write("Valor del paquete (20.000) Claro\n ");
                            Console.Write("Ingrese (si) o (no) para aceptar o rechazar el pago\n ");

                            var Aceptar_pago = Console.ReadLine();

                            if (Aceptar_pago == "si")
                            {
                                int Valor_Recarga = 0;

                                Valor_Recarga = Paquetes.Paquete_Mensual;

                                Valor_Recarga = Valor_Recarga * 2;
                                resultado = Valor_Recarga / mclaro;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Claro");
                                Console.Write("¡Hemos doblado tus datos! Datos: {0}", resultado + " MB");
                            }
                        }
                    }
                }
                
                // Paquete y recarga
                else if (Opcion == 3)
                {
                    Console.WriteLine("Paquete y recarga");

                    /*valido el numero telefonico*/
                    Console.Write("¿Cual es su numero celular? ");
                    var Num_Celular = Console.ReadLine();
                    bool Evaluar = true;
                    long Nume_Celular = 0;
                    while (Evaluar != false)
                    {
                        try
                        {
                            Nume_Celular = Convert.ToInt64(Num_Celular);
                            Evaluar = false;

                        }
                        catch
                        {
                            Console.WriteLine("Por favor digite solo numeros\n");
                            Console.Write("¿Cual es su numero celular? ");
                            Num_Celular = Console.ReadLine();
                        }

                    }

                    Console.Write("Seleccione el tipo de paquete\n");
                    Console.Write("(1) Diario");
                    Console.Write("(2) Mensual\n");

                    int Opcion_paquete = Convert.ToInt32(Console.ReadLine());

                    if (Opcion_paquete == 1)
                    {
                        Console.Write("Diario");

                        Console.Write("Ingrese el operador ");
                        int Operador = Convert.ToInt32(Console.ReadLine());

                        if (Operador == 1)
                        {
                            Console.Write("Movistar");

                            Console.Write("Ingrese el valor de la recarga");

                            int Valor_Recarga = Convert.ToInt32(Console.ReadLine());
                            int Valor_pauquete = Paquetes.Paquete_Diario;

                            int resultado2 = Valor_pauquete / mmovistar;

                            if (Valor_Recarga >= 20000)
                            {
                                Valor_Recarga = Valor_Recarga * 2;
                                resultado = Valor_Recarga / mmovistar;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Movistar");
                                Console.Write("¡Hemos doblado tus minutos! Minutos: {0}", resultado);
                                Console.Write("Datos Paquete diario: {0}", resultado2 + " MB");

                            }
                            else
                            {
                                resultado = Valor_Recarga / mmovistar;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Movistar");
                                Console.Write("Minutos: {0}", resultado);
                                Console.Write("Datos Paquete diario: {0}", resultado2 + " MB");
                            }                                                     
                        }

                        else if (Operador == 2)
                        {
                            Console.Write("Claro");

                            Console.Write("Ingrese el valor de la recarga\n");

                            int Valor_Recarga = Convert.ToInt32(Console.ReadLine());
                            int Valor_pauquete = Paquetes.Paquete_Mensual;

                            int resultado2 = Valor_pauquete / mclaro;

                            if (Valor_Recarga >= 20000)
                            {
                                Valor_Recarga = Valor_Recarga * 2;
                                resultado = Valor_Recarga / mclaro;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Claro");
                                Console.Write("¡Hemos doblado tus minutos! Minutos: {0}", resultado);
                                Console.Write("\n Datos Paquete diario: {0}", resultado2 + " MB");

                            }
                            else
                            {
                                resultado = Valor_Recarga / mclaro;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Claro");
                                Console.Write("Minutos: {0}", resultado);
                                Console.Write("Datos Paquete diario: {0}", resultado2 + " MB");
                            }
                        }
                    }

                    else if (Opcion_paquete == 2)
                    {
                        Console.Write("Mensual");

                        Console.Write("Ingrese el operador ");
                        int Operador = Convert.ToInt32(Console.ReadLine());

                        if (Operador == 1)
                        {
                            Console.Write("Movistar");

                            Console.Write("Ingrese el valor de la recarga\n");

                            int Valor_Recarga = Convert.ToInt32(Console.ReadLine());
                            int Valor_pauquete = Paquetes.Paquete_Mensual;

                            int resultado2 = Valor_pauquete / mmovistar;

                            if (Valor_Recarga >= 20000)
                            {
                                Valor_Recarga = Valor_Recarga * 2;
                                resultado = Valor_Recarga / mmovistar;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Movistar");
                                Console.Write("¡Hemos doblado tus minutos! Minutos: {0}", resultado);
                                Console.Write("Datos Paquete diario: {0}", resultado2 + " MB");

                            }
                            else
                            {
                                resultado = Valor_Recarga / mmovistar;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Movistar");
                                Console.Write("Minutos: {0}", resultado);
                                Console.Write("Datos Paquete diario: {0}", resultado2 + " MB");
                            }
                        }

                        else if (Operador == 2)
                        {
                            Console.Write("Claro");

                            Console.Write("Ingrese el valor de la recarga");

                            int Valor_Recarga = Convert.ToInt32(Console.ReadLine());
                            int Valor_pauquete = Paquetes.Paquete_Mensual;

                            int resultado2 = Valor_pauquete / mclaro;

                            if (Valor_Recarga >= 20000)
                            {
                                Valor_Recarga = Valor_Recarga * 2;
                                resultado = Valor_Recarga / mclaro;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Claro");
                                Console.Write("¡Hemos doblado tus minutos! Minutos: {0}", resultado);
                                Console.Write("Datos Paquete diario: {0}", resultado2 + " MB");

                            }
                            else
                            {
                                resultado = Valor_Recarga / mclaro;
                                Console.WriteLine("Numero: {0}", Nume_Celular);
                                Console.WriteLine("Operador: Claro");
                                Console.Write("Minutos: {0}", resultado);
                                Console.Write("Datos Paquete diario: {0}", resultado2 + " MB");
                            }

                        }
                    }
                    
                }

                // Salir
                else if (Opcion == 4 )
                {
                    Suitch = "2";
                }

            }

        }
    }
}
