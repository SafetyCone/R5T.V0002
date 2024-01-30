using System;


namespace R5T.V0002
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
