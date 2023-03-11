using System.Xml;
using Newtonsoft.Json;

namespace SimpleDotnetDependency;

public class RequireDependency
{
    public void checkDependency()
    {
        String simpleString = "Hello, world";
        JsonConvert.SerializeObject(simpleString);
    }
}