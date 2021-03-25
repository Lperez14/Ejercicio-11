using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto prod = new Producto();

            List<Producto> listaproductos = new List<Producto>();
        
            List<String> productosvendidos = new List<String>();

            int valor = 0,  Menufinal = 0;
            int balance = 0, moneda =0,opcionpago = 0;
            llenarmercancia();
            do
            {
                Console.Clear();
                Console.WriteLine("*************************************");
                Console.WriteLine("///////////Bienveido/////////////////");
                Console.WriteLine("1- Nueva Venta");
                Console.WriteLine("2- Generar Informe");
                Console.WriteLine("3- Salir");
                Console.WriteLine("*************************************");
                Console.Write("Digite una opcion: ");
                Menufinal = int.Parse(Console.ReadLine());


                switch (Menufinal)
                {
                    case 1:
                        do
                        {
                            pago();

                            if (opcionpago == 1)
                            {
                                Nuevobalance();
                            }

                        }
                        while (opcionpago != 2);

                        do
                        {
                            menu();
                        }
                        while (valor != 11);

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Informe de la venta del dia");
                        Console.WriteLine();


                        GenerarInforme();

                        Console.WriteLine();

                        break;
                    default:
                        Console.WriteLine("-Opcion Incorrecta-");
                        break;
                }


                Console.WriteLine(" - Enter para continuar -");
                Console.ReadKey();

            } while (Menufinal != 3);
           
            /*MODULO DE PAGO*/
            void pago()
            {
                Console.Clear();
                Console.WriteLine("************************************");
                Console.WriteLine("///////////Bienveido/////////////////");
                Console.WriteLine($"Su balance hasta ahora es: {balance}");
                Console.WriteLine(" 1-Ingresar balance");
                Console.WriteLine(" 2-Continar al menu");
                Console.Write("Digite una opcion: ");
                opcionpago = int.Parse(Console.ReadLine());

                
            }

            void Nuevobalance()
            {
                Console.Clear();
                Console.WriteLine("************************************");
                Console.WriteLine("///////////Bienveido/////////////////");
                Console.WriteLine($"Su balance hasta ahora es: {balance}");
                Console.Write("Ingrese el balance: ");
               int dinero = int.Parse(Console.ReadLine());

                if (dinero == 5 || dinero == 10 || dinero == 25 || dinero == 50 || dinero == 100 || dinero == 200)
                {
                   
                    Console.WriteLine("Balance Actualizado");

                    balance += dinero;
                }
                else
                {
                    Console.WriteLine("La moneda que introduciste no es valida, intenta con otra");

                }
                Console.WriteLine("Enter para continuar...");
                Console.ReadKey();
            }


            void menu()
            {
                Console.Clear();
                Console.WriteLine("************************************");
                Console.WriteLine("///////////Bienveido/////////////////");
                Console.WriteLine($"Su total hasta ahora es de: {balance}");
                Console.WriteLine($" 1-  {listaproductos[0].Nombre }  Precio:{listaproductos[0].Precio} disponiblidad: {listaproductos[0].Existencia}");
                Console.WriteLine($" 2-  {listaproductos[1].Nombre }  Precio:{listaproductos[1].Precio} disponiblidad: {listaproductos[1].Existencia}");
                Console.WriteLine($" 3-  {listaproductos[2].Nombre }  Precio:{listaproductos[2].Precio} disponiblidad: {listaproductos[2].Existencia}");
                Console.WriteLine($" 4-  {listaproductos[3].Nombre }  Precio:{listaproductos[3].Precio} disponiblidad: {listaproductos[3].Existencia}");
                Console.WriteLine($" 5-  {listaproductos[4].Nombre }  Precio:{listaproductos[4].Precio} disponiblidad: {listaproductos[4].Existencia}");
                Console.WriteLine($" 6-  {listaproductos[5].Nombre }  Precio:{listaproductos[5].Precio} disponiblidad: {listaproductos[5].Existencia}");
                Console.WriteLine($" 7-  {listaproductos[6].Nombre }  Precio:{listaproductos[6].Precio} disponiblidad: {listaproductos[6].Existencia}");
                Console.WriteLine($" 8-  {listaproductos[7].Nombre }  Precio:{listaproductos[7].Precio} disponiblidad: {listaproductos[7].Existencia}");
                Console.WriteLine($" 9-  {listaproductos[8].Nombre } Precio:{listaproductos[8].Precio} disponiblidad: {listaproductos[8].Existencia}");
                Console.WriteLine($" 10- {listaproductos[9].Nombre }   Precio:{listaproductos[9].Precio} disponiblidad: {listaproductos[9].Existencia}");
                Console.WriteLine("  11- Salir");
                Console.Write("Digite una opcion: ");
                valor = int.Parse(Console.ReadLine());



                prod = listaproductos.FirstOrDefault(x => x.ID == valor);
                if (prod != null)
                {
                  
                   if(prod.Precio > balance && prod.Existencia > 0)
                    {
                        Console.Write("No tienes suficiente dinero para comprar o el producto exta agotado");
                    }
                    else
                    {
                        Console.WriteLine("Gracias por su compra");
                        balance -= prod.Precio;
                        valor -= 1;
                        listaproductos[valor].Existencia -= 1;


                        productosvendidos.Add(prod.Nombre);
                       
                    }
                    Console.WriteLine("Enter para continuar");
                    Console.ReadKey();
                }
                else
                {
                    
                    Console.WriteLine("Producto no encontrado ");
                }
            }

            void llenarmercancia()
            {
                listaproductos.Add(new Producto(){ ID = 1, Nombre = "Coca Cola", Precio = 20,Existencia =10 });
                listaproductos.Add(new Producto() { ID = 2, Nombre = "Refresco Peppsi", Precio = 25, Existencia = 10 });
                listaproductos.Add(new Producto() { ID = 3, Nombre = "Chocolate MilKy Way", Precio = 10, Existencia = 10 });
                listaproductos.Add(new Producto() { ID = 4, Nombre = "Papita Lay", Precio = 15, Existencia = 10 });
                listaproductos.Add(new Producto() { ID = 5, Nombre = "Papita Ruffles", Precio = 15, Existencia = 10 });
                listaproductos.Add(new Producto() { ID = 6, Nombre = "Galleta Oreo", Precio = 14, Existencia = 10 });
                listaproductos.Add(new Producto() { ID = 7, Nombre = "Galleta Dino", Precio = 12, Existencia = 10 });
                listaproductos.Add(new Producto() { ID = 8, Nombre = "Chicle Trident", Precio = 10, Existencia = 10 });
                listaproductos.Add(new Producto() { ID = 9, Nombre = "Agua Planeta Azul", Precio = 15, Existencia = 10 });
                listaproductos.Add(new Producto() { ID = 10, Nombre = "Jugo DASANI", Precio = 15, Existencia = 10 });
         
            }
        
        
            void GenerarInforme()
            {
                
                Console.WriteLine($" 1-  {listaproductos[0].Nombre } disponiblidad: {listaproductos[0].Existencia }");
                Console.WriteLine($" 2-  {listaproductos[1].Nombre }  disponiblidad: {listaproductos[1].Existencia}");
                Console.WriteLine($" 3-  {listaproductos[2].Nombre }  disponiblidad: {listaproductos[2].Existencia}");
                Console.WriteLine($" 4-  {listaproductos[3].Nombre }  disponiblidad: {listaproductos[3].Existencia}");
                Console.WriteLine($" 5-  {listaproductos[4].Nombre }  disponiblidad: {listaproductos[4].Existencia}");
                Console.WriteLine($" 6-  {listaproductos[5].Nombre }  disponiblidad: {listaproductos[5].Existencia}");
                Console.WriteLine($" 7-  {listaproductos[6].Nombre }  disponiblidad: {listaproductos[6].Existencia}");
                Console.WriteLine($" 8-  {listaproductos[7].Nombre }  disponiblidad: {listaproductos[7].Existencia}");
                Console.WriteLine($" 9-  {listaproductos[8].Nombre } disponiblidad: {listaproductos[8].Existencia}");
                Console.WriteLine($" 10- {listaproductos[9].Nombre }  disponiblidad: {listaproductos[9].Existencia}");

                Console.WriteLine();
                Console.WriteLine("Productos Vendidos");
                for(int o=0; o < productosvendidos.Count; o++)
                {
                    Console.WriteLine(productosvendidos[o]);
                }

            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }




    }
}
