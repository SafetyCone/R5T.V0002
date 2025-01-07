using System;


namespace R5T.V0002.Z001
{
    public static class Instances
    {
        public static L0066.IArrayOperator ArrayOperator => L0066.ArrayOperator.Instance;
        public static IDayOfWeekExpectationPairSets DayOfWeekExpectationPairSets => Z001.DayOfWeekExpectationPairSets.Instance;
        public static L0066.IDayOfWeekOperator DayOfWeekOperator => L0066.DayOfWeekOperator.Instance;
        public static IDayOfWeekSets DayOfWeekSets => Z001.DayOfWeekSets.Instance;
        public static L0066.IDictionaryOperator DictionaryOperator => L0066.DictionaryOperator.Instance;
        public static L0066.IEnumerableOperator EnumerableOperator => L0066.EnumerableOperator.Instance;
        public static L0066.IEqualityOperator EqualityOperator => L0066.EqualityOperator.Instance;
        public static L0087.F000.IExpectationOperator ExpectationOperator => L0087.F000.ExpectationOperator.Instance;
        public static Z0066.IFilePaths FilePaths => Z0066.FilePaths.Instance;
        public static Z0066.IPathPartSets PathPartSets => Z0066.PathPartSets.Instance;
        public static Z0066.IWindowsPaths WindowsPaths => Z0066.WindowsPaths.Instance;
        public static IValues Values => Z001.Values.Instance;
    }
}