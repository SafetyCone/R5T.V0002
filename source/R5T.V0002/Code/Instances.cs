using System;


namespace R5T.V0002
{
    public static class Instances
    {
        public static IExpectations Expectations => V0002.Expectations.Instance;
        public static IPaths Paths => V0002.Paths.Instance;
        public static ITestGenerator TestGenerator => V0002.TestGenerator.Instance;
        public static L0087.F001.ITestOperator TestOperator => L0087.F001.TestOperator.Instance;
        public static L0066.IValues Values => L0066.Values.Instance;
    }
}