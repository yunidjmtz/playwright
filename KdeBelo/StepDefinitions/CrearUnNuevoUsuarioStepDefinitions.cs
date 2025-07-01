using KdeBelo.Drivers;
using KdeBelo.Page;
using Microsoft.Playwright;
using NUnit.Framework;
using Reqnroll;
using System;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace KdeBelo.StepDefinitions
{
    [Binding]
    public class CrearUnNuevoUsuarioStepDefinitions
    {
        private readonly PlaywrightDriver _driver;
        private  UsuariosPage _usuariosPage;

        public CrearUnNuevoUsuarioStepDefinitions(PlaywrightDriver driver)
        {
            _driver = driver;           
        }

        [Given("que el administrador está en la página de login")]
        public async Task GivenQueElAdministradorEstaEnLaPaginaDeLogin()
        {            
            await _driver.Page.GotoAsync("https://mf-store-management-test.vercel.app/login");
            _usuariosPage = new UsuariosPage(_driver.Page);

        }

        [Given("inicia sesión con credenciales válidas")]
        public async Task GivenIniciaSesionConCredencialesValidas()
        {
            var loginPage = new LoginPage(_driver.Page);           
            await loginPage.IniciarSesionAsync("admin", "admin");

        }

        [When("da click en agregar nuevo usuario")]
        public async Task WhenDaClickEnAgregarNuevoUsuario()
        {
            await _usuariosPage.AbrirModalNuevoUsuario();
        }

        [When("llena los campos con nombre {string}, apellido {string}, email {string}, telefono {string}")]
        public async Task WhenLlenaLosCamposConNombreApellidoEmailTelefono(string nombre, string apellido, string email, string telefono)
        {
            await _usuariosPage.LlenarFormularioNuevoUsuario(nombre, apellido, email, telefono);
        }


        [When("da click en guardar")]
        public async Task WhenDarClickEnGuardar()
        {
            await _usuariosPage.GuardarUsuario();
        }

        [Then("debería guardarse exitosamente el usuario con nombre {string}")]
        public async Task ThenDeberiaGuardarseDeExitoIndicandoQueElUsuarioFueCreado(string nombre)
        {
            var response = await _driver.Page.WaitForResponseAsync(r =>
                r.Url.Contains("/user_admin/register_admin_user") && r.Status == 201, new() { Timeout = 5000 });

            var json = (JsonElement) await response.JsonAsync();
            var name = json.GetProperty("data").GetProperty("name").GetString();            

            Assert.That(name, Is.EqualTo(nombre));
        }


        [Then("debería mostrarse un mensaje de error por email duplicado")]
        public async Task ThenDeberiaMostrarseUnMensajeDeErrorPorEmailDuplicado()
        {
            var mensajeError = await _driver.Page.InnerTextAsync(".invalid-feedback");
            Assert.That(mensajeError.ToLower(), Does.Contain("correo").Or.Contain("exist"));
        }
    }
}
