using System;


namespace R5T.V0002
{
    public class TestGenerator : ITestGenerator
    {
        #region Infrastructure

        public static ITestGenerator Instance { get; } = new TestGenerator();


        private TestGenerator()
        {
        }

        #endregion
    }
}
