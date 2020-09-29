using System;

namespace Library
{
    public class Singleton<T> where T: new()
    {
        private void Greeter()
        {
            // Intentionally left blank
        }

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }
}
