using System;

namespace DataAccessLibrary.HSPMelt
{
    public partial class BagHouse
    {
        partial void OnCreated()
        {
            UpdateDate = DateTime.Now;
        }
    }
}
