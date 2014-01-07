﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrightstarDB.EntityFramework.Query
{
    /// <summary>
    /// Manages the context information required during the processing of an entity framework query into SPARQL
    /// </summary>
    public class SparqlQueryContext
    {
        /// <summary>
        /// Get the SPARQL query that is generated from the LINQ
        /// </summary>
        public string SparqlQuery { get; private set; }
        /// <summary>
        /// Gets the list of tuples that map anonymous type members in the LINQ query result to SPARQL variables in the SPARQL query result
        /// </summary>
        public List<Tuple<string, string>> AnonymousMembersMap { get; private set; }

        /// <summary>
        /// If true the result is expected to have triples and their subjects grouped.For each subject group a new entity is created.
        /// </summary>
        public bool ExpectTriplesWithOrderedSubjects { get; set; }

        internal SparqlQueryContext()
        {
            AnonymousMembersMap = new List<Tuple<string, string>>();
        }

        /// <summary>
        /// Creates a new SparqlQueryContext instance
        /// </summary>
        /// <param name="sparqlQuery">sparql query</param>
        public SparqlQueryContext(string sparqlQuery)
        {
            SparqlQuery = sparqlQuery;
        }

        /// <summary>
        /// Creates a new SparqlQueryContext instance
        /// </summary>
        /// <param name="sparqlQuery">sparql query</param>
        /// <param name="anonymousMembersMap">mappings for anonymous types</param>
        public SparqlQueryContext(string sparqlQuery, List<Tuple<string, string>> anonymousMembersMap) :this(sparqlQuery)
        {
            AnonymousMembersMap = anonymousMembersMap;
        }
    }
}
