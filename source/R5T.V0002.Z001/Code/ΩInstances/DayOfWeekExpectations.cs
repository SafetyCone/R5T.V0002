using System;


namespace R5T.V0002.Z001
{
    public class DayOfWeekExpectations : IDayOfWeekExpectations
    {
        #region Infrastructure

        public static IDayOfWeekExpectations Instance { get; } = new DayOfWeekExpectations();


        private DayOfWeekExpectations()
        {
        }

        #endregion
    }
}


namespace R5T.V0002.Z001.Raw
{
    public class DayOfWeekExpectations : IDayOfWeekExpectations
    {
        #region Infrastructure

        public static IDayOfWeekExpectations Instance { get; } = new DayOfWeekExpectations();


        private DayOfWeekExpectations()
        {
        }

        #endregion
    }
}