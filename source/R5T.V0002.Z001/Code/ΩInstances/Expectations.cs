using System;


namespace R5T.V0002.Z001
{
    public class Expectations : IExpectations
    {
        #region Infrastructure

        public static IExpectations Instance { get; } = new Expectations();


        private Expectations()
        {
        }

        #endregion
    }
}


namespace R5T.V0002.Z001.Raw
{
    public class Expectations : IExpectations
    {
        #region Infrastructure

        public static IExpectations Instance { get; } = new Expectations();


        private Expectations()
        {
        }

        #endregion
    }
}

