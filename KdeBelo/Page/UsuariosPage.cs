using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdeBelo.Page
{
    public class UsuariosPage
    {

        private readonly IPage _page;

        public UsuariosPage(IPage page)
        {
            _page = page;
        }

        public async Task AbrirModalNuevoUsuario()
        {
            await _page.WaitForSelectorAsync("text=Agregar Usuario");
            await _page.ClickAsync("text=Agregar Usuario");
        }

        public async Task LlenarFormularioNuevoUsuario(string nombre,string apellido,string email,string telefono)
        {
            await _page.WaitForSelectorAsync(".modal.show");
            await _page.FillAsync("#nameInput", nombre);
            await _page.FillAsync("#lastnameInput", apellido);
            await _page.FillAsync("#emailInput", email);
            await _page.FillAsync("#phoneNumberInput", telefono);
            await _page.SelectOptionAsync("#roleSelect", new[] { "franchise_admin" });
           
        }
        public async Task GuardarUsuario()
        {
            await _page.ClickAsync("text=Registrar Usuario");
        }
    }
}
