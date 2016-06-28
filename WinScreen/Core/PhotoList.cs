using System;
using System.Collections.Generic;
using System.Linq;

namespace WinScreen.Core
{
    public class PhotoList : Manager<List<string>>
    {
        private Random Randomize = new Random();

        public PhotoList()
        {
            Init();
        }

        public int Count
        {
            get
            {
                return Ject.Count;
            }
        }
        private int CurrentIndex { get; set; } = 0;
        private int Prev { get; set; } = 0;

        public void Add(string path)
        {
            Ject.Add(path);
            CurrentIndex = Ject.FindIndex(x => x == path);
            Save();
        }

        public string GetCurrentPath()
        {
            return Ject[CurrentIndex];
        }

        public string[] GetData()
        {
            return Ject.Select(x => x.GetLastPart()).ToArray();
        }

        public string File(string name)
        {
            var locale = Ject.SingleOrDefault(x => x.GetLastPart() == name);
            CurrentIndex = Ject.FindIndex(x => x.GetLastPart() == name);
            return locale;
        }

        public string Photo()
        {
            Prev = CurrentIndex;
            var locale = Ject[CurrentIndex];
            if (CurrentIndex + 1 == Count)
                CurrentIndex = 0;
            else
                CurrentIndex++;
            return locale;
        }

        public string Random()
        {
            var c = Ject.Count();
            Prev = CurrentIndex;
            CurrentIndex = Randomize.Next(c);
            return Ject[CurrentIndex];
        }

        public string Previous()
        {
            return Ject[Prev];
        }

        public void Remove(string path)
        {
            Ject.RemoveAt(Ject.FindIndex(x => x.Contains(path)));
            Save();
        }

        public string[] Remove()
        {
            var rem = Ject.Where(x => x.Contains("Copy")).ToArray();
            Ject.RemoveAll(x => x.Contains("Copy"));
            Save();
            return rem;
        }

        protected override void Ctor()
        {
            Ject = new List<string>();
        }

        protected override string SetPath()
        {
            return Environment.CurrentDirectory + @"\pset.json";
        }
    }
}