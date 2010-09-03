/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

using System.Net;

using org.acplt.oncrpc.server;

/**
 */
public abstract class NFSv2ProtocolServerStub : OncRpcServerStub, OncRpcDispatchable {

    public NFSv2ProtocolServerStub() : this(0) {
    }

    public NFSv2ProtocolServerStub(int port) : this(null, port) {
    }

    public NFSv2ProtocolServerStub(IPAddress bindAddr, int port)
           {
        info = new OncRpcServerTransportRegistrationInfo [] {
            new OncRpcServerTransportRegistrationInfo(NFSv2Protocol.NFS_PROGRAM, 2),
        };
        transports = new OncRpcServerTransport [] {
            new OncRpcUdpServerTransport(this, bindAddr, port, info, 32768),
            new OncRpcTcpServerTransport(this, bindAddr, port, info, 32768)
        };
    }

    public void dispatchOncRpcCall(OncRpcCallInformation call, int program, int version, int procedure)
            {
        if ( version == 2 ) {
            switch ( procedure ) {
            case 0: {
                call.retrieveCall(XdrVoid.XDR_VOID);
                NFSPROC_NULL_2();
                call.reply(XdrVoid.XDR_VOID);
                break;
            }
            case 1: {
                nfshandle args_ = new nfshandle();
                call.retrieveCall(args_);
                attrstat result_ = NFSPROC_GETATTR_2(args_);
                call.reply(result_);
                break;
            }
            case 2: {
                sattrargs args_ = new sattrargs();
                call.retrieveCall(args_);
                attrstat result_ = NFSPROC_SETATTR_2(args_);
                call.reply(result_);
                break;
            }
            case 3: {
                call.retrieveCall(XdrVoid.XDR_VOID);
                NFSPROC_ROOT_2();
                call.reply(XdrVoid.XDR_VOID);
                break;
            }
            case 4: {
                diropargs args_ = new diropargs();
                call.retrieveCall(args_);
                diropres result_ = NFSPROC_LOOKUP_2(args_);
                call.reply(result_);
                break;
            }
            case 5: {
                nfshandle args_ = new nfshandle();
                call.retrieveCall(args_);
                readlinkres result_ = NFSPROC_READLINK_2(args_);
                call.reply(result_);
                break;
            }
            case 6: {
                readargs args_ = new readargs();
                call.retrieveCall(args_);
                readres result_ = NFSPROC_READ_2(args_);
                call.reply(result_);
                break;
            }
            case 7: {
                call.retrieveCall(XdrVoid.XDR_VOID);
                NFSPROC_WRITECACHE_2();
                call.reply(XdrVoid.XDR_VOID);
                break;
            }
            case 8: {
                writeargs args_ = new writeargs();
                call.retrieveCall(args_);
                attrstat result_ = NFSPROC_WRITE_2(args_);
                call.reply(result_);
                break;
            }
            case 9: {
                createargs args_ = new createargs();
                call.retrieveCall(args_);
                diropres result_ = NFSPROC_CREATE_2(args_);
                call.reply(result_);
                break;
            }
            case 10: {
                diropargs args_ = new diropargs();
                call.retrieveCall(args_);
                XdrInt result_ = new XdrInt(NFSPROC_REMOVE_2(args_));
                call.reply(result_);
                break;
            }
            case 11: {
                renameargs args_ = new renameargs();
                call.retrieveCall(args_);
                XdrInt result_ = new XdrInt(NFSPROC_RENAME_2(args_));
                call.reply(result_);
                break;
            }
            case 12: {
                linkargs args_ = new linkargs();
                call.retrieveCall(args_);
                XdrInt result_ = new XdrInt(NFSPROC_LINK_2(args_));
                call.reply(result_);
                break;
            }
            case 13: {
                symlinkargs args_ = new symlinkargs();
                call.retrieveCall(args_);
                XdrInt result_ = new XdrInt(NFSPROC_SYMLINK_2(args_));
                call.reply(result_);
                break;
            }
            case 14: {
                createargs args_ = new createargs();
                call.retrieveCall(args_);
                diropres result_ = NFSPROC_MKDIR_2(args_);
                call.reply(result_);
                break;
            }
            case 15: {
                diropargs args_ = new diropargs();
                call.retrieveCall(args_);
                XdrInt result_ = new XdrInt(NFSPROC_RMDIR_2(args_));
                call.reply(result_);
                break;
            }
            case 16: {
                readdirargs args_ = new readdirargs();
                call.retrieveCall(args_);
                readdirres result_ = NFSPROC_READDIR_2(args_);
                call.reply(result_);
                break;
            }
            case 17: {
                nfshandle args_ = new nfshandle();
                call.retrieveCall(args_);
                statfsres result_ = NFSPROC_STATFS_2(args_);
                call.reply(result_);
                break;
            }
            default:
                call.failProcedureUnavailable();
                break;
            }
        } else {
            call.failProgramUnavailable();
        }
    }

    public abstract void NFSPROC_NULL_2();

    public abstract attrstat NFSPROC_GETATTR_2(nfshandle arg1);

    public abstract attrstat NFSPROC_SETATTR_2(sattrargs arg1);

    public abstract void NFSPROC_ROOT_2();

    public abstract diropres NFSPROC_LOOKUP_2(diropargs arg1);

    public abstract readlinkres NFSPROC_READLINK_2(nfshandle arg1);

    public abstract readres NFSPROC_READ_2(readargs arg1);

    public abstract void NFSPROC_WRITECACHE_2();

    public abstract attrstat NFSPROC_WRITE_2(writeargs arg1);

    public abstract diropres NFSPROC_CREATE_2(createargs arg1);

    public abstract int NFSPROC_REMOVE_2(diropargs arg1);

    public abstract int NFSPROC_RENAME_2(renameargs arg1);

    public abstract int NFSPROC_LINK_2(linkargs arg1);

    public abstract int NFSPROC_SYMLINK_2(symlinkargs arg1);

    public abstract diropres NFSPROC_MKDIR_2(createargs arg1);

    public abstract int NFSPROC_RMDIR_2(diropargs arg1);

    public abstract readdirres NFSPROC_READDIR_2(readdirargs arg1);

    public abstract statfsres NFSPROC_STATFS_2(nfshandle arg1);

}
// End of NFSv2ProtocolServerStub.cs
