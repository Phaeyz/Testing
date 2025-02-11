using System.Reflection;

namespace Phaeyz.Testing;

public class QuickTest
{
    public string ReturnString(string input) => input;

    // Test A
    // Test B
    public static string FileVersion =>
        ((AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(
            Assembly.GetExecutingAssembly(),
            typeof(AssemblyFileVersionAttribute), false)!).Version;
}
