using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDS.RDF.Parsing;
using VDS.RDF;

namespace dotNetRdf.Samples.Tutorials
{
    internal class ReadGraphFromFile
    {
        public static void Main()
        {
            IGraph g = new Graph();
            IGraph h = new Graph();
            TurtleParser ttlParser = new ();

            //Load using a Filename
            ttlParser.Load(g, Path.Join("resources", "example.ttl"));
            Console.WriteLine($"Read {g.Triples.Count} triples from 'example.ttl'");

            //Load using a StreamReader
            ttlParser.Load(h, new StreamReader(Path.Join("resources", "example.ttl")));
            Console.WriteLine($"Read {g.Triples.Count} triples from 'example.ttl'");
        }
    }
}
