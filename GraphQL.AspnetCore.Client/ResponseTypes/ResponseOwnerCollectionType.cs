using GraphQLDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.AspnetCore.Client.ResponseTypes
{
    public class ResponseOwnerCollectionType
    {
        public List<Owner> Owners { get; set; }
    }
}
