// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using static Elasticsearch.Net.HttpMethod;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.IngestApi
{
	///<summary>
	/// Logically groups all Ingest API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticLowLevelClient.Ingest"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelIngestNamespace : NamespacedClientProxy
	{
		internal LowLevelIngestNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_ingest/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeletePipeline<TResponse>(string id, DeletePipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_ingest/pipeline/{id:id}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_ingest/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> DeletePipelineAsync<TResponse>(string id, DeletePipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_ingest/pipeline/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/pipeline <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetPipeline<TResponse>(GetPipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_ingest/pipeline", null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/pipeline <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GetPipelineAsync<TResponse>(GetPipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_ingest/pipeline", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "id">Comma separated list of pipeline ids. Wildcards supported</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetPipeline<TResponse>(string id, GetPipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_ingest/pipeline/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "id">Comma separated list of pipeline ids. Wildcards supported</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GetPipelineAsync<TResponse>(string id, GetPipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_ingest/pipeline/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/processor/grok <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GrokProcessorPatterns<TResponse>(GrokProcessorPatternsRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_ingest/processor/grok", null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/processor/grok <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GrokProcessorPatternsAsync<TResponse>(GrokProcessorPatternsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_ingest/processor/grok", ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_ingest/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "body">The ingest definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutPipeline<TResponse>(string id, PostData body, PutPipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_ingest/pipeline/{id:id}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_ingest/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "body">The ingest definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> PutPipelineAsync<TResponse>(string id, PostData body, PutPipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_ingest/pipeline/{id:id}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_ingest/pipeline/_simulate <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "body">The simulate definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse SimulatePipeline<TResponse>(PostData body, SimulatePipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_ingest/pipeline/_simulate", body, RequestParams(requestParameters));
		///<summary>POST on /_ingest/pipeline/_simulate <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "body">The simulate definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> SimulatePipelineAsync<TResponse>(PostData body, SimulatePipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_ingest/pipeline/_simulate", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_ingest/pipeline/{id}/_simulate <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "body">The simulate definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse SimulatePipeline<TResponse>(string id, PostData body, SimulatePipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"_ingest/pipeline/{id:id}/_simulate"), body, RequestParams(requestParameters));
		///<summary>POST on /_ingest/pipeline/{id}/_simulate <para>https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html</para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "body">The simulate definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> SimulatePipelineAsync<TResponse>(string id, PostData body, SimulatePipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_ingest/pipeline/{id:id}/_simulate"), ctx, body, RequestParams(requestParameters));
	}
}