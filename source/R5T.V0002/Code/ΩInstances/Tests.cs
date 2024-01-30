using System;


namespace R5T.V0002
{
    public class Tests : ITests
    {
        #region Infrastructure

        public static ITests Instance { get; } = new Tests();


        private Tests()
        {
        }

        #endregion
    }
}
