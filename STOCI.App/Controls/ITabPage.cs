using System;
namespace STOCI.App
{
    public interface ITabPage
    {
        string TabIcon { get; }

        string SelectedTabIcon { get; }
    }
}
