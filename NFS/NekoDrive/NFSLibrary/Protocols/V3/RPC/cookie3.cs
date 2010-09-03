/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class cookie3 : XdrAble {

    public uint64 value;

    public cookie3() {
    }

    public cookie3(uint64 value) {
        this.value = value;
    }

    public cookie3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        value.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = new uint64(xdr);
    }

}
// End of cookie3.cs
