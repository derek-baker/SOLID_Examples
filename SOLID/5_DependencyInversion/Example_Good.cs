namespace SOLID._5_DependencyInversion.Good
{
    public interface ILogger { }

    public class Controller
    {
        private readonly ILogger _logger;

        // The logger param would be passed by a dependency injection framework, or calling code.
        // Calling code may use a factory to create the object. Among other things,
        // this approach allows us to "mock out" dependencies during testing.
        public Controller(ILogger logger)
        {
            _logger = logger;
        }
    }
}
