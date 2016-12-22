using OpenQA.Selenium;

namespace NewUITestFW.Controls
{
    class Locator
    {
        public string Name { get; set; }
        public By LocatorBy { get; set; }

        public Locator(string name, By locatorBy)
        {
            Name = name;
            LocatorBy = locatorBy;
        }
    }
}
