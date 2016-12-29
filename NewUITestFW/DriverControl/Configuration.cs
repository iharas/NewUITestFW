using NSelene;

namespace NewUITestFW.DriverControl
{
    public static class Configuration
    {
        static class PrivateConfiguration
        {
            public static SeleneDriver SharedDriver = new SeleneDriver();
        }

    }
}
