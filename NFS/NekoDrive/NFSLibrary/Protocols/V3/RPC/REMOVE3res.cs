/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class REMOVE3res : XdrAble {
    public int status;
    public REMOVE3resok resok;
    public REMOVE3resfail resfail;

    public REMOVE3res() {
    }

    public REMOVE3res(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(status);
        switch ( status ) {
        case nfsstat3.NFS3_OK:
            resok.xdrEncode(xdr);
            break;
        default:
            resfail.xdrEncode(xdr);
            break;
        }
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        status = xdr.xdrDecodeInt();
        switch ( status ) {
        case nfsstat3.NFS3_OK:
            resok = new REMOVE3resok(xdr);
            break;
        default:
            resfail = new REMOVE3resfail(xdr);
            break;
        }
    }

}
// End of REMOVE3res.cs
