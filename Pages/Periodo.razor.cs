using BlazorBootstrap;
using Microsoft.AspNetCore.Components;

namespace Pruebas.Pages
{
    public partial class Periodo
    {
        protected string TituloModal = "";
        protected string tituloConfDialg = "", mensajeConfDialg = "";
        protected string accion = "";
        protected Button botonaccion = default!;
        private Modal modal = default!;
        private bool codEditar = false;
        private ConfirmDialog dialog = default!;
        private DateTime primerDiaMes { get; set; }
        private DateTime ultimoDiaMes { get; set; }
        

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
        private async Task ShowConfirmationAsync()
        {
            var options = new ConfirmDialogOptions
            {
                YesButtonText = "SI",
                YesButtonColor = ButtonColor.Success,
                NoButtonText = "CANCELAR",
                NoButtonColor = ButtonColor.Danger,
                HeaderCssClass = "custom-dialog-header",
            };

            var confirmation = await dialog.ShowAsync(
                title: tituloConfDialg,
                message1: mensajeConfDialg,
                message2: "¿Quieres Continuar?",
                confirmDialogOptions: options);

            if (confirmation)
            {
                switch (accion)
                {
                    case "borrar":
                        break;
                    case "bloquearMat":
                        break;
                    case "bloquearPag":
                        break;
                    case "bloquearNotasAsist":
                        break;
                }
            }
            else
            {
                accion = "";
            }
        }
        private async void BloqMatriculas()
        {
            tituloConfDialg = "¿Estás seguro que quieres bloquear las matriculas?";
            mensajeConfDialg = "Bloquearás las matrículas de este periodo";
            accion = "bloquearMat";
            await ShowConfirmationAsync();
        }
        private async void BloqPagos()
        {
            tituloConfDialg = "¿Estás seguro que quieres bloquear los pagos de este periodo?";
            mensajeConfDialg = "Bloquearás  los pagos de este periodo";
            accion = "bloquearPag";
            await ShowConfirmationAsync();
        }
        private async void BloqNotasAsistencias()
        {
            tituloConfDialg = "¿Estás seguro que quieres bloquear las notas y las asistencias de este periodo?";
            mensajeConfDialg = "Bloquearás el registro de notas y asistencias de este periodo";
            accion = "bloquearNotasAsist";
            await ShowConfirmationAsync();

        }
        private async void BorrarPeriodo()
        {
            tituloConfDialg = "¿Estás seguro que quieres Eliminar este periodo?";
            mensajeConfDialg = "Eliminarás el periodo actual";
            accion = "borrar";
            await ShowConfirmationAsync();
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
        new PeriodoNormal(8, new DateOnly(2030, 2, 1), new DateOnly(2030, 11, 30), "Inactivo"),
        new PeriodoNormal(9, new DateOnly(2031, 3, 1), new DateOnly(2031, 10, 31), "Activo"),
        new PeriodoNormal(10, new DateOnly(2032, 4, 1), new DateOnly(2032, 9, 30), "Pendiente"),
        new PeriodoNormal(11, new DateOnly(2033, 5, 1), new DateOnly(2033, 8, 31), "Completado"),
        new PeriodoNormal(12, new DateOnly(2034, 6, 1), new DateOnly(2034, 7, 31), "Activo"),
        new PeriodoNormal(13, new DateOnly(2035, 1, 1), new DateOnly(2035, 12, 31), "Activo"),
        new PeriodoNormal(14, new DateOnly(2036, 2, 1), new DateOnly(2036, 11, 30), "Inactivo"),
        new PeriodoNormal(15, new DateOnly(2042, 2, 1), new DateOnly(2042, 11, 30), "Inactivo")
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
