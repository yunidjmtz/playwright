using KdeBelo.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdeBelo.Hook
{
    [Binding]
    public class Hooks
    {
        private readonly PlaywrightDriver _driver;

        public Hooks(PlaywrightDriver driver)
        {
            _driver = driver;
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            await _driver.InitializeAsync();
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            await _driver.CloseAsync();
        }
    }
}
