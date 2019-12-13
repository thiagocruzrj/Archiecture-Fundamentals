namespace ArchiectureFundamentals.Cases
{
    public interface IService
    {
        string Return();
    }

    public class ServiceA : IService
    {
        public string Return()
        {
            return "A";
        }
    }

    public class ServiceB : IService
    {
        public string Return()
        {
            return "B";
        }
    }

    public class ServiceC : IService
    {
        public string Return()
        {
            return "C";
        }
    }
}