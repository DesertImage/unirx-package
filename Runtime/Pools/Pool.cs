using System.Collections.Generic;

namespace DesertImage.Pools
{
    public abstract class Pool<T> where T : IPoolable
    {
        protected readonly Stack<T> Stack = new Stack<T>();

        public void Register(int count)
        {
            for (var i = 0; i < count; i++)
            {
                ReturnInstance(CreateInstance());
            }
        }

        public virtual T GetInstance()
        {
            var instance = Stack.Count > 0 ? Stack.Pop() : CreateInstance();

            instance.OnCreate();

            return instance;
        }

        public virtual void ReturnInstance(T instance)
        {
            Stack.Push(instance);
        }

        protected abstract T CreateInstance();
    }
}