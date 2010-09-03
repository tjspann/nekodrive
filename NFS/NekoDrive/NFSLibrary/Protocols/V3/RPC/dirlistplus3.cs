/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class dirlistplus3 : XdrAble {
    public entryplus3 entries;
    public bool eof;

    public dirlistplus3() {
    }

    public dirlistplus3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        if ( entries != null ) { xdr.xdrEncodeBoolean(true); entries.xdrEncode(xdr); } else { xdr.xdrEncodeBoolean(false); };
        xdr.xdrEncodeBoolean(eof);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        entries = xdr.xdrDecodeBoolean() ? new entryplus3(xdr) : null;
        eof = xdr.xdrDecodeBoolean();
    }

}
// End of dirlistplus3.cs
