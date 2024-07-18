using BlazorBootstrap;

namespace Pruebas.Layout
{
    public partial class MainLayout
    {
        private Sidebar2 sidebar;
        IEnumerable<NavItem>? navItems;

        private async Task<Sidebar2DataProviderResult> Sidebar2DataProvider(Sidebar2DataProviderRequest request)
        {
            if (navItems is null)
                navItems = GetNavItems();

            await Task.Delay(2000);

            return await Task.FromResult(request.ApplyTo(navItems));
        }

        private IEnumerable<NavItem> GetNavItems()
        {
            navItems = new List<NavItem>
        {
            new NavItem { Id = "1", Text = "ESTUDIANTE", IconColor = IconColor.Primary },
            new NavItem { Id = "2", Href = "aprendizaje", IconName = IconName.Person, Text = "Mi Aprendizaje", ParentId="1"},
            new NavItem { Id = "3", Href = "cursos", IconName = IconName.Book, Text = "Cursos", ParentId="1" },
            new NavItem { Id = "4", Href = "solicitudes", IconName = IconName.List, Text = "Mis solicitudes", ParentId="1" },
            new NavItem { Id = "5", Href = "especialidades", IconName = IconName.Mortarboard, Text = "Especialidades", ParentId="1" },



            new NavItem { Id = "6", Text = "CONFIGURACION" },
            new NavItem { Id = "7", Href = "Periodo", IconName = IconName.Calendar, Text = "Periodo", ParentId="6" },
            new NavItem { Id = "8", Href = "horarios", IconName = IconName.Clock, Text = "Horarios", ParentId="6" },
            new NavItem { Id = "9", Href = "locales", IconName = IconName.Compass, Text = "Locales", ParentId="6" },
            new NavItem { Id = "10", Href = "aulas", IconName = IconName.Building, Text = "Aulas", ParentId="6" },
            new NavItem { Id = "11", Href = "usuarios", IconName = IconName.People, Text = "Usuarios", ParentId="6" },
            new NavItem { Id = "12", Href = "roles", IconName = IconName.PersonBadge, Text = "Roles", ParentId="6" },

            new NavItem { Id = "13", Text = "ACADEMICO" },
            new NavItem { Id = "14", Href = "material", IconName = IconName.JournalText, Text = "Material", ParentId="13" },
            new NavItem { Id = "15", Href = "estudiantes", IconName = IconName.PersonRaisedHand, Text = "Estudiantes" , ParentId="13"},
            new NavItem { Id = "16", Href = "especialidadedff", IconName = IconName.MortarboardFill, Text = "Especialidades" , ParentId="13"},
            new NavItem { Id = "17", Href = "modulos", IconName = IconName.Subtract, Text = "Modulos" , ParentId="13"},
            new NavItem { Id = "18", Href = "plan", IconName = IconName.FileRuledFill, Text = "Plan Estudios" , ParentId="13"},
            new NavItem { Id = "19", Href = "programaciones", IconName = IconName.Table, Text = "Programaciones" , ParentId="13"}
        };

            return navItems;
        }
        private void ToggleSidebar() => sidebar.ToggleSidebar();
    }
}
