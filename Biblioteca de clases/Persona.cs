using System.Text;

namespace Biblioteca_de_clases
{
    public abstract class Persona //Agregar el abstract
    {
        protected string apellido;
        protected string barrioResidencia = "No especificado";
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string apellido, string barrioResidencia, DateTime nacimiento, string nombre)
                        :this(apellido, nombre,nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public int Edad 
        {
            get { return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1; }
        }

        public string NombreCompleto
        {
            get { return $"{nombre}, {apellido}"; }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

        public string FichaPersonal(Persona p)
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine(p.ToString());
            sb.AppendLine($"EDAD: {Edad}");
            sb.AppendLine($"BARRIO RESIDENCIA: {barrioResidencia}");
            return sb.ToString();
        }

        internal abstract string FichaExtra();

    }
}
