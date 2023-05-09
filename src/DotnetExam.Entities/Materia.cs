namespace DotnetExam.Entities
{
    public class Materia : MateriaGenerador
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Docente Profesor { get; set; }
       

        public Materia()
        {
            
        }
        public Materia(int MateriaiD, String Nombre)
        {
            this.MateriaId = MateriaiD;
            this.Nombre = Nombre;
            Alumnos = new List<Alumno>();
            Profesor = new Docente();
        }


    }
}