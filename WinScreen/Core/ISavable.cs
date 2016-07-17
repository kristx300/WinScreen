namespace WinScreen.Core
{
    /// <summary>
    /// Save other objects which release that interface
    /// </summary>
    internal interface ISavable
    {
        void Save(bool s);
    }
}