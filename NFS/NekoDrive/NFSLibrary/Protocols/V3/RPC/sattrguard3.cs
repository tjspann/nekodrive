/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class sattrguard3 : XdrAble {
    public bool check;
    public nfstime3 obj_ctime;

    public sattrguard3() {
    }

    public sattrguard3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeBoolean(check);
        if ( check == true ) {
            obj_ctime.xdrEncode(xdr);
        }
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        check = xdr.xdrDecodeBoolean();
        if ( check == true ) {
            obj_ctime = new nfstime3(xdr);
        }
    }

}
// End of sattrguard3.cs
