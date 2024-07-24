using BlazorBootstrap;
using Microsoft.AspNetCore.Components;

namespace Pruebas.Pages
{
    public partial class Periodo
    {
        protected string TituloModal = "";
        protected string TituloModalCerrar = "";
        protected string accion = "";
        protected Button botonaccion = default!;
        private Modal modal = default!;
        private Modal cerrar = default!;
        private bool codEditar = false;
        private ConfirmDialog dialog = default!;
        private DateTime primerDiaMes { get; set; }
        private DateTime ultimoDiaMes { get; set; }
        private bool 
            matri=true,
            pago=true,
            nota=true;
        

        private void CambioMes(ChangeEventArgs e)
        {
            if (DateTime.TryParse($"{e.Value}-01", out DateTime date))
            {
                primerDiaMes = date;
                var lastDayOfMonth = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                ultimoDiaMes = lastDayOfMonth;
            }
        }

        private async void Nuevo()
        {
            accion = "nuevo";
            codEditar = false;
            TituloModal = "Crear nuevo Periodo";
            await OnShowModalClick();
        }
        private async void Editar()
        {
            accion = "editar";
            codEditar = true;
            TituloModal = "Editar Periodo";
            await OnShowModalClick();
        }
        private async void BloqMatriculas() {
            accion = "bloqMatri";
            TituloModalCerrar = "Cerrar Matrículas";
            await cerrar.ShowAsync();
        }
        private async void BloqPagos()
        {
            accion = "bloqPago";
            TituloModalCerrar = "Cerrar Pagos";
            await cerrar.ShowAsync();
        }
        private async void BloqNotasAsistencias()
        {
            accion = "bloqNotaAsist";
            TituloModalCerrar = "Cerrar Notas y Asistencias";
            await cerrar.ShowAsync();
        }

        private List<PeriodoNormal> periodos = new List<PeriodoNormal>
        {
        new PeriodoNormal(1, new DateOnly(2023, 1, 1), new DateOnly(2023, 12, 31), "Activo"),
        new PeriodoNormal(2, new DateOnly(2024, 2, 1), new DateOnly(2024, 11, 30), "Inactivo"),
        new PeriodoNormal(3, new DateOnly(2025, 3, 1), new DateOnly(2025, 10, 31), "Activo"),
        new PeriodoNormal(4, new DateOnly(2026, 4, 1), new DateOnly(2026, 9, 30), "Pendiente"),
        new PeriodoNormal(5, new DateOnly(2027, 5, 1), new DateOnly(2027, 8, 31), "Completado"),
        new PeriodoNormal(6, new DateOnly(2028, 6, 1), new DateOnly(2028, 7, 31), "Activo"),
        new PeriodoNormal(7, new DateOnly(2029, 1, 1), new DateOnly(2029, 12, 31), "Activo"),
        new PeriodoNormal(8, new DateOnly(2030, 2, 1), new DateOnly(2030, 11, 30), "Inactivo")
        };

        private async Task OnShowModalClick()
        {
            await modal.ShowAsync();
        }

        private async Task OnHideModalClick()
        {
            await modal.HideAsync();
        }
        
    }
    public class PeriodoNormal
    {
        public int id;
        public DateOnly fechInicio;
        public DateOnly fechFin;
        public string estado;

        public PeriodoNormal(int id, DateOnly fechInicio, DateOnly fechFin, string estado)
        {
            this.id = id;
            this.fechInicio = fechInicio;
            this.fechFin = fechFin;
            this.estado = estado;
        }
    }
}
