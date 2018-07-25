// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: device_catalog.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace GrpcDeviceCatalog {
  public static partial class DeviceCatalog
  {
    static readonly string __ServiceName = "GrpcDeviceCatalog.DeviceCatalog";

    static readonly grpc::Marshaller<global::GrpcDeviceCatalog.GetCatalogRequest> __Marshaller_GetCatalogRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDeviceCatalog.GetCatalogRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcDeviceCatalog.GetCatalogReply> __Marshaller_GetCatalogReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDeviceCatalog.GetCatalogReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest> __Marshaller_DeviceCatalogSubscribeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply> __Marshaller_DeviceCatalogSubscribeReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcDeviceCatalog.GetCatalogRequest, global::GrpcDeviceCatalog.GetCatalogReply> __Method_GetCatalog = new grpc::Method<global::GrpcDeviceCatalog.GetCatalogRequest, global::GrpcDeviceCatalog.GetCatalogReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCatalog",
        __Marshaller_GetCatalogRequest,
        __Marshaller_GetCatalogReply);

    static readonly grpc::Method<global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest, global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply> __Method_DeviceCatalogSubscribe = new grpc::Method<global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest, global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeviceCatalogSubscribe",
        __Marshaller_DeviceCatalogSubscribeRequest,
        __Marshaller_DeviceCatalogSubscribeReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcDeviceCatalog.DeviceCatalogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DeviceCatalog</summary>
    public abstract partial class DeviceCatalogBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcDeviceCatalog.GetCatalogReply> GetCatalog(global::GrpcDeviceCatalog.GetCatalogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply> DeviceCatalogSubscribe(global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DeviceCatalog</summary>
    public partial class DeviceCatalogClient : grpc::ClientBase<DeviceCatalogClient>
    {
      /// <summary>Creates a new client for DeviceCatalog</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DeviceCatalogClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DeviceCatalog that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DeviceCatalogClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DeviceCatalogClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DeviceCatalogClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcDeviceCatalog.GetCatalogReply GetCatalog(global::GrpcDeviceCatalog.GetCatalogRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCatalog(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcDeviceCatalog.GetCatalogReply GetCatalog(global::GrpcDeviceCatalog.GetCatalogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCatalog, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDeviceCatalog.GetCatalogReply> GetCatalogAsync(global::GrpcDeviceCatalog.GetCatalogRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCatalogAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDeviceCatalog.GetCatalogReply> GetCatalogAsync(global::GrpcDeviceCatalog.GetCatalogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCatalog, null, options, request);
      }
      public virtual global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply DeviceCatalogSubscribe(global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeviceCatalogSubscribe(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply DeviceCatalogSubscribe(global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeviceCatalogSubscribe, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply> DeviceCatalogSubscribeAsync(global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeviceCatalogSubscribeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDeviceCatalog.DeviceCatalogSubscribeReply> DeviceCatalogSubscribeAsync(global::GrpcDeviceCatalog.DeviceCatalogSubscribeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeviceCatalogSubscribe, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DeviceCatalogClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DeviceCatalogClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DeviceCatalogBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCatalog, serviceImpl.GetCatalog)
          .AddMethod(__Method_DeviceCatalogSubscribe, serviceImpl.DeviceCatalogSubscribe).Build();
    }

  }
}
#endregion