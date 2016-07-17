namespace WinScreen.Core
{
    public abstract class Manager<T> where T : class
    {
        /// <summary>
        /// Main object T
        /// </summary>
        protected T Ject { get; set; }
        /// <summary>
        /// Private property to save file
        /// </summary>
        private string _path { get; set; }

        /// <summary>
        /// Initializes main object T, here called deserializing and initializing object
        /// </summary>
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

        /// <summary>
        /// Save object T to JSON file
        /// </summary>
        protected void Save()
        {
            DataWorker.Serialize(_path, Ject);
        }

        /// <summary>
        /// Constructor of T
        /// </summary>
        protected abstract void Ctor();

        /// <summary>
        /// Set path to save JSON file
        /// </summary>
        /// <returns></returns>
        protected abstract string SetPath();
    }
}