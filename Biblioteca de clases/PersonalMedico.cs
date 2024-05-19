using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas = new List<Consulta>();
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente):base(nombre,apellido, nacimiento)
        {
            this.esResidente = esResidente;
        }

         internal override string FichaExtra()
        {
            string medicoResidente = esResidente == true ? "SI" : "NO";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizó residencia?: {medicoResidente}");
            sb.AppendLine($"ATENCIONES:");

            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }
        public  string FichaExtra2
        {
            get {return FichaExtra(); }
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(nuevaConsulta);
            return nuevaConsulta;
        }


    }
}
