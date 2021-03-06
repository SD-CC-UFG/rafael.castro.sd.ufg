// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServidorAutenticacao.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServidorAutenticacao {
  public static partial class Autenticacao
  {
    static readonly string __ServiceName = "ServidorAutenticacao.Autenticacao";

    static readonly grpc::Marshaller<global::ServidorUsuarios.RegistroUsuario> __Marshaller_ServidorUsuarios_RegistroUsuario = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorUsuarios.RegistroUsuario.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorAutenticacao.AutResponse> __Marshaller_ServidorAutenticacao_AutResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorAutenticacao.AutResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ServidorUsuarios.RegistroUsuario, global::ServidorAutenticacao.AutResponse> __Method_Autenticar = new grpc::Method<global::ServidorUsuarios.RegistroUsuario, global::ServidorAutenticacao.AutResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Autenticar",
        __Marshaller_ServidorUsuarios_RegistroUsuario,
        __Marshaller_ServidorAutenticacao_AutResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServidorAutenticacao.ServidorAutenticacaoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Autenticacao</summary>
    public abstract partial class AutenticacaoBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ServidorAutenticacao.AutResponse> Autenticar(global::ServidorUsuarios.RegistroUsuario request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Autenticacao</summary>
    public partial class AutenticacaoClient : grpc::ClientBase<AutenticacaoClient>
    {
      /// <summary>Creates a new client for Autenticacao</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AutenticacaoClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Autenticacao that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AutenticacaoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AutenticacaoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AutenticacaoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ServidorAutenticacao.AutResponse Autenticar(global::ServidorUsuarios.RegistroUsuario request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Autenticar(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorAutenticacao.AutResponse Autenticar(global::ServidorUsuarios.RegistroUsuario request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Autenticar, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorAutenticacao.AutResponse> AutenticarAsync(global::ServidorUsuarios.RegistroUsuario request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AutenticarAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorAutenticacao.AutResponse> AutenticarAsync(global::ServidorUsuarios.RegistroUsuario request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Autenticar, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AutenticacaoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AutenticacaoClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AutenticacaoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Autenticar, serviceImpl.Autenticar).Build();
    }

  }
}
#endregion
