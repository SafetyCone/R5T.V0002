using System;


namespace R5T.V0002
{
    public class TestMethods : ITestMethods
    {
        #region Infrastructure

        public static ITestMethods Instance { get; } = new TestMethods();


        private TestMethods()
        {
        }

        #endregion
    }
}
