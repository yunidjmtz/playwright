﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace KdeBelo.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Crear un nuevo usuario")]
    public partial class CrearUnNuevoUsuarioFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Crear un nuevo usuario", "A short summary of the feature", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "CrearUsuario.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 5
#line hidden
#line 6
 await testRunner.GivenAsync("que el administrador está en la página de login", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 7
 await testRunner.AndAsync("inicia sesión con credenciales válidas", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("El administrador crea un usuario exitosamente")]
        [NUnit.Framework.CategoryAttribute("regresion")]
        [NUnit.Framework.TestCaseAttribute("Alberto", "Alonso", "alberto@mail.com", "614111222", null)]
        [NUnit.Framework.TestCaseAttribute("Camila", "Díaz", "camila.diaz@mail.com", "614222333", null)]
        [NUnit.Framework.TestCaseAttribute("Ricardo", "Torres", "ricardo@mail.com", "614333444", null)]
        public async System.Threading.Tasks.Task ElAdministradorCreaUnUsuarioExitosamente(string nombre, string apellido, string email, string telefono, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "regresion"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("nombre", nombre);
            argumentsOfScenario.Add("apellido", apellido);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("telefono", telefono);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("El administrador crea un usuario exitosamente", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
await this.FeatureBackgroundAsync();
#line hidden
#line 12
 await testRunner.WhenAsync("da click en agregar nuevo usuario", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 13
 await testRunner.AndAsync(string.Format("llena los campos con nombre \"{0}\", apellido \"{1}\", email \"{2}\", telefono \"{3}\"", nombre, apellido, email, telefono), ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 14
 await testRunner.AndAsync("da click en guardar", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 15
 await testRunner.ThenAsync(string.Format("debería guardarse exitosamente el usuario con nombre \"{0}\"", nombre), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No se permite crear un usuario con email duplicado")]
        [NUnit.Framework.CategoryAttribute("regresion")]
        [NUnit.Framework.CategoryAttribute("negativo")]
        public async System.Threading.Tasks.Task NoSePermiteCrearUnUsuarioConEmailDuplicado()
        {
            string[] tagsOfScenario = new string[] {
                    "regresion",
                    "negativo"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("No se permite crear un usuario con email duplicado", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
await this.FeatureBackgroundAsync();
#line hidden
#line 26
 await testRunner.GivenAsync("que el administrador está en la página de login", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 27
 await testRunner.AndAsync("inicia sesión con credenciales válidas", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 28
 await testRunner.WhenAsync("da click en agregar nuevo usuario", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 29
 await testRunner.AndAsync("llena los campos con nombre \"Alberto\", apellido \"Alonso\", email \"alberto@mail.com" +
                        "\", telefono \"614111222\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 30
 await testRunner.AndAsync("da click en guardar", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 31
 await testRunner.ThenAsync("debería mostrarse un mensaje de error por email duplicado", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
