namespace WinScreen.Core
{
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