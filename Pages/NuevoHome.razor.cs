namespace Pruebas.Pages
{
    public partial class NuevoHome
    {
        private List<Tarjeta> tarjetas;
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
    
}

