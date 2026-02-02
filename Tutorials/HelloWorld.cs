using VDS.RDF;
using VDS.RDF.Writing;

namespace dotNetRdf.Samples.Tutorials;

public class HelloWorld
{
    public static void Run()
    {
        Graph g = new ();

        IUriNode dotNetRDF = g.CreateUriNode(new Uri("http://www.dotnetrdf.org"));
        IUriNode says = g.CreateUriNode(new Uri("http://example.org/says"));
        ILiteralNode helloWorld = g.CreateLiteralNode("Hello World");
        ILiteralNode bonjourMonde = g.CreateLiteralNode("Bonjour tout le Monde", "fr");

        g.Assert(new Triple(dotNetRDF, says, helloWorld));
        g.Assert(new Triple(dotNetRDF, says, bonjourMonde));

        Console.WriteLine($"Asserted {g.Triples.Count} triples");
        foreach (Triple t in g.Triples)
        {
            Console.WriteLine(t.ToString());
        }

        NTriplesWriter ntwriter = new ();
        ntwriter.Save(g, "HelloWorld.nt");
        Console.WriteLine("Saved graph to 'HelloWorld.nt'");

        RdfXmlWriter rdfxmlwriter = new ();
        rdfxmlwriter.Save(g, "HelloWorld.rdf");
        Console.WriteLine("Saved graph to 'HelloWorld.rdf'");
    }
}

