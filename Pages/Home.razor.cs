
namespace Pruebas.Pages
{

    public partial class Home
    {
        private bool showGrid = true;
        private List<Tarjeta> tarjetas;

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
            tarjetas = new List<Tarjeta>
        {
            new Tarjeta(24.45m, "images/excel.jpg", "Excel Básico", "San Agustin", new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0)),
            new Tarjeta(150, "images/word.png", "Word Intermedio", "Garaycochea", new TimeSpan(14, 0, 0), new TimeSpan(17, 0, 0)),
            new Tarjeta(80, "images/powerpoint.jpg", "Power Point Basico", "San Agustin", new TimeSpan(18, 0, 0), new TimeSpan(20, 0, 0)),
            new Tarjeta(150, "images/contable.png", "Programacion contable", "Garaycochea", new TimeSpan(14, 0, 0), new TimeSpan(17, 0, 0)),
            new Tarjeta(80, "images/photoshop.jpg", "Photshopp Intermedio", "Garaycochea", new TimeSpan(18, 0, 0), new TimeSpan(20, 0, 0)),
            new Tarjeta(150, "images/SQL.png", "SQL Básico", "San Agustin", new TimeSpan(14, 0, 0), new TimeSpan(17, 0, 0)),
            new Tarjeta(80, "images/imagen3.jpg", "Curso de Inglés", "San Agustin", new TimeSpan(18, 0, 0), new TimeSpan(20, 0, 0))
        };
        }
    }
    public class Tarjeta
    {
        public decimal costo { get; set; }
        public string img { get; set; } // Puedes usar string para el nombre de la imagen
        public string curso { get; set; }
        public string local { get; set; }
        public TimeSpan inicio { get; set; }
        public TimeSpan final { get; set; }

        public Tarjeta(decimal costo, string img, string curso, string local, TimeSpan inicio, TimeSpan final)
        {
            this.costo = costo;
            this.img = img;
            this.curso = curso;
            this.local = local;
            this.inicio = inicio;
            this.final = final;
        }
    }
}
