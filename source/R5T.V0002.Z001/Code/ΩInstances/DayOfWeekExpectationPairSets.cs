using System;


namespace R5T.V0002.Z001
{
    public class DayOfWeekExpectationPairSets : IDayOfWeekExpectationPairSets
    {
        #region Infrastructure

        public static IDayOfWeekExpectationPairSets Instance { get; } = new DayOfWeekExpectationPairSets();


        private DayOfWeekExpectationPairSets()
        {
        }

        #endregion
    }
}


namespace R5T.V0002.Z001.Raw
{
    public class DayOfWeekExpectationPairSets : IDayOfWeekExpectationPairSets
    {
        #region Infrastructure

        public static IDayOfWeekExpectationPairSets Instance { get; } = new DayOfWeekExpectationPairSets();


        private DayOfWeekExpectationPairSets()
        {
        }

        #endregion
    }
}