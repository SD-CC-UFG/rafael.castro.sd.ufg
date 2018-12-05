// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServidorNomes.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServidorNomes {
  public static partial class Nomes
  {
    static readonly string __ServiceName = "ServidorNomes.Nomes";

    static readonly grpc::Marshaller<global::ServidorNomes.RegistroServico> __Marshaller_ServidorNomes_RegistroServico = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorNomes.RegistroServico.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorNomes.ServicoResponse> __Marshaller_ServidorNomes_ServicoResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorNomes.ServicoResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorNomes.ServicoRequest> __Marshaller_ServidorNomes_ServicoRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorNomes.ServicoRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::ServidorNomes.RegistroServico, global::ServidorNomes.ServicoResponse> __Method_Cadastrar = new grpc::Method<global::ServidorNomes.RegistroServico, global::ServidorNomes.ServicoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Cadastrar",
        __Marshaller_ServidorNomes_RegistroServico,
        __Marshaller_ServidorNomes_ServicoResponse);

    static readonly grpc::Method<global::ServidorNomes.ServicoRequest, global::ServidorNomes.ServicoResponse> __Method_ObterServico = new grpc::Method<global::ServidorNomes.ServicoRequest, global::ServidorNomes.ServicoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ObterServico",
        __Marshaller_ServidorNomes_ServicoRequest,
        __Marshaller_ServidorNomes_ServicoResponse);

    static readonly grpc::Method<global::ServidorNomes.RegistroServico, global::ServidorNomes.ServicoResponse> __Method_AtualizarEstado = new grpc::Method<global::ServidorNomes.RegistroServico, global::ServidorNomes.ServicoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AtualizarEstado",
        __Marshaller_ServidorNomes_RegistroServico,
        __Marshaller_ServidorNomes_ServicoResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServidorNomes.ServidorNomesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Nomes</summary>
    public abstract partial class NomesBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ServidorNomes.ServicoResponse> Cadastrar(global::ServidorNomes.RegistroServico request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServidorNomes.ServicoResponse> ObterServico(global::ServidorNomes.ServicoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServidorNomes.ServicoResponse> AtualizarEstado(global::ServidorNomes.RegistroServico request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Nomes</summary>
    public partial class NomesClient : grpc::ClientBase<NomesClient>
    {
      /// <summary>Creates a new client for Nomes</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NomesClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Nomes that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NomesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NomesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NomesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ServidorNomes.ServicoResponse Cadastrar(global::ServidorNomes.RegistroServico request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Cadastrar(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorNomes.ServicoResponse Cadastrar(global::ServidorNomes.RegistroServico request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Cadastrar, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorNomes.ServicoResponse> CadastrarAsync(global::ServidorNomes.RegistroServico request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CadastrarAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorNomes.ServicoResponse> CadastrarAsync(global::ServidorNomes.RegistroServico request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Cadastrar, null, options, request);
      }
      public virtual global::ServidorNomes.ServicoResponse ObterServico(global::ServidorNomes.ServicoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ObterServico(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorNomes.ServicoResponse ObterServico(global::ServidorNomes.ServicoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ObterServico, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorNomes.ServicoResponse> ObterServicoAsync(global::ServidorNomes.ServicoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ObterServicoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorNomes.ServicoResponse> ObterServicoAsync(global::ServidorNomes.ServicoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ObterServico, null, options, request);
      }
      public virtual global::ServidorNomes.ServicoResponse AtualizarEstado(global::ServidorNomes.RegistroServico request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AtualizarEstado(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorNomes.ServicoResponse AtualizarEstado(global::ServidorNomes.RegistroServico request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AtualizarEstado, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorNomes.ServicoResponse> AtualizarEstadoAsync(global::ServidorNomes.RegistroServico request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AtualizarEstadoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorNomes.ServicoResponse> AtualizarEstadoAsync(global::ServidorNomes.RegistroServico request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AtualizarEstado, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NomesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NomesClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NomesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Cadastrar, serviceImpl.Cadastrar)
          .AddMethod(__Method_ObterServico, serviceImpl.ObterServico)
          .AddMethod(__Method_AtualizarEstado, serviceImpl.AtualizarEstado).Build();
    }

  }
}
#endregion
