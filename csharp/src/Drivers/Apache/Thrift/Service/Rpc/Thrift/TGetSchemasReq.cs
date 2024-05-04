/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * BUT THIS FILE HAS BEEN HAND EDITED TO DISABLE NULLABLE SO REGENERATE AT YOUR OWN RISK
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;

#nullable disable

#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Apache.Hive.Service.Rpc.Thrift
{

  public partial class TGetSchemasReq : TBase
  {
    private string _catalogName;
    private string _schemaName;
    private global::Apache.Hive.Service.Rpc.Thrift.TSparkGetDirectResults _getDirectResults;
    private bool _runAsync;
    private global::Apache.Hive.Service.Rpc.Thrift.THandleIdentifier _operationId;
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlSessionConf _sessionConf;

    public global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle SessionHandle { get; set; }

    public string CatalogName
    {
      get
      {
        return _catalogName;
      }
      set
      {
        __isset.catalogName = true;
        this._catalogName = value;
      }
    }

    public string SchemaName
    {
      get
      {
        return _schemaName;
      }
      set
      {
        __isset.schemaName = true;
        this._schemaName = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.TSparkGetDirectResults GetDirectResults
    {
      get
      {
        return _getDirectResults;
      }
      set
      {
        __isset.getDirectResults = true;
        this._getDirectResults = value;
      }
    }

    public bool RunAsync
    {
      get
      {
        return _runAsync;
      }
      set
      {
        __isset.runAsync = true;
        this._runAsync = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.THandleIdentifier OperationId
    {
      get
      {
        return _operationId;
      }
      set
      {
        __isset.operationId = true;
        this._operationId = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.TDBSqlSessionConf SessionConf
    {
      get
      {
        return _sessionConf;
      }
      set
      {
        __isset.sessionConf = true;
        this._sessionConf = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool catalogName;
      public bool schemaName;
      public bool getDirectResults;
      public bool runAsync;
      public bool operationId;
      public bool sessionConf;
    }

    public TGetSchemasReq()
    {
    }

    public TGetSchemasReq(global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle sessionHandle) : this()
    {
      this.SessionHandle = sessionHandle;
    }

    public TGetSchemasReq DeepCopy()
    {
      var tmp465 = new TGetSchemasReq();
      if ((SessionHandle != null))
      {
        tmp465.SessionHandle = (global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle)this.SessionHandle.DeepCopy();
      }
      if ((CatalogName != null) && __isset.catalogName)
      {
        tmp465.CatalogName = this.CatalogName;
      }
      tmp465.__isset.catalogName = this.__isset.catalogName;
      if ((SchemaName != null) && __isset.schemaName)
      {
        tmp465.SchemaName = this.SchemaName;
      }
      tmp465.__isset.schemaName = this.__isset.schemaName;
      if ((GetDirectResults != null) && __isset.getDirectResults)
      {
        tmp465.GetDirectResults = (global::Apache.Hive.Service.Rpc.Thrift.TSparkGetDirectResults)this.GetDirectResults.DeepCopy();
      }
      tmp465.__isset.getDirectResults = this.__isset.getDirectResults;
      if (__isset.runAsync)
      {
        tmp465.RunAsync = this.RunAsync;
      }
      tmp465.__isset.runAsync = this.__isset.runAsync;
      if ((OperationId != null) && __isset.operationId)
      {
        tmp465.OperationId = (global::Apache.Hive.Service.Rpc.Thrift.THandleIdentifier)this.OperationId.DeepCopy();
      }
      tmp465.__isset.operationId = this.__isset.operationId;
      if ((SessionConf != null) && __isset.sessionConf)
      {
        tmp465.SessionConf = (global::Apache.Hive.Service.Rpc.Thrift.TDBSqlSessionConf)this.SessionConf.DeepCopy();
      }
      tmp465.__isset.sessionConf = this.__isset.sessionConf;
      return tmp465;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_sessionHandle = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct)
              {
                SessionHandle = new global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle();
                await SessionHandle.ReadAsync(iprot, cancellationToken);
                isset_sessionHandle = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                CatalogName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                SchemaName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 1281:
              if (field.Type == TType.Struct)
              {
                GetDirectResults = new global::Apache.Hive.Service.Rpc.Thrift.TSparkGetDirectResults();
                await GetDirectResults.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 1282:
              if (field.Type == TType.Bool)
              {
                RunAsync = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3329:
              if (field.Type == TType.Struct)
              {
                OperationId = new global::Apache.Hive.Service.Rpc.Thrift.THandleIdentifier();
                await OperationId.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3330:
              if (field.Type == TType.Struct)
              {
                SessionConf = new global::Apache.Hive.Service.Rpc.Thrift.TDBSqlSessionConf();
                await SessionConf.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default:
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_sessionHandle)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp466 = new TStruct("TGetSchemasReq");
        await oprot.WriteStructBeginAsync(tmp466, cancellationToken);
        var tmp467 = new TField();
        if ((SessionHandle != null))
        {
          tmp467.Name = "sessionHandle";
          tmp467.Type = TType.Struct;
          tmp467.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
          await SessionHandle.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if ((CatalogName != null) && __isset.catalogName)
        {
          tmp467.Name = "catalogName";
          tmp467.Type = TType.String;
          tmp467.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
          await oprot.WriteStringAsync(CatalogName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if ((SchemaName != null) && __isset.schemaName)
        {
          tmp467.Name = "schemaName";
          tmp467.Type = TType.String;
          tmp467.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
          await oprot.WriteStringAsync(SchemaName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if ((GetDirectResults != null) && __isset.getDirectResults)
        {
          tmp467.Name = "getDirectResults";
          tmp467.Type = TType.Struct;
          tmp467.ID = 1281;
          await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
          await GetDirectResults.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.runAsync)
        {
          tmp467.Name = "runAsync";
          tmp467.Type = TType.Bool;
          tmp467.ID = 1282;
          await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
          await oprot.WriteBoolAsync(RunAsync, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if ((OperationId != null) && __isset.operationId)
        {
          tmp467.Name = "operationId";
          tmp467.Type = TType.Struct;
          tmp467.ID = 3329;
          await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
          await OperationId.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if ((SessionConf != null) && __isset.sessionConf)
        {
          tmp467.Name = "sessionConf";
          tmp467.Type = TType.Struct;
          tmp467.ID = 3330;
          await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
          await SessionConf.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is TGetSchemasReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(SessionHandle, other.SessionHandle)
        && ((__isset.catalogName == other.__isset.catalogName) && ((!__isset.catalogName) || (global::System.Object.Equals(CatalogName, other.CatalogName))))
        && ((__isset.schemaName == other.__isset.schemaName) && ((!__isset.schemaName) || (global::System.Object.Equals(SchemaName, other.SchemaName))))
        && ((__isset.getDirectResults == other.__isset.getDirectResults) && ((!__isset.getDirectResults) || (global::System.Object.Equals(GetDirectResults, other.GetDirectResults))))
        && ((__isset.runAsync == other.__isset.runAsync) && ((!__isset.runAsync) || (global::System.Object.Equals(RunAsync, other.RunAsync))))
        && ((__isset.operationId == other.__isset.operationId) && ((!__isset.operationId) || (global::System.Object.Equals(OperationId, other.OperationId))))
        && ((__isset.sessionConf == other.__isset.sessionConf) && ((!__isset.sessionConf) || (global::System.Object.Equals(SessionConf, other.SessionConf))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if ((SessionHandle != null))
        {
          hashcode = (hashcode * 397) + SessionHandle.GetHashCode();
        }
        if ((CatalogName != null) && __isset.catalogName)
        {
          hashcode = (hashcode * 397) + CatalogName.GetHashCode();
        }
        if ((SchemaName != null) && __isset.schemaName)
        {
          hashcode = (hashcode * 397) + SchemaName.GetHashCode();
        }
        if ((GetDirectResults != null) && __isset.getDirectResults)
        {
          hashcode = (hashcode * 397) + GetDirectResults.GetHashCode();
        }
        if (__isset.runAsync)
        {
          hashcode = (hashcode * 397) + RunAsync.GetHashCode();
        }
        if ((OperationId != null) && __isset.operationId)
        {
          hashcode = (hashcode * 397) + OperationId.GetHashCode();
        }
        if ((SessionConf != null) && __isset.sessionConf)
        {
          hashcode = (hashcode * 397) + SessionConf.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp468 = new StringBuilder("TGetSchemasReq(");
      if ((SessionHandle != null))
      {
        tmp468.Append(", SessionHandle: ");
        SessionHandle.ToString(tmp468);
      }
      if ((CatalogName != null) && __isset.catalogName)
      {
        tmp468.Append(", CatalogName: ");
        CatalogName.ToString(tmp468);
      }
      if ((SchemaName != null) && __isset.schemaName)
      {
        tmp468.Append(", SchemaName: ");
        SchemaName.ToString(tmp468);
      }
      if ((GetDirectResults != null) && __isset.getDirectResults)
      {
        tmp468.Append(", GetDirectResults: ");
        GetDirectResults.ToString(tmp468);
      }
      if (__isset.runAsync)
      {
        tmp468.Append(", RunAsync: ");
        RunAsync.ToString(tmp468);
      }
      if ((OperationId != null) && __isset.operationId)
      {
        tmp468.Append(", OperationId: ");
        OperationId.ToString(tmp468);
      }
      if ((SessionConf != null) && __isset.sessionConf)
      {
        tmp468.Append(", SessionConf: ");
        SessionConf.ToString(tmp468);
      }
      tmp468.Append(')');
      return tmp468.ToString();
    }
  }

}