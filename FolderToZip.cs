using System.IO;
using System.IO.Compression;
class Program {
    static void Main(string[] args) {
        foreach (var srcDir in args) {
            string dstFile = srcDir.TrimEnd('\\', '/') + ".zip";
            File.Delete(dstFile);
            ZipFile.CreateFromDirectory(srcDir, dstFile, CompressionLevel.Optimal, true);
        }
    }
}
