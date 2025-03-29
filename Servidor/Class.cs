namespace Servidor
{
    public class Consulta
    {
         public string nombrePaciente { get; set; }

        public string apellidoPaciente { get; set; }

        public string nombreProfesional { get; set; }

        public string apellidoProfesional { get; set; }

        public int turno {  get; set; }

        public string departamento { get; set; }

        public int piso { get; set; }

        public string consultorio { get; set; }

        public string token {  get; set; }
        public string hospital {  get; set; }
    }
}
