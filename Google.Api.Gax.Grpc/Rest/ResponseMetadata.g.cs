// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: response_metadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api.Gax.Grpc.Rest {

  /// <summary>Holder for reflection information generated from response_metadata.proto</summary>
  internal static partial class ResponseMetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for response_metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResponseMetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdyZXNwb25zZV9tZXRhZGF0YS5wcm90bxIYZ29vZ2xlLmFwaS5nYXguZ3Jw",
            "Yy5yZXN0Ghlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvGhVnb29nbGUvcnBj",
            "L2NvZGUucHJvdG8i+wEKBUVycm9yEjUKBWVycm9yGAEgASgLMiYuZ29vZ2xl",
            "LmFwaS5nYXguZ3JwYy5yZXN0LkVycm9yLlN0YXR1cxoMCgpFcnJvclByb3Rv",
            "GqwBCgZTdGF0dXMSDAoEY29kZRgBIAEoBRIPCgdtZXNzYWdlGAIgASgJEjoK",
            "BmVycm9ycxgDIAMoCzIqLmdvb2dsZS5hcGkuZ2F4LmdycGMucmVzdC5FcnJv",
            "ci5FcnJvclByb3RvEiAKBnN0YXR1cxgEIAEoDjIQLmdvb2dsZS5ycGMuQ29k",
            "ZRIlCgdkZXRhaWxzGAUgAygLMhQuZ29vZ2xlLnByb3RvYnVmLkFueWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Rpc.CodeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Gax.Grpc.Rest.Error), global::Google.Api.Gax.Grpc.Rest.Error.Parser, new[]{ "Error_" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Gax.Grpc.Rest.Error.Types.ErrorProto), global::Google.Api.Gax.Grpc.Rest.Error.Types.ErrorProto.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Gax.Grpc.Rest.Error.Types.Status), global::Google.Api.Gax.Grpc.Rest.Error.Types.Status.Parser, new[]{ "Code", "Message", "Errors", "Status_", "Details" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// This message defines the error schema for Google's JSON HTTP APIs.
  /// </summary>
  internal sealed partial class Error : pb::IMessage<Error>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Error> _parser = new pb::MessageParser<Error>(() => new Error());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Error> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.Gax.Grpc.Rest.ResponseMetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Error() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Error(Error other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Error Clone() {
      return new Error(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int Error_FieldNumber = 1;
    private global::Google.Api.Gax.Grpc.Rest.Error.Types.Status error_;
    /// <summary>
    /// The actual error payload. The nested message structure is for backward
    /// compatibility with [Google API Client
    /// Libraries](https://developers.google.com/api-client-library). It also
    /// makes the error more readable to developers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Api.Gax.Grpc.Rest.Error.Types.Status Error_ {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Error);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Error other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error_, other.Error_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (error_ != null) hash ^= Error_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (error_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Error_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (error_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Error_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (error_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Error other) {
      if (other == null) {
        return;
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error_ = new global::Google.Api.Gax.Grpc.Rest.Error.Types.Status();
        }
        Error_.MergeFrom(other.Error_);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (error_ == null) {
              Error_ = new global::Google.Api.Gax.Grpc.Rest.Error.Types.Status();
            }
            input.ReadMessage(Error_);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (error_ == null) {
              Error_ = new global::Google.Api.Gax.Grpc.Rest.Error.Types.Status();
            }
            input.ReadMessage(Error_);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Error message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Deprecated. This message is only used by error format v1.
      /// </summary>
      internal sealed partial class ErrorProto : pb::IMessage<ErrorProto>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<ErrorProto> _parser = new pb::MessageParser<ErrorProto>(() => new ErrorProto());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<ErrorProto> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Api.Gax.Grpc.Rest.Error.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ErrorProto() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ErrorProto(ErrorProto other) : this() {
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ErrorProto Clone() {
          return new ErrorProto(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as ErrorProto);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(ErrorProto other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(ErrorProto other) {
          if (other == null) {
            return;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
            }
          }
        }
        #endif

      }

      /// <summary>
      /// This message has the same semantics as `google.rpc.Status`. It uses HTTP
      /// status code instead of gRPC status code. It has extra fields `status` and
      /// `errors` for backward compatibility with [Google API Client
      /// Libraries](https://developers.google.com/api-client-library).
      /// </summary>
      internal sealed partial class Status : pb::IMessage<Status>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Status> _parser = new pb::MessageParser<Status>(() => new Status());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Status> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Api.Gax.Grpc.Rest.Error.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Status() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Status(Status other) : this() {
          code_ = other.code_;
          message_ = other.message_;
          errors_ = other.errors_.Clone();
          status_ = other.status_;
          details_ = other.details_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Status Clone() {
          return new Status(this);
        }

        /// <summary>Field number for the "code" field.</summary>
        public const int CodeFieldNumber = 1;
        private int code_;
        /// <summary>
        /// The HTTP status code that corresponds to `google.rpc.Status.code`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int Code {
          get { return code_; }
          set {
            code_ = value;
          }
        }

        /// <summary>Field number for the "message" field.</summary>
        public const int MessageFieldNumber = 2;
        private string message_ = "";
        /// <summary>
        /// This corresponds to `google.rpc.Status.message`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Message {
          get { return message_; }
          set {
            message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "errors" field.</summary>
        public const int ErrorsFieldNumber = 3;
        private static readonly pb::FieldCodec<global::Google.Api.Gax.Grpc.Rest.Error.Types.ErrorProto> _repeated_errors_codec
            = pb::FieldCodec.ForMessage(26, global::Google.Api.Gax.Grpc.Rest.Error.Types.ErrorProto.Parser);
        private readonly pbc::RepeatedField<global::Google.Api.Gax.Grpc.Rest.Error.Types.ErrorProto> errors_ = new pbc::RepeatedField<global::Google.Api.Gax.Grpc.Rest.Error.Types.ErrorProto>();
        /// <summary>
        /// Deprecated. This field is only used by error format v1.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Google.Api.Gax.Grpc.Rest.Error.Types.ErrorProto> Errors {
          get { return errors_; }
        }

        /// <summary>Field number for the "status" field.</summary>
        public const int Status_FieldNumber = 4;
        private global::Google.Rpc.Code status_ = global::Google.Rpc.Code.Ok;
        /// <summary>
        /// This is the enum version for `google.rpc.Status.code`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Rpc.Code Status_ {
          get { return status_; }
          set {
            status_ = value;
          }
        }

        /// <summary>Field number for the "details" field.</summary>
        public const int DetailsFieldNumber = 5;
        private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_details_codec
            = pb::FieldCodec.ForMessage(42, global::Google.Protobuf.WellKnownTypes.Any.Parser);
        private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> details_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
        /// <summary>
        /// This corresponds to `google.rpc.Status.details`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> Details {
          get { return details_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Status);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Status other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Code != other.Code) return false;
          if (Message != other.Message) return false;
          if(!errors_.Equals(other.errors_)) return false;
          if (Status_ != other.Status_) return false;
          if(!details_.Equals(other.details_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Code != 0) hash ^= Code.GetHashCode();
          if (Message.Length != 0) hash ^= Message.GetHashCode();
          hash ^= errors_.GetHashCode();
          if (Status_ != global::Google.Rpc.Code.Ok) hash ^= Status_.GetHashCode();
          hash ^= details_.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (Code != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Code);
          }
          if (Message.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Message);
          }
          errors_.WriteTo(output, _repeated_errors_codec);
          if (Status_ != global::Google.Rpc.Code.Ok) {
            output.WriteRawTag(32);
            output.WriteEnum((int) Status_);
          }
          details_.WriteTo(output, _repeated_details_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (Code != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Code);
          }
          if (Message.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Message);
          }
          errors_.WriteTo(ref output, _repeated_errors_codec);
          if (Status_ != global::Google.Rpc.Code.Ok) {
            output.WriteRawTag(32);
            output.WriteEnum((int) Status_);
          }
          details_.WriteTo(ref output, _repeated_details_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (Code != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
          }
          if (Message.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
          }
          size += errors_.CalculateSize(_repeated_errors_codec);
          if (Status_ != global::Google.Rpc.Code.Ok) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status_);
          }
          size += details_.CalculateSize(_repeated_details_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Status other) {
          if (other == null) {
            return;
          }
          if (other.Code != 0) {
            Code = other.Code;
          }
          if (other.Message.Length != 0) {
            Message = other.Message;
          }
          errors_.Add(other.errors_);
          if (other.Status_ != global::Google.Rpc.Code.Ok) {
            Status_ = other.Status_;
          }
          details_.Add(other.details_);
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                Code = input.ReadInt32();
                break;
              }
              case 18: {
                Message = input.ReadString();
                break;
              }
              case 26: {
                errors_.AddEntriesFrom(input, _repeated_errors_codec);
                break;
              }
              case 32: {
                Status_ = (global::Google.Rpc.Code) input.ReadEnum();
                break;
              }
              case 42: {
                details_.AddEntriesFrom(input, _repeated_details_codec);
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 8: {
                Code = input.ReadInt32();
                break;
              }
              case 18: {
                Message = input.ReadString();
                break;
              }
              case 26: {
                errors_.AddEntriesFrom(ref input, _repeated_errors_codec);
                break;
              }
              case 32: {
                Status_ = (global::Google.Rpc.Code) input.ReadEnum();
                break;
              }
              case 42: {
                details_.AddEntriesFrom(ref input, _repeated_details_codec);
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
