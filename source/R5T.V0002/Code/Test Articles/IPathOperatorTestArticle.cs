using System;

using R5T.T0243;


namespace R5T.V0002
{
    [TestArticleMarker]
    public partial interface IPathOperatorTestArticle : ITestArticleMarker
    {
        string Combine_ToFilePath(string[] pathParts);
        bool Is_FileIndicated(string path);
        bool Is_Windows(string path);
    }
}
