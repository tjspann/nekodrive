/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class filename3 : XdrAble {

    public string value;

    public filename3() {
    }

    public filename3(string value) {
        this.value = value;
    }

    public filename3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeString(value);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = xdr.xdrDecodeString();
    }

}
// End of filename3.cs
