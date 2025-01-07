using System;


namespace R5T.V0002.Z001
{
    public class DayOfWeekExpectationSets : IDayOfWeekExpectationSets
    {
        #region Infrastructure

        public static IDayOfWeekExpectationSets Instance { get; } = new DayOfWeekExpectationSets();


        private DayOfWeekExpectationSets()
        {
        }

        #endregion
    }
}


namespace R5T.V0002.Z001.Raw
{
    public class DayOfWeekExpectationSets : IDayOfWeekExpectationSets
    {
        #region Infrastructure

        public static IDayOfWeekExpectationSets Instance { get; } = new DayOfWeekExpectationSets();


        private DayOfWeekExpectationSets()
        {
        }

        #endregion
    }
}