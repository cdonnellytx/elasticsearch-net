// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Threading.Tasks;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.Eql.Delete
{
	public class EqlDeleteUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await DELETE("/_eql/search/search_id")
			.Fluent(c => c.Eql.Delete("search_id", f => f))
			.Request(c => c.Eql.Delete(new EqlDeleteRequest("search_id")))
			.FluentAsync(c => c.Eql.DeleteAsync("search_id", f => f))
			.RequestAsync(c => c.Eql.DeleteAsync(new EqlDeleteRequest("search_id")));
	}
}
