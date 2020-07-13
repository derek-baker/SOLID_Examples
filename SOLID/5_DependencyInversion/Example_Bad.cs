namespace SOLID._5_DependencyInversion
{
    internal class Logger { }

    internal class Controller
    {
        // We're coupling the class to a specific implementation of one of its dependencies.
        private readonly Logger _logger;

        internal Controller()
        {
            // Since we're allowing the dependency-creation here, we also need to know how to configure the dependency.
            _logger = new Logger();
            // If we need to use a different object, we'll need to modify this class, and risk introducing a regression.
        }
    }
}
