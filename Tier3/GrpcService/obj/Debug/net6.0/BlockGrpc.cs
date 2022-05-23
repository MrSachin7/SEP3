// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: block.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GRPCService {
  public static partial class BlockProto
  {
    static readonly string __ServiceName = "BlockProto";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GRPCService.BlockObj> __Marshaller_BlockObj = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCService.BlockObj.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GRPCService.UserObj> __Marshaller_user_UserObj = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCService.UserObj.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GRPCService.Username> __Marshaller_user_Username = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCService.Username.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GRPCService.EmptyBlock> __Marshaller_EmptyBlock = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCService.EmptyBlock.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GRPCService.ListOfBlocks> __Marshaller_ListOfBlocks = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCService.ListOfBlocks.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GRPCService.BlockObj, global::GRPCService.UserObj> __Method_BlockUser = new grpc::Method<global::GRPCService.BlockObj, global::GRPCService.UserObj>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BlockUser",
        __Marshaller_BlockObj,
        __Marshaller_user_UserObj);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GRPCService.Username, global::GRPCService.UserObj> __Method_UnBlockUser = new grpc::Method<global::GRPCService.Username, global::GRPCService.UserObj>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UnBlockUser",
        __Marshaller_user_Username,
        __Marshaller_user_UserObj);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GRPCService.EmptyBlock, global::GRPCService.ListOfBlocks> __Method_getAllBlockedUsers = new grpc::Method<global::GRPCService.EmptyBlock, global::GRPCService.ListOfBlocks>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getAllBlockedUsers",
        __Marshaller_EmptyBlock,
        __Marshaller_ListOfBlocks);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRPCService.BlockReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BlockProto</summary>
    [grpc::BindServiceMethod(typeof(BlockProto), "BindService")]
    public abstract partial class BlockProtoBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GRPCService.UserObj> BlockUser(global::GRPCService.BlockObj request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GRPCService.UserObj> UnBlockUser(global::GRPCService.Username request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GRPCService.ListOfBlocks> getAllBlockedUsers(global::GRPCService.EmptyBlock request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BlockProtoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_BlockUser, serviceImpl.BlockUser)
          .AddMethod(__Method_UnBlockUser, serviceImpl.UnBlockUser)
          .AddMethod(__Method_getAllBlockedUsers, serviceImpl.getAllBlockedUsers).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BlockProtoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_BlockUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRPCService.BlockObj, global::GRPCService.UserObj>(serviceImpl.BlockUser));
      serviceBinder.AddMethod(__Method_UnBlockUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRPCService.Username, global::GRPCService.UserObj>(serviceImpl.UnBlockUser));
      serviceBinder.AddMethod(__Method_getAllBlockedUsers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRPCService.EmptyBlock, global::GRPCService.ListOfBlocks>(serviceImpl.getAllBlockedUsers));
    }

  }
}
#endregion