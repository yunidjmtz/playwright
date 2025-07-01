using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdeBelo.Drivers
{
    public class PlaywrightDriver
    {
        public IPlaywright PlaywrightInstance { get; private set; }
        public IBrowser Browser { get; private set; }
        public IBrowserContext Context { get; private set; }
        public IPage Page { get; private set; }

        public async Task InitializeAsync()
        {
            PlaywrightInstance = await Playwright.CreateAsync();
            Browser = await PlaywrightInstance.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false, // Si lo pones en true, el navegador no se verá,
                SlowMo = 500
            });

            Context = await Browser.NewContextAsync();
            Page = await Context.NewPageAsync();
        }

        public async Task CloseAsync()
        {
            await Browser.CloseAsync();
            PlaywrightInstance.Dispose();
        }
    }
}
