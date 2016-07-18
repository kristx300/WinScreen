namespace WinScreen.Core
{
    /// <summary>
    /// Analog tuple with open properties
    /// </summary>
    /// <typeparam name="T1">Object or struct</typeparam>
    /// <typeparam name="T2">Object or struct</typeparam>
    public class AnalogTuple<T1, T2>
    {
        public AnalogTuple()
        {
        }

        public AnalogTuple(T1 f, T2 s)
        {
            First = f;
            Second = s;
        }

        public T1 First { get; set; }
        public T2 Second { get; set; }
    }
}