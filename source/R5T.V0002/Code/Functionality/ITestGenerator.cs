using System;

using R5T.L0087.T000;
using R5T.T0132;


namespace R5T.V0002
{
    [FunctionalityMarker]
    public partial interface ITestGenerator : IFunctionalityMarker
    {
        public SynchronousFunctionTest<string, bool> Get_Is_WindowsPath_True(IPathOperatorTestArticle testArticle)
            => FunctionTest.From(
                testArticle.Is_Windows,
                Instances.Expectations.Is_WindowsPath_True);
    }
}
