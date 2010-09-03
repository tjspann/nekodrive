/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class nfstime3 : XdrAble {
    public uint32 seconds;
    public uint32 nseconds;

    public nfstime3() {
    }

    public nfstime3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        seconds.xdrEncode(xdr);
        nseconds.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        seconds = new uint32(xdr);
        nseconds = new uint32(xdr);
    }

}
// End of nfstime3.cs
