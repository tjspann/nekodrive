/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class nfspath3 : XdrAble {

    public string value;

    public nfspath3() {
    }

    public nfspath3(string value) {
        this.value = value;
    }

    public nfspath3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeString(value);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = xdr.xdrDecodeString();
    }

}
// End of nfspath3.cs
