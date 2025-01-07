using System;


namespace R5T.V0002.Z001
{
    public class DayOfWeekSets : IDayOfWeekSets
    {
        #region Infrastructure

        public static IDayOfWeekSets Instance { get; } = new DayOfWeekSets();


        private DayOfWeekSets()
        {
        }

        #endregion
    }
}
