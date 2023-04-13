using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalP1
{
    public class Ciudadano
    {
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string direccion { get; set; }
        public string Licencia { get; set; }
        public string fechanacimiento { get; set; }

    }

    public class Perfil : Ciudadano
    {
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int año { get; set; }
        public string chasis { get; set; }
    }

    public class Agente
    {
        public string nombre { get; set; }
        public string code { get; set; }
        public string dir_agente { get; set; }
        public string ingreso { get; set; }
    }

    public class Infracciones
    {
        public bool Obst_de_Transito { get; set; }
        public bool Paso_Rojo { get; set; }
        public bool Celular_Hablar { get; set; }
        public bool Sin_Cinturon { get; set; }
        public bool Licen_Vencida { get; set; }

        public double Multa()
        {
            double costo = 0;

            if (Obst_de_Transito == true) { costo = costo + 1800.00; }
            if (Paso_Rojo == true) { costo = costo + 5950.00; }
            if (Celular_Hablar == true) { costo = costo + 3750.00; }
            if (Sin_Cinturon == true) { costo = costo + 2560.00; }
            if (Licen_Vencida == true) { costo = costo + 3890.00; }

            return costo;
        }
    }
}
