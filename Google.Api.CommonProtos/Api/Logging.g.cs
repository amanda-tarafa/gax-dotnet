/*
 * Copyright 2021 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/logging.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/logging.proto</summary>
  public static partial class LoggingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/logging.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoggingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chhnb29nbGUvYXBpL2xvZ2dpbmcucHJvdG8SCmdvb2dsZS5hcGki1wEKB0xv",
            "Z2dpbmcSRQoVcHJvZHVjZXJfZGVzdGluYXRpb25zGAEgAygLMiYuZ29vZ2xl",
            "LmFwaS5Mb2dnaW5nLkxvZ2dpbmdEZXN0aW5hdGlvbhJFChVjb25zdW1lcl9k",
            "ZXN0aW5hdGlvbnMYAiADKAsyJi5nb29nbGUuYXBpLkxvZ2dpbmcuTG9nZ2lu",
            "Z0Rlc3RpbmF0aW9uGj4KEkxvZ2dpbmdEZXN0aW5hdGlvbhIaChJtb25pdG9y",
            "ZWRfcmVzb3VyY2UYAyABKAkSDAoEbG9ncxgBIAMoCUJuCg5jb20uZ29vZ2xl",
            "LmFwaUIMTG9nZ2luZ1Byb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYXBpL3NlcnZpY2Vjb25maWc7c2VydmljZWNvbmZp",
            "Z6ICBEdBUEliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Logging), global::Google.Api.Logging.Parser, new[]{ "ProducerDestinations", "ConsumerDestinations" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Logging.Types.LoggingDestination), global::Google.Api.Logging.Types.LoggingDestination.Parser, new[]{ "MonitoredResource", "Logs" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Logging configuration of the service.
  ///
  /// The following example shows how to configure logs to be sent to the
  /// producer and consumer projects. In the example, the `activity_history`
  /// log is sent to both the producer and consumer projects, whereas the
  /// `purchase_history` log is only sent to the producer project.
  ///
  ///     monitored_resources:
  ///     - type: library.googleapis.com/branch
  ///       labels:
  ///       - key: /city
  ///         description: The city where the library branch is located in.
  ///       - key: /name
  ///         description: The name of the branch.
  ///     logs:
  ///     - name: activity_history
  ///       labels:
  ///       - key: /customer_id
  ///     - name: purchase_history
  ///     logging:
  ///       producer_destinations:
  ///       - monitored_resource: library.googleapis.com/branch
  ///         logs:
  ///         - activity_history
  ///         - purchase_history
  ///       consumer_destinations:
  ///       - monitored_resource: library.googleapis.com/branch
  ///         logs:
  ///         - activity_history
  /// </summary>
  public sealed partial class Logging : pb::IMessage<Logging>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Logging> _parser = new pb::MessageParser<Logging>(() => new Logging());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Logging> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.LoggingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Logging() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Logging(Logging other) : this() {
      producerDestinations_ = other.producerDestinations_.Clone();
      consumerDestinations_ = other.consumerDestinations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Logging Clone() {
      return new Logging(this);
    }

    /// <summary>Field number for the "producer_destinations" field.</summary>
    public const int ProducerDestinationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Api.Logging.Types.LoggingDestination> _repeated_producerDestinations_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Api.Logging.Types.LoggingDestination.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.Logging.Types.LoggingDestination> producerDestinations_ = new pbc::RepeatedField<global::Google.Api.Logging.Types.LoggingDestination>();
    /// <summary>
    /// Logging configurations for sending logs to the producer project.
    /// There can be multiple producer destinations, each one must have a
    /// different monitored resource type. A log can be used in at most
    /// one producer destination.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Api.Logging.Types.LoggingDestination> ProducerDestinations {
      get { return producerDestinations_; }
    }

    /// <summary>Field number for the "consumer_destinations" field.</summary>
    public const int ConsumerDestinationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Api.Logging.Types.LoggingDestination> _repeated_consumerDestinations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Api.Logging.Types.LoggingDestination.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.Logging.Types.LoggingDestination> consumerDestinations_ = new pbc::RepeatedField<global::Google.Api.Logging.Types.LoggingDestination>();
    /// <summary>
    /// Logging configurations for sending logs to the consumer project.
    /// There can be multiple consumer destinations, each one must have a
    /// different monitored resource type. A log can be used in at most
    /// one consumer destination.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Api.Logging.Types.LoggingDestination> ConsumerDestinations {
      get { return consumerDestinations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Logging);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Logging other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!producerDestinations_.Equals(other.producerDestinations_)) return false;
      if(!consumerDestinations_.Equals(other.consumerDestinations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= producerDestinations_.GetHashCode();
      hash ^= consumerDestinations_.GetHashCode();
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
      producerDestinations_.WriteTo(output, _repeated_producerDestinations_codec);
      consumerDestinations_.WriteTo(output, _repeated_consumerDestinations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      producerDestinations_.WriteTo(ref output, _repeated_producerDestinations_codec);
      consumerDestinations_.WriteTo(ref output, _repeated_consumerDestinations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += producerDestinations_.CalculateSize(_repeated_producerDestinations_codec);
      size += consumerDestinations_.CalculateSize(_repeated_consumerDestinations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Logging other) {
      if (other == null) {
        return;
      }
      producerDestinations_.Add(other.producerDestinations_);
      consumerDestinations_.Add(other.consumerDestinations_);
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
            producerDestinations_.AddEntriesFrom(input, _repeated_producerDestinations_codec);
            break;
          }
          case 18: {
            consumerDestinations_.AddEntriesFrom(input, _repeated_consumerDestinations_codec);
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
            producerDestinations_.AddEntriesFrom(ref input, _repeated_producerDestinations_codec);
            break;
          }
          case 18: {
            consumerDestinations_.AddEntriesFrom(ref input, _repeated_consumerDestinations_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Logging message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Configuration of a specific logging destination (the producer project
      /// or the consumer project).
      /// </summary>
      public sealed partial class LoggingDestination : pb::IMessage<LoggingDestination>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<LoggingDestination> _parser = new pb::MessageParser<LoggingDestination>(() => new LoggingDestination());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<LoggingDestination> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Api.Logging.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public LoggingDestination() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public LoggingDestination(LoggingDestination other) : this() {
          monitoredResource_ = other.monitoredResource_;
          logs_ = other.logs_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public LoggingDestination Clone() {
          return new LoggingDestination(this);
        }

        /// <summary>Field number for the "monitored_resource" field.</summary>
        public const int MonitoredResourceFieldNumber = 3;
        private string monitoredResource_ = "";
        /// <summary>
        /// The monitored resource type. The type must be defined in the
        /// [Service.monitored_resources][google.api.Service.monitored_resources] section.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string MonitoredResource {
          get { return monitoredResource_; }
          set {
            monitoredResource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "logs" field.</summary>
        public const int LogsFieldNumber = 1;
        private static readonly pb::FieldCodec<string> _repeated_logs_codec
            = pb::FieldCodec.ForString(10);
        private readonly pbc::RepeatedField<string> logs_ = new pbc::RepeatedField<string>();
        /// <summary>
        /// Names of the logs to be sent to this destination. Each name must
        /// be defined in the [Service.logs][google.api.Service.logs] section. If the log name is
        /// not a domain scoped name, it will be automatically prefixed with
        /// the service name followed by "/".
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<string> Logs {
          get { return logs_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as LoggingDestination);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(LoggingDestination other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (MonitoredResource != other.MonitoredResource) return false;
          if(!logs_.Equals(other.logs_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (MonitoredResource.Length != 0) hash ^= MonitoredResource.GetHashCode();
          hash ^= logs_.GetHashCode();
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
          logs_.WriteTo(output, _repeated_logs_codec);
          if (MonitoredResource.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(MonitoredResource);
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
          logs_.WriteTo(ref output, _repeated_logs_codec);
          if (MonitoredResource.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(MonitoredResource);
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
          if (MonitoredResource.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(MonitoredResource);
          }
          size += logs_.CalculateSize(_repeated_logs_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(LoggingDestination other) {
          if (other == null) {
            return;
          }
          if (other.MonitoredResource.Length != 0) {
            MonitoredResource = other.MonitoredResource;
          }
          logs_.Add(other.logs_);
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
                logs_.AddEntriesFrom(input, _repeated_logs_codec);
                break;
              }
              case 26: {
                MonitoredResource = input.ReadString();
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
                logs_.AddEntriesFrom(ref input, _repeated_logs_codec);
                break;
              }
              case 26: {
                MonitoredResource = input.ReadString();
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
