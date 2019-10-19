namespace SingletonExample
{
    public class SingletonDesignPattern
    {
        private static volatile SingletonDesignPattern _singletonInstance;
        private static readonly object LockObject = new object();
        private readonly int _instantiatedVariable;

        private SingletonDesignPattern(int instanceVariable)
        {
            _instantiatedVariable = instanceVariable;
        }

        public static SingletonDesignPattern GetInstance(int instanceVariable)
        {
            //check for null instance to avoid always creating the lock if we already have an instance
            if (_singletonInstance == null)
            {
                lock (LockObject)
                {
                    if (_singletonInstance == null)
                    {
                        _singletonInstance = new SingletonDesignPattern(instanceVariable);
                    }
                }
            }

            return _singletonInstance;
        }

        public int GetInstanciatedVariable()
        {
            return _instantiatedVariable;
        }
    }
}
