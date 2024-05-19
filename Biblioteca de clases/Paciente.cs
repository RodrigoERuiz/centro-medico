using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Paciente:Persona
    {
        public string diagnostico = "Sin especificar";
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia)
                        :base(nombre, barrioResidencia, nacimiento,apellido)
        {

        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Recide en: {barrioResidencia}");
            sb.AppendLine($"{diagnostico}");


            return sb.ToString();
        } 
    }

}
