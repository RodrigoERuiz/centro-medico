using Biblioteca_de_clases;

namespace consola_para_probar_codigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente pacienteUno = new Paciente("Rodrigo", "Ruiz", new DateTime(1993, 2, 14), "Avellaneda");
            Consulta consulta = new Consulta(DateTime.Now, pacienteUno);

            Console.WriteLine(consulta.ToString());
        }
    }
}
