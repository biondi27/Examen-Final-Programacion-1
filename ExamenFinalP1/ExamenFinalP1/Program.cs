namespace ExamenFinalP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Perfil conductor = new Perfil();

            Console.WriteLine("Iniciando Sistema de Infracciones de INTRANT...");
            Console.WriteLine("Comenzando registro de datos de infracción...");
            Console.WriteLine("Por favor ingresar la información requerida.");

            Console.WriteLine("\nNombre:");
            conductor.nombre = Console.ReadLine();
            Console.WriteLine("\nCédula:");
            conductor.cedula = Console.ReadLine();
            Console.WriteLine("\nDirección de su Domicilio:");
            conductor.direccion = Console.ReadLine();
            Console.WriteLine("\nLicencia de Conducir:");
            conductor.Licencia = Console.ReadLine();
            Console.WriteLine("\nFecha de Nacimiento (dd/mm/aaaa):");
            conductor.fechanacimiento = Console.ReadLine();
            

            Console.WriteLine("\n\nAhora registre los datos del vehículo.");
            Console.WriteLine("\nPlaca:");
            conductor.placa = Console.ReadLine();
            Console.WriteLine("\nMarca:");
            conductor.marca = Console.ReadLine();
            Console.WriteLine("\nModelo:");
            conductor.modelo = Console.ReadLine();
            Console.WriteLine("\nColor:");
            conductor.color = Console.ReadLine();
            Console.WriteLine("\nAño del Vehículo (aaaa):");
            conductor.año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nChasis:");
            conductor.chasis = Console.ReadLine();


            Agente oficial = new Agente();
            Console.WriteLine("\n\nAhora registre sus propios datos.");
            Console.WriteLine("\nNombre:");
            oficial.nombre = Console.ReadLine();
            Console.WriteLine("\nCédula:");
            oficial.code = Console.ReadLine();
            Console.WriteLine("\nDirección de su Domicilio:");
            oficial.dir_agente = Console.ReadLine();
            Console.WriteLine("\nFecha de Ingreso (dd/mm/aaaa):");
            oficial.ingreso = Console.ReadLine();


            Infracciones infraccion = new Infracciones();
            Console.WriteLine("\n\nEscoja la infracción cometida por el conductor (escribir Si o No):");
            
            int count = 5;
            while (count > 0)
            {
                Console.WriteLine("\nObstrucción de Tránsito.");
                string f1 = Console.ReadLine();
                if (f1== "Si")
                {
                    infraccion.Obst_de_Transito = true;
                }
                else
                {
                    infraccion.Obst_de_Transito = false;
                }
                count--;

                Console.WriteLine("\nPase de Semáforo en Rojo.");
                string f2 = Console.ReadLine();
                if (f2 == "Si")
                {
                    infraccion.Paso_Rojo = true;
                }
                else
                {
                    infraccion.Paso_Rojo = false;
                }
                count--;

                Console.WriteLine("\nHablando por el Celular en Tránsito.");
                string f3 = Console.ReadLine();
                if (f3 == "Si")
                {
                    infraccion.Celular_Hablar = true;
                }
                else
                {
                    infraccion.Celular_Hablar = false;
                }
                count--;

                Console.WriteLine("\nConduciendo Sin Cinturón.");
                string f4 = Console.ReadLine();
                if (f4 == "Si")
                {
                    infraccion.Sin_Cinturon = true;
                }
                else
                {
                    infraccion.Sin_Cinturon = false;
                }
                count--;

                Console.WriteLine("\nLicencia Vencida.");
                string f5 = Console.ReadLine();
                if (f5 == "Si")
                {
                    infraccion.Licen_Vencida = true;
                }
                else
                {
                    infraccion.Licen_Vencida = false;
                }
                count--;
            }

            Console.WriteLine("\n\nEl proceso de Registro de Infracción ha concluido.");
            Console.WriteLine("El conductor deberá pagar una multa de RD$" + infraccion.Multa());
            Console.WriteLine("Imprimiendo factura...");
            Console.WriteLine("Cerrando programa...");
        }
    }
}