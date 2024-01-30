using System;


namespace R5T.V0002.Z001
{
    public static class Instances
    {
        public static Z0066.IFilePaths FilePaths => Z0066.FilePaths.Instance;
        public static Z0066.IPathPartSets PathPartSets => Z0066.PathPartSets.Instance;
        public static Z0066.IWindowsPaths WindowsPaths => Z0066.WindowsPaths.Instance;
        public static IValues Values => Z001.Values.Instance;
    }
}