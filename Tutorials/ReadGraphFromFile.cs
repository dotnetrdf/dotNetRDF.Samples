using VDS.RDF.Parsing;
using VDS.RDF;

namespace dotNetRdf.Samples.Tutorials;

internal class ReadGraphFromFile
{
    public static void Run()
    {
        Graph g = new ();
        Graph  h = new ();
        TurtleParser ttlParser = new ();

        //Load using a Filename
        ttlParser.Load(g, Path.Join("resources", "example.ttl"));
        Console.WriteLine($"Read {g.Triples.Count} triples from 'example.ttl' using file name.");

        //Load using a StreamReader
        ttlParser.Load(h, new StreamReader(Path.Join("resources", "example.ttl")));
        Console.WriteLine($"Read {g.Triples.Count} triples from 'example.ttl' using StreamReader.");
    }
}
