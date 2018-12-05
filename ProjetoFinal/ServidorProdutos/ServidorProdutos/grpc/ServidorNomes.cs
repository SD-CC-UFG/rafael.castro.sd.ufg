// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServidorNomes.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ServidorNomes {

  /// <summary>Holder for reflection information generated from ServidorNomes.proto</summary>
  public static partial class ServidorNomesReflection {

    #region Descriptor
    /// <summary>File descriptor for ServidorNomes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServidorNomesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNTZXJ2aWRvck5vbWVzLnByb3RvEg1TZXJ2aWRvck5vbWVzImYKD1JlZ2lz",
            "dHJvU2VydmljbxIMCgRob3N0GAEgASgJEg0KBXBvcnRhGAIgASgFEg8KB3Nl",
            "cnZpY28YAyABKAkSJQoGZXN0YWRvGAQgASgLMhUuU2Vydmlkb3JOb21lcy5F",
            "c3RhZG8iJgoGRXN0YWRvEgsKA2NwdRgBIAEoBRIPCgdtZW1vcmlhGAIgASgF",
            "ImIKD1NlcnZpY29SZXNwb25zZRIvCgdzZXJ2aWNvGAEgASgLMh4uU2Vydmlk",
            "b3JOb21lcy5SZWdpc3Ryb1NlcnZpY28SDwoHbWVzc2FnZRgCIAEoCRINCgVl",
            "cnJvchgDIAEoBSI3CglSZWxhdG9yaW8SDAoEaG9zdBgBIAEoCRIcChROdW1l",
            "cm9Db25leG9lc0F0aXZhcxgCIAEoBSIhCg5TZXJ2aWNvUmVxdWVzdBIPCgdz",
            "ZXJ2aWNvGAEgASgJMvwBCgVOb21lcxJNCglDYWRhc3RyYXISHi5TZXJ2aWRv",
            "ck5vbWVzLlJlZ2lzdHJvU2VydmljbxoeLlNlcnZpZG9yTm9tZXMuU2Vydmlj",
            "b1Jlc3BvbnNlIgASTwoMT2J0ZXJTZXJ2aWNvEh0uU2Vydmlkb3JOb21lcy5T",
            "ZXJ2aWNvUmVxdWVzdBoeLlNlcnZpZG9yTm9tZXMuU2Vydmljb1Jlc3BvbnNl",
            "IgASUwoPQXR1YWxpemFyRXN0YWRvEh4uU2Vydmlkb3JOb21lcy5SZWdpc3Ry",
            "b1NlcnZpY28aHi5TZXJ2aWRvck5vbWVzLlNlcnZpY29SZXNwb25zZSIAYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ServidorNomes.RegistroServico), global::ServidorNomes.RegistroServico.Parser, new[]{ "Host", "Porta", "Servico", "Estado" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServidorNomes.Estado), global::ServidorNomes.Estado.Parser, new[]{ "Cpu", "Memoria" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServidorNomes.ServicoResponse), global::ServidorNomes.ServicoResponse.Parser, new[]{ "Servico", "Message", "Error" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServidorNomes.Relatorio), global::ServidorNomes.Relatorio.Parser, new[]{ "Host", "NumeroConexoesAtivas" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServidorNomes.ServicoRequest), global::ServidorNomes.ServicoRequest.Parser, new[]{ "Servico" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RegistroServico : pb::IMessage<RegistroServico> {
    private static readonly pb::MessageParser<RegistroServico> _parser = new pb::MessageParser<RegistroServico>(() => new RegistroServico());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegistroServico> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServidorNomes.ServidorNomesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistroServico() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistroServico(RegistroServico other) : this() {
      host_ = other.host_;
      porta_ = other.porta_;
      servico_ = other.servico_;
      estado_ = other.estado_ != null ? other.estado_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistroServico Clone() {
      return new RegistroServico(this);
    }

    /// <summary>Field number for the "host" field.</summary>
    public const int HostFieldNumber = 1;
    private string host_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Host {
      get { return host_; }
      set {
        host_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "porta" field.</summary>
    public const int PortaFieldNumber = 2;
    private int porta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Porta {
      get { return porta_; }
      set {
        porta_ = value;
      }
    }

    /// <summary>Field number for the "servico" field.</summary>
    public const int ServicoFieldNumber = 3;
    private string servico_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Servico {
      get { return servico_; }
      set {
        servico_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "estado" field.</summary>
    public const int EstadoFieldNumber = 4;
    private global::ServidorNomes.Estado estado_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ServidorNomes.Estado Estado {
      get { return estado_; }
      set {
        estado_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegistroServico);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegistroServico other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Host != other.Host) return false;
      if (Porta != other.Porta) return false;
      if (Servico != other.Servico) return false;
      if (!object.Equals(Estado, other.Estado)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Host.Length != 0) hash ^= Host.GetHashCode();
      if (Porta != 0) hash ^= Porta.GetHashCode();
      if (Servico.Length != 0) hash ^= Servico.GetHashCode();
      if (estado_ != null) hash ^= Estado.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Host.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Host);
      }
      if (Porta != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Porta);
      }
      if (Servico.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Servico);
      }
      if (estado_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Estado);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Host.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Host);
      }
      if (Porta != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Porta);
      }
      if (Servico.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Servico);
      }
      if (estado_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Estado);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegistroServico other) {
      if (other == null) {
        return;
      }
      if (other.Host.Length != 0) {
        Host = other.Host;
      }
      if (other.Porta != 0) {
        Porta = other.Porta;
      }
      if (other.Servico.Length != 0) {
        Servico = other.Servico;
      }
      if (other.estado_ != null) {
        if (estado_ == null) {
          estado_ = new global::ServidorNomes.Estado();
        }
        Estado.MergeFrom(other.Estado);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Host = input.ReadString();
            break;
          }
          case 16: {
            Porta = input.ReadInt32();
            break;
          }
          case 26: {
            Servico = input.ReadString();
            break;
          }
          case 34: {
            if (estado_ == null) {
              estado_ = new global::ServidorNomes.Estado();
            }
            input.ReadMessage(estado_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Estado : pb::IMessage<Estado> {
    private static readonly pb::MessageParser<Estado> _parser = new pb::MessageParser<Estado>(() => new Estado());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Estado> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServidorNomes.ServidorNomesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Estado() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Estado(Estado other) : this() {
      cpu_ = other.cpu_;
      memoria_ = other.memoria_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Estado Clone() {
      return new Estado(this);
    }

    /// <summary>Field number for the "cpu" field.</summary>
    public const int CpuFieldNumber = 1;
    private int cpu_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Cpu {
      get { return cpu_; }
      set {
        cpu_ = value;
      }
    }

    /// <summary>Field number for the "memoria" field.</summary>
    public const int MemoriaFieldNumber = 2;
    private int memoria_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Memoria {
      get { return memoria_; }
      set {
        memoria_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Estado);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Estado other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Cpu != other.Cpu) return false;
      if (Memoria != other.Memoria) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Cpu != 0) hash ^= Cpu.GetHashCode();
      if (Memoria != 0) hash ^= Memoria.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Cpu != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Cpu);
      }
      if (Memoria != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Memoria);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Cpu != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Cpu);
      }
      if (Memoria != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Memoria);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Estado other) {
      if (other == null) {
        return;
      }
      if (other.Cpu != 0) {
        Cpu = other.Cpu;
      }
      if (other.Memoria != 0) {
        Memoria = other.Memoria;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Cpu = input.ReadInt32();
            break;
          }
          case 16: {
            Memoria = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServicoResponse : pb::IMessage<ServicoResponse> {
    private static readonly pb::MessageParser<ServicoResponse> _parser = new pb::MessageParser<ServicoResponse>(() => new ServicoResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServicoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServidorNomes.ServidorNomesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServicoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServicoResponse(ServicoResponse other) : this() {
      servico_ = other.servico_ != null ? other.servico_.Clone() : null;
      message_ = other.message_;
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServicoResponse Clone() {
      return new ServicoResponse(this);
    }

    /// <summary>Field number for the "servico" field.</summary>
    public const int ServicoFieldNumber = 1;
    private global::ServidorNomes.RegistroServico servico_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ServidorNomes.RegistroServico Servico {
      get { return servico_; }
      set {
        servico_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 3;
    private int error_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServicoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServicoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Servico, other.Servico)) return false;
      if (Message != other.Message) return false;
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (servico_ != null) hash ^= Servico.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Error != 0) hash ^= Error.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (servico_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Servico);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (Error != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (servico_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Servico);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Error != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServicoResponse other) {
      if (other == null) {
        return;
      }
      if (other.servico_ != null) {
        if (servico_ == null) {
          servico_ = new global::ServidorNomes.RegistroServico();
        }
        Servico.MergeFrom(other.Servico);
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Error != 0) {
        Error = other.Error;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (servico_ == null) {
              servico_ = new global::ServidorNomes.RegistroServico();
            }
            input.ReadMessage(servico_);
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 24: {
            Error = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Relatorio : pb::IMessage<Relatorio> {
    private static readonly pb::MessageParser<Relatorio> _parser = new pb::MessageParser<Relatorio>(() => new Relatorio());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Relatorio> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServidorNomes.ServidorNomesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Relatorio() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Relatorio(Relatorio other) : this() {
      host_ = other.host_;
      numeroConexoesAtivas_ = other.numeroConexoesAtivas_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Relatorio Clone() {
      return new Relatorio(this);
    }

    /// <summary>Field number for the "host" field.</summary>
    public const int HostFieldNumber = 1;
    private string host_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Host {
      get { return host_; }
      set {
        host_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "NumeroConexoesAtivas" field.</summary>
    public const int NumeroConexoesAtivasFieldNumber = 2;
    private int numeroConexoesAtivas_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumeroConexoesAtivas {
      get { return numeroConexoesAtivas_; }
      set {
        numeroConexoesAtivas_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Relatorio);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Relatorio other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Host != other.Host) return false;
      if (NumeroConexoesAtivas != other.NumeroConexoesAtivas) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Host.Length != 0) hash ^= Host.GetHashCode();
      if (NumeroConexoesAtivas != 0) hash ^= NumeroConexoesAtivas.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Host.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Host);
      }
      if (NumeroConexoesAtivas != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(NumeroConexoesAtivas);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Host.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Host);
      }
      if (NumeroConexoesAtivas != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumeroConexoesAtivas);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Relatorio other) {
      if (other == null) {
        return;
      }
      if (other.Host.Length != 0) {
        Host = other.Host;
      }
      if (other.NumeroConexoesAtivas != 0) {
        NumeroConexoesAtivas = other.NumeroConexoesAtivas;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Host = input.ReadString();
            break;
          }
          case 16: {
            NumeroConexoesAtivas = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServicoRequest : pb::IMessage<ServicoRequest> {
    private static readonly pb::MessageParser<ServicoRequest> _parser = new pb::MessageParser<ServicoRequest>(() => new ServicoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServicoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServidorNomes.ServidorNomesReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServicoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServicoRequest(ServicoRequest other) : this() {
      servico_ = other.servico_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServicoRequest Clone() {
      return new ServicoRequest(this);
    }

    /// <summary>Field number for the "servico" field.</summary>
    public const int ServicoFieldNumber = 1;
    private string servico_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Servico {
      get { return servico_; }
      set {
        servico_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServicoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServicoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Servico != other.Servico) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Servico.Length != 0) hash ^= Servico.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Servico.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Servico);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Servico.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Servico);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServicoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Servico.Length != 0) {
        Servico = other.Servico;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Servico = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
