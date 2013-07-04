using System.IO.Compression;
class Program {
    static void Main(string[] args) {
        ZipFile.CreateFromDirectory(args[0], args[0] + ".zip", CompressionLevel.Optimal, true);
    }
}
