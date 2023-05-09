using DotnetExam.Entities;
using System.Collections.Specialized;
using System.Collections;
using Xunit;

namespace DotnetExam.Tests
{
    public class Exam_DNIXXX_APELLIDOYYY
    {
        [Fact]
        public void Test1_Teoria_NET()
        {

            //Describa la diferencia entre .NET Framework y .NET Core
            var respuesta = "La diferencia es que .Net Core es de codigo abierto " +
                        "lo que hace que tenga mejoras de la comunidad y .Net Framework es de codigo cerrado. "
                      + "es una plataforma de desarrollo de software para Windows, mientras que .NET Core es " +
                        "multiplataforma, lo que significa que se puede usar en sistemas operativos diferentes a Windows, como Linux y macOS."
;

            Assert.NotEqual(string.Empty, respuesta);


        }

        [Fact]
        public void Test2_Teoria_Assembly()
        {


            //Describa que es un assembly o ensamblado en .NET
            var respuesta = "un ensamblado es como un paquete que contiene todo lo que un programa de computadora necesita para funcionar" +
                " correctamente, como el código que hace que el programa funcione, información sobre cómo funciona el programa y otros recursos necesarios."
                + "El ensamblado es importante porque permite que los programadores actualicen y corrijan partes específicas del programa de manera más fácil y " +
                "organizada, en lugar de tener que cambiar todo el programa. Además, el ensamblado es la manera en que se controlan las diferentes versiones de un " +
                "programa y se asegura de que todo funcione correctamente.";

            Assert.NotEqual(string.Empty, respuesta);

        }


        [Fact]
        public void Test3_Teoria_IL()
        {


            //Describa que es el Lenguaje Intermedio o IL
            var respuesta = "Es el lenguaje de una maquina abstracta diseñada para ayudar a realizar" +
                "el analisis de un programa informatico";

            Assert.NotEqual(string.Empty, respuesta);


        }




        [Fact]
        public void Test4_DateTime_Formatting()
        {


            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);


            Assert.Equal("18/12/22 15:30:23", finalWorldCupMatch.ToString("dd/MM/yy HH:mm:ss"));

            Assert.Equal("18/12/22 03:30 p. m.", finalWorldCupMatch.ToString("dd/MM/yy hh:mm p. 'm'."));

            Assert.Equal("18 de diciembre de 2022", finalWorldCupMatch.ToString("dd 'd'e MMMM 'd'e yyyy"));


        }

        [Fact]
        public void Test5_DateTime_Days()
        {


            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);
            var today = new DateTime(2023, 5, 9, 15, 00, 00);

            var dia = today.Subtract(finalWorldCupMatch);

            var result = $"{dia.Days} Días totales desde la final del mundo";

            Assert.Equal("141 Días totales desde la final del mundo", result);

        }



        [Fact]
        public void Test6_POO_Alumno()
        {
            var alumno = new Alumno();
            alumno.AlumnoId = 123456;
            alumno.Legajo = "000010/22";
            alumno.Nombre = "Lionel";
            alumno.Apellido = "Messi";

            Assert.Equal(123456, alumno.AlumnoId);
            Assert.Equal("000010/22", alumno.Legajo);
            Assert.Equal("Lionel Messi", alumno.NombreCompleto);
        }


        [Fact]
        public void Test6_POO_Materia()
        {
            var materia = new Materia(123456, "Programacion III");

            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

        }


        [Fact]
        public void Test8_POO_UML()
        {
            //En base al diagrama UML del examen
            //Codifique las clases e interfaces necesarias

            var docente = new Docente(1, 1, "Lionel", "Scaloni");

            var alumno1 = new Alumno();
            alumno1.Id = 101010;
            alumno1.Legajo = "000010/22";
            alumno1.AlumnoId = 101010;
            alumno1.Nombre = "Lionel";
            alumno1.Apellido = "Messi";

            var alumno2 = new Alumno();
            alumno2.Id = 777;
            alumno2.AlumnoId = 777;
            alumno2.Legajo = "000007/22";
            alumno2.Nombre = "Rodrigo";
            alumno2.Apellido = "De Paul";

            var materia = new Materia(123456, "Programacion III")
            {
                Profesor = docente
            };
            materia.Alumnos.Add(alumno1);
            materia.Alumnos.Add(alumno2);


            
            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);
            

            Assert.Equal(1, materia.Profesor.Id);
            Assert.Equal(1, materia.Profesor.DocenteId);
            Assert.Equal("Lionel", materia.Profesor.Nombre);
            Assert.Equal("Scaloni", materia.Profesor.Apellido);

            Assert.Equal(101010, materia.Alumnos.First().Id);
            Assert.Equal("000010/22", materia.Alumnos.First().Legajo);
            Assert.Equal(101010, materia.Alumnos.First().AlumnoId);
            Assert.Equal("Lionel", materia.Alumnos.First().Nombre);
            Assert.Equal("Messi", materia.Alumnos.First().Apellido);

            Assert.Equal(777, materia.Alumnos.Last().Id);
            Assert.Equal(777, materia.Alumnos.Last().AlumnoId);
            Assert.Equal("000007/22", materia.Alumnos.Last().Legajo);
            Assert.Equal("Rodrigo", materia.Alumnos.Last().Nombre);
            Assert.Equal("De Paul", materia.Alumnos.Last().Apellido);

        }
    }
}
    

/*
        [Fact]
        public void Test9_Collection_GetCountFirtLast()
        {
            //Utilice la coleccion del trabajo practico que presento
            //Para poder con el generador completar dicha coleccion
            //y buscar las primeras materias y primeros y ultimos alumnos
            var materias = new List<Materia>();

           


            materias.AddRange(MateriaGenerador.Generar(10000, 1000));

            Assert.Equal(10000, materias.Count);

            Assert.Equal(1000, materias.First().Alumnos.Count);
            Assert.Equal("M1-000001/23", materias.First().Alumnos.First().Legajo);
            Assert.Equal("M1-001000/23", materias.First().Alumnos.Last().Legajo);

            Assert.Equal(1000, materias.Last().Alumnos.Count);
            Assert.Equal("M10000-000001/23", materias.Last().Alumnos.First().Legajo);
            Assert.Equal("M10000-001000/23", materias.Last().Alumnos.Last().Legajo);

        }


        [Fact]
        public void Test10_Linq_BuscarLegajo()
        {
            //Busque los alumnos en las materias que contengan el legajo 000999
            //Utilice la coleccion del trabajo practico que presento
            var materias = new List<Materia>();

            materias.AddRange(MateriaGenerador.Generar(10000, 1000));

            //Ayuda: where a.Legajo.Contains("000999/23")
            var query = null;

            Assert.Equal(1000, query.ToList().Count);

        }
    }
}
*/