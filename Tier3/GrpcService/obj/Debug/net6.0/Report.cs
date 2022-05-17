// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: report.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GRPCService {

  /// <summary>Holder for reflection information generated from report.proto</summary>
  public static partial class ReportReflection {

    #region Descriptor
    /// <summary>File descriptor for report.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReportReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxyZXBvcnQucHJvdG8SBnJlcG9ydBoKdXNlci5wcm90bxoKcG9zdC5wcm90",
            "byIRCg9FbXB0eVJlcG9ydE1hcmsiNQoNTGlzdE9mUmVwb3J0cxIkCglyZXBv",
            "cnRPYmoYASADKAsyES5yZXBvcnQuUmVwb3J0T2JqIlkKCVJlcG9ydE9iahId",
            "CgZQb3N0SUQYASABKAsyDS5wb3N0LlBvc3RPYmoSHQoGVXNlcklEGAIgASgL",
            "Mg0udXNlci5Vc2VyT2JqEg4KBlJlYXNvbhgDIAEoCTKCAQoGUmVwb3J0EjoK",
            "DFJlbW92ZVJlcG9ydBIRLnJlcG9ydC5SZXBvcnRPYmoaFy5yZXBvcnQuRW1w",
            "dHlSZXBvcnRNYXJrEjwKCkdldFJlcG9ydHMSFy5yZXBvcnQuRW1wdHlSZXBv",
            "cnRNYXJrGhUucmVwb3J0Lkxpc3RPZlJlcG9ydHNCDqoCC0dSUENTZXJ2aWNl",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::GRPCService.UserReflection.Descriptor, global::GRPCService.PostReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GRPCService.EmptyReportMark), global::GRPCService.EmptyReportMark.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GRPCService.ListOfReports), global::GRPCService.ListOfReports.Parser, new[]{ "ReportObj" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GRPCService.ReportObj), global::GRPCService.ReportObj.Parser, new[]{ "PostID", "UserID", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EmptyReportMark : pb::IMessage<EmptyReportMark>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EmptyReportMark> _parser = new pb::MessageParser<EmptyReportMark>(() => new EmptyReportMark());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmptyReportMark> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GRPCService.ReportReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmptyReportMark() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmptyReportMark(EmptyReportMark other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmptyReportMark Clone() {
      return new EmptyReportMark(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmptyReportMark);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmptyReportMark other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmptyReportMark other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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

  public sealed partial class ListOfReports : pb::IMessage<ListOfReports>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListOfReports> _parser = new pb::MessageParser<ListOfReports>(() => new ListOfReports());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListOfReports> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GRPCService.ReportReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListOfReports() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListOfReports(ListOfReports other) : this() {
      reportObj_ = other.reportObj_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListOfReports Clone() {
      return new ListOfReports(this);
    }

    /// <summary>Field number for the "reportObj" field.</summary>
    public const int ReportObjFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GRPCService.ReportObj> _repeated_reportObj_codec
        = pb::FieldCodec.ForMessage(10, global::GRPCService.ReportObj.Parser);
    private readonly pbc::RepeatedField<global::GRPCService.ReportObj> reportObj_ = new pbc::RepeatedField<global::GRPCService.ReportObj>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GRPCService.ReportObj> ReportObj {
      get { return reportObj_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListOfReports);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListOfReports other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!reportObj_.Equals(other.reportObj_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= reportObj_.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      reportObj_.WriteTo(output, _repeated_reportObj_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      reportObj_.WriteTo(ref output, _repeated_reportObj_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += reportObj_.CalculateSize(_repeated_reportObj_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListOfReports other) {
      if (other == null) {
        return;
      }
      reportObj_.Add(other.reportObj_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            reportObj_.AddEntriesFrom(input, _repeated_reportObj_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            reportObj_.AddEntriesFrom(ref input, _repeated_reportObj_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ReportObj : pb::IMessage<ReportObj>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReportObj> _parser = new pb::MessageParser<ReportObj>(() => new ReportObj());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportObj> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GRPCService.ReportReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportObj() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportObj(ReportObj other) : this() {
      postID_ = other.postID_ != null ? other.postID_.Clone() : null;
      userID_ = other.userID_ != null ? other.userID_.Clone() : null;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportObj Clone() {
      return new ReportObj(this);
    }

    /// <summary>Field number for the "PostID" field.</summary>
    public const int PostIDFieldNumber = 1;
    private global::GRPCService.PostObj postID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GRPCService.PostObj PostID {
      get { return postID_; }
      set {
        postID_ = value;
      }
    }

    /// <summary>Field number for the "UserID" field.</summary>
    public const int UserIDFieldNumber = 2;
    private global::GRPCService.UserObj userID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GRPCService.UserObj UserID {
      get { return userID_; }
      set {
        userID_ = value;
      }
    }

    /// <summary>Field number for the "Reason" field.</summary>
    public const int ReasonFieldNumber = 3;
    private string reason_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reason {
      get { return reason_; }
      set {
        reason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportObj);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportObj other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PostID, other.PostID)) return false;
      if (!object.Equals(UserID, other.UserID)) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (postID_ != null) hash ^= PostID.GetHashCode();
      if (userID_ != null) hash ^= UserID.GetHashCode();
      if (Reason.Length != 0) hash ^= Reason.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (postID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PostID);
      }
      if (userID_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserID);
      }
      if (Reason.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Reason);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (postID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PostID);
      }
      if (userID_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserID);
      }
      if (Reason.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Reason);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (postID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostID);
      }
      if (userID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserID);
      }
      if (Reason.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportObj other) {
      if (other == null) {
        return;
      }
      if (other.postID_ != null) {
        if (postID_ == null) {
          PostID = new global::GRPCService.PostObj();
        }
        PostID.MergeFrom(other.PostID);
      }
      if (other.userID_ != null) {
        if (userID_ == null) {
          UserID = new global::GRPCService.UserObj();
        }
        UserID.MergeFrom(other.UserID);
      }
      if (other.Reason.Length != 0) {
        Reason = other.Reason;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            if (postID_ == null) {
              PostID = new global::GRPCService.PostObj();
            }
            input.ReadMessage(PostID);
            break;
          }
          case 18: {
            if (userID_ == null) {
              UserID = new global::GRPCService.UserObj();
            }
            input.ReadMessage(UserID);
            break;
          }
          case 26: {
            Reason = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (postID_ == null) {
              PostID = new global::GRPCService.PostObj();
            }
            input.ReadMessage(PostID);
            break;
          }
          case 18: {
            if (userID_ == null) {
              UserID = new global::GRPCService.UserObj();
            }
            input.ReadMessage(UserID);
            break;
          }
          case 26: {
            Reason = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
