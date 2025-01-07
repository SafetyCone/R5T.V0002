using System;


namespace R5T.V0002.Z001
{
    public class DayOfWeekExpectationPairs : IDayOfWeekExpectationPairs
    {
        #region Infrastructure

        public static IDayOfWeekExpectationPairs Instance { get; } = new DayOfWeekExpectationPairs();


        private DayOfWeekExpectationPairs()
        {
        }

        #endregion
    }
}


namespace R5T.V0002.Z001.Raw
{
    public class DayOfWeekExpectationPairs : IDayOfWeekExpectationPairs
    {
        #region Infrastructure

        public static IDayOfWeekExpectationPairs Instance { get; } = new DayOfWeekExpectationPairs();


        private DayOfWeekExpectationPairs()
        {
        }

        #endregion
    }
}