namespace WinScreen.Core
{
    public abstract class Manager<T> where T : class
    {
        protected T Ject { get; set; }
        private string _path { get; set; }

        protected void Init()
        {
            _path = SetPath();
            var locale = DataWorker.Deserialize(_path, typeof(T));

            if (locale is T && locale != null)
                Ject = locale as T;
            else
            {
                Ctor();
                DataWorker.Serialize(_path, Ject);
            }
        }

        protected void Save()
        {
            DataWorker.Serialize(_path, Ject);
        }

        protected abstract void Ctor();

        protected abstract string SetPath();
    }
}