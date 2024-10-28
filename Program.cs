using Microsoft.CodeAnalysis.CSharp.BannedApiAnalyzers;

internal class Program
{
    private static void Main(string[] args)
    {
        CSharpSymbolIsBannedAnalyzer analyzer = new();
    }
}