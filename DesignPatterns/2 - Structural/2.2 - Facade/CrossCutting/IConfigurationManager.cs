namespace DesignPatterns.Facade.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}