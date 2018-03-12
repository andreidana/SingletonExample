namespace SingletonExample
{
    public class SingletonDesignPattern
    {
        private static volatile SingletonDesignPattern _singletonInstance;
        private static readonly object LockObject = new object();
        private readonly int _instantiatedVariable;

        private SingletonDesignPattern()
        {
            _instantiatedVariable = 1;
        }

        public static SingletonDesignPattern GetInstance()
        {
            //check for null instance to avoid always creating the lock if we already have an instance
            if (_singletonInstance == null)
            {
                lock (LockObject)
                {
                    if (_singletonInstance == null)
                    {
                        _singletonInstance = new SingletonDesignPattern();
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
