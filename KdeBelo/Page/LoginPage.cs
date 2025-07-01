using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdeBelo.Page
{
    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }       

        public async Task IniciarSesionAsync(string usuario, string contraseña)
        {
            await _page.FillAsync("#username", usuario);
            await _page.FillAsync("#password-input", contraseña);
            await _page.ClickAsync("text=Iniciar Sesión");
        }
    }
}
