using System;

using R5T.L0087.T000;
using R5T.T0131;


namespace R5T.V0002.Z001.Raw
{
    /// <summary>
    /// Raw path operation expectation values.
    /// </summary>
    [ValuesMarker]
    public partial interface IExpectations : IValuesMarker
    {
        /// Things I want to test:
        /// Is_WindowsPath_True


        /// <summary>
        /// <inheritdoc cref="Z0066.IWindowsPaths.C_Directory01" path="/descendant::value"/> -> <inheritdoc cref="L0066.IValues.True" path="/descendant::value"/>
        /// </summary>
        public IExpectation<string, bool> N001 => Expectation.From(
            Instances.WindowsPaths.C_Directory01,
            Instances.Values.True);

        /// <summary>
        /// <inheritdoc cref="Z0066.IWindowsPaths.C_Directory01" path="/descendant::value"/> -> <inheritdoc cref="L0066.IValues.False" path="/descendant::value"/> (should fail)
        /// </summary>
        public IExpectation<string, bool> N002 => Expectation.From(
            Instances.WindowsPaths.C_Directory01,
            Instances.Values.False);

        /// <summary>
        /// <inheritdoc cref="Z0066.IPathPartSets.C_Directory01_Directory02_File03_txt" path="/summary"/>
        /// <para>-> <inheritdoc cref="Z0066.IFilePaths.C_Directory01_Directory02_File03_txt" path="/descendant::value"/></para>
        /// </summary>
        public IExpectation<string[], string> N003 => Expectation.From(
            Instances.PathPartSets.C_Directory01_Directory02_File03_txt,
            Instances.FilePaths.C_Directory01_Directory02_File03_txt);
    }
}
