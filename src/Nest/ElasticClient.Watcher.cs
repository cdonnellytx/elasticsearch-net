// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
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
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.WatcherApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.WatcherApi
{
	///<summary>
	/// Watcher APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.Watcher"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class WatcherNamespace : NamespacedClientProxy
	{
		internal WatcherNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.ack_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</a>
		/// </summary>
		public AcknowledgeWatchResponse Acknowledge(Id watchId, Func<AcknowledgeWatchDescriptor, IAcknowledgeWatchRequest> selector = null) => Acknowledge(selector.InvokeOrDefault(new AcknowledgeWatchDescriptor(watchId: watchId)));
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.ack_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</a>
		/// </summary>
		public Task<AcknowledgeWatchResponse> AcknowledgeAsync(Id watchId, Func<AcknowledgeWatchDescriptor, IAcknowledgeWatchRequest> selector = null, CancellationToken ct = default) => AcknowledgeAsync(selector.InvokeOrDefault(new AcknowledgeWatchDescriptor(watchId: watchId)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.ack_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</a>
		/// </summary>
		public AcknowledgeWatchResponse Acknowledge(IAcknowledgeWatchRequest request) => DoRequest<IAcknowledgeWatchRequest, AcknowledgeWatchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.ack_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</a>
		/// </summary>
		public Task<AcknowledgeWatchResponse> AcknowledgeAsync(IAcknowledgeWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IAcknowledgeWatchRequest, AcknowledgeWatchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.activate_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html</a>
		/// </summary>
		public ActivateWatchResponse Activate(Id watchId, Func<ActivateWatchDescriptor, IActivateWatchRequest> selector = null) => Activate(selector.InvokeOrDefault(new ActivateWatchDescriptor(watchId: watchId)));
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.activate_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html</a>
		/// </summary>
		public Task<ActivateWatchResponse> ActivateAsync(Id watchId, Func<ActivateWatchDescriptor, IActivateWatchRequest> selector = null, CancellationToken ct = default) => ActivateAsync(selector.InvokeOrDefault(new ActivateWatchDescriptor(watchId: watchId)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.activate_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html</a>
		/// </summary>
		public ActivateWatchResponse Activate(IActivateWatchRequest request) => DoRequest<IActivateWatchRequest, ActivateWatchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.activate_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html</a>
		/// </summary>
		public Task<ActivateWatchResponse> ActivateAsync(IActivateWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IActivateWatchRequest, ActivateWatchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.deactivate_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html</a>
		/// </summary>
		public DeactivateWatchResponse Deactivate(Id watchId, Func<DeactivateWatchDescriptor, IDeactivateWatchRequest> selector = null) => Deactivate(selector.InvokeOrDefault(new DeactivateWatchDescriptor(watchId: watchId)));
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.deactivate_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html</a>
		/// </summary>
		public Task<DeactivateWatchResponse> DeactivateAsync(Id watchId, Func<DeactivateWatchDescriptor, IDeactivateWatchRequest> selector = null, CancellationToken ct = default) => DeactivateAsync(selector.InvokeOrDefault(new DeactivateWatchDescriptor(watchId: watchId)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.deactivate_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html</a>
		/// </summary>
		public DeactivateWatchResponse Deactivate(IDeactivateWatchRequest request) => DoRequest<IDeactivateWatchRequest, DeactivateWatchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.deactivate_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html</a>
		/// </summary>
		public Task<DeactivateWatchResponse> DeactivateAsync(IDeactivateWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IDeactivateWatchRequest, DeactivateWatchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>watcher.delete_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html</a>
		/// </summary>
		public DeleteWatchResponse Delete(Id id, Func<DeleteWatchDescriptor, IDeleteWatchRequest> selector = null) => Delete(selector.InvokeOrDefault(new DeleteWatchDescriptor(id: id)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>watcher.delete_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html</a>
		/// </summary>
		public Task<DeleteWatchResponse> DeleteAsync(Id id, Func<DeleteWatchDescriptor, IDeleteWatchRequest> selector = null, CancellationToken ct = default) => DeleteAsync(selector.InvokeOrDefault(new DeleteWatchDescriptor(id: id)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>watcher.delete_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html</a>
		/// </summary>
		public DeleteWatchResponse Delete(IDeleteWatchRequest request) => DoRequest<IDeleteWatchRequest, DeleteWatchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>watcher.delete_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html</a>
		/// </summary>
		public Task<DeleteWatchResponse> DeleteAsync(IDeleteWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteWatchRequest, DeleteWatchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.execute_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</a>
		/// </summary>
		public ExecuteWatchResponse Execute(Func<ExecuteWatchDescriptor, IExecuteWatchRequest> selector = null) => Execute(selector.InvokeOrDefault(new ExecuteWatchDescriptor()));
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.execute_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</a>
		/// </summary>
		public Task<ExecuteWatchResponse> ExecuteAsync(Func<ExecuteWatchDescriptor, IExecuteWatchRequest> selector = null, CancellationToken ct = default) => ExecuteAsync(selector.InvokeOrDefault(new ExecuteWatchDescriptor()), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.execute_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</a>
		/// </summary>
		public ExecuteWatchResponse Execute(IExecuteWatchRequest request) => DoRequest<IExecuteWatchRequest, ExecuteWatchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.execute_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</a>
		/// </summary>
		public Task<ExecuteWatchResponse> ExecuteAsync(IExecuteWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IExecuteWatchRequest, ExecuteWatchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>watcher.get_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html</a>
		/// </summary>
		public GetWatchResponse Get(Id id, Func<GetWatchDescriptor, IGetWatchRequest> selector = null) => Get(selector.InvokeOrDefault(new GetWatchDescriptor(id: id)));
		/// <summary>
		/// <c>GET</c> request to the <c>watcher.get_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html</a>
		/// </summary>
		public Task<GetWatchResponse> GetAsync(Id id, Func<GetWatchDescriptor, IGetWatchRequest> selector = null, CancellationToken ct = default) => GetAsync(selector.InvokeOrDefault(new GetWatchDescriptor(id: id)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>watcher.get_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html</a>
		/// </summary>
		public GetWatchResponse Get(IGetWatchRequest request) => DoRequest<IGetWatchRequest, GetWatchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>watcher.get_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html</a>
		/// </summary>
		public Task<GetWatchResponse> GetAsync(IGetWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IGetWatchRequest, GetWatchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.put_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html</a>
		/// </summary>
		public PutWatchResponse Put(Id id, Func<PutWatchDescriptor, IPutWatchRequest> selector = null) => Put(selector.InvokeOrDefault(new PutWatchDescriptor(id: id)));
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.put_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html</a>
		/// </summary>
		public Task<PutWatchResponse> PutAsync(Id id, Func<PutWatchDescriptor, IPutWatchRequest> selector = null, CancellationToken ct = default) => PutAsync(selector.InvokeOrDefault(new PutWatchDescriptor(id: id)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.put_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html</a>
		/// </summary>
		public PutWatchResponse Put(IPutWatchRequest request) => DoRequest<IPutWatchRequest, PutWatchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>watcher.put_watch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html</a>
		/// </summary>
		public Task<PutWatchResponse> PutAsync(IPutWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IPutWatchRequest, PutWatchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.query_watches</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html</a>
		/// </summary>
		public QueryWatchesResponse QueryWatches(Func<QueryWatchesDescriptor, IQueryWatchesRequest> selector = null) => QueryWatches(selector.InvokeOrDefault(new QueryWatchesDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.query_watches</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html</a>
		/// </summary>
		public Task<QueryWatchesResponse> QueryWatchesAsync(Func<QueryWatchesDescriptor, IQueryWatchesRequest> selector = null, CancellationToken ct = default) => QueryWatchesAsync(selector.InvokeOrDefault(new QueryWatchesDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.query_watches</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html</a>
		/// </summary>
		public QueryWatchesResponse QueryWatches(IQueryWatchesRequest request) => DoRequest<IQueryWatchesRequest, QueryWatchesResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.query_watches</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html</a>
		/// </summary>
		public Task<QueryWatchesResponse> QueryWatchesAsync(IQueryWatchesRequest request, CancellationToken ct = default) => DoRequestAsync<IQueryWatchesRequest, QueryWatchesResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.start</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html</a>
		/// </summary>
		public StartWatcherResponse Start(Func<StartWatcherDescriptor, IStartWatcherRequest> selector = null) => Start(selector.InvokeOrDefault(new StartWatcherDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.start</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html</a>
		/// </summary>
		public Task<StartWatcherResponse> StartAsync(Func<StartWatcherDescriptor, IStartWatcherRequest> selector = null, CancellationToken ct = default) => StartAsync(selector.InvokeOrDefault(new StartWatcherDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.start</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html</a>
		/// </summary>
		public StartWatcherResponse Start(IStartWatcherRequest request) => DoRequest<IStartWatcherRequest, StartWatcherResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.start</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html</a>
		/// </summary>
		public Task<StartWatcherResponse> StartAsync(IStartWatcherRequest request, CancellationToken ct = default) => DoRequestAsync<IStartWatcherRequest, StartWatcherResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>watcher.stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</a>
		/// </summary>
		public WatcherStatsResponse Stats(Func<WatcherStatsDescriptor, IWatcherStatsRequest> selector = null) => Stats(selector.InvokeOrDefault(new WatcherStatsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>watcher.stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</a>
		/// </summary>
		public Task<WatcherStatsResponse> StatsAsync(Func<WatcherStatsDescriptor, IWatcherStatsRequest> selector = null, CancellationToken ct = default) => StatsAsync(selector.InvokeOrDefault(new WatcherStatsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>watcher.stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</a>
		/// </summary>
		public WatcherStatsResponse Stats(IWatcherStatsRequest request) => DoRequest<IWatcherStatsRequest, WatcherStatsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>watcher.stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</a>
		/// </summary>
		public Task<WatcherStatsResponse> StatsAsync(IWatcherStatsRequest request, CancellationToken ct = default) => DoRequestAsync<IWatcherStatsRequest, WatcherStatsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.stop</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html</a>
		/// </summary>
		public StopWatcherResponse Stop(Func<StopWatcherDescriptor, IStopWatcherRequest> selector = null) => Stop(selector.InvokeOrDefault(new StopWatcherDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.stop</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html</a>
		/// </summary>
		public Task<StopWatcherResponse> StopAsync(Func<StopWatcherDescriptor, IStopWatcherRequest> selector = null, CancellationToken ct = default) => StopAsync(selector.InvokeOrDefault(new StopWatcherDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.stop</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html</a>
		/// </summary>
		public StopWatcherResponse Stop(IStopWatcherRequest request) => DoRequest<IStopWatcherRequest, StopWatcherResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>watcher.stop</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html</a>
		/// </summary>
		public Task<StopWatcherResponse> StopAsync(IStopWatcherRequest request, CancellationToken ct = default) => DoRequestAsync<IStopWatcherRequest, StopWatcherResponse>(request, request.RequestParameters, ct);
	}
}