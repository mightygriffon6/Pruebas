
using BlazorBootstrap;
using System.Collections;

namespace Pruebas.Pages
{

    public partial class Home
    {
        private bool showGrid = true;
        private List<Tarjeta> tarjetas;
        private List<Curso> cursos;

        private void ShowGrid()
        {
            if (!showGrid)
            {
                showGrid = true;
            }
        }

        private void ShowTable()
        {
            if (showGrid)
            {
                showGrid = false;
            }
        }
        protected override void OnInitialized()
        {
            cursos = new List<Curso>
            {
                new Curso(24.45m, "images/excel.jpg", "Excel Básico", "Emp", "San Agustin", "LMXJV", new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0)),
                new Curso(24.45m, "images/excel.jpg", "Excel Básico", "Emp", "San Agustin", "LMXJV", new TimeSpan(9, 0, 0), new TimeSpan(3, 0, 0)),
                new Curso(24.45m, "images/excel.jpg", "Excel Básico", "Lib", "San Agustin", "LMXJV", new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0)),
                new Curso(24.45m, "images/excel.jpg", "Excel Básico", "Emp", "Virtual", "LMXJV", new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0)),
                new Curso(50, "images/word.png", "Word Intermedio", "Emp", "Virtual", "LMXJV", new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0)),
                new Curso(24.45m, "images/word.png", "Word Intermedio", "Emp", "Virtual", "LM", new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0)),
                new Curso(24.45m, "images/word.pnhg", "Word Intermedio", "Emp", "Virtual", "LMXJV", new TimeSpan(18, 0, 0), new TimeSpan(12, 0, 0)),
                new Curso(24.45m, "images/excel.jpg", "Excel Básico", "Emp", "San Agustin", "LMXJV", new TimeSpan(21, 0, 0), new TimeSpan(26, 0, 0)),
                new Curso(24.45m, "images/excel.jpg", "Excel Básico", "Emp", "Virtual", "LMXJV", new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0))
            };
            tarjetas = new List<Tarjeta>();
            foreach (Curso curso in cursos)
            {
                // Busca si ya existe una tarjeta con el mismo curso, local y días
                Tarjeta tarjetaExistente = tarjetas.Find(t => t.Curso == "(" + curso.TipdeCurso + ")" + curso.Descripcion && t.Local == curso.Local && t.Dias == curso.Dias);

                if (tarjetaExistente == null)
                {
                    // Si no existe, crea una nueva tarjeta
                    Tarjeta nuevaTarjeta = new Tarjeta(curso.Costo, curso.Img, "(" + curso.TipdeCurso + ")" + curso.Descripcion, curso.Local)
                    {
                        Dias = curso.Dias
                    };
                    nuevaTarjeta.AgregarHorario(curso.Inicio, curso.Final);
                    tarjetas.Add(nuevaTarjeta);
                }
                else
                {
                    // Si existe, solo agrega el horario
                    tarjetaExistente.AgregarHorario(curso.Inicio, curso.Final);
                }
            }
        }
    }
    public class Tarjeta
    {
        public decimal Costo { get; set; }
        public string Img { get; set; }
        public string Curso { get; set; }
        public string Local { get; set; }
        public string Dias { get; set; }
        public List<string> Horarios { get; set; }

        public Tarjeta(decimal costo, string img, string curso, string local)
        {
            Costo = costo;
            Img = img;
            Curso = curso;
            Local = local;
            Dias = "";
            Horarios = new List<string>();
        }

        public void AgregarHorario(TimeSpan inicio, TimeSpan final)
        {
            string horario = $"{inicio.ToString(@"hh\:mm")}-{final.ToString(@"hh\:mm")}";
            Horarios.Add(horario);
        }
    }

    public class Curso
    {
        public decimal Costo { get; set; }
        public string Img { get; set; }
        public string Descripcion { get; set; }
        public string TipdeCurso { get; set; }
        public string Local { get; set; }
        public string Dias { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Final { get; set; }

        public Curso(decimal costo, string img, string descripcion, string tip, string local, string dias, TimeSpan inicio, TimeSpan final)
        {
            Costo = costo;
            Img = img;
            Descripcion = descripcion;
            TipdeCurso = tip;
            Local = local;
            Dias = dias;
            Inicio = inicio;
            Final = final;
        }
    }
}
