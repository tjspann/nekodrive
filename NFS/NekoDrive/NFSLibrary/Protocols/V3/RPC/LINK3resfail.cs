/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class LINK3resfail : XdrAble {
    public post_op_attr file_attributes;
    public wcc_data linkdir_wcc;

    public LINK3resfail() {
    }

    public LINK3resfail(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        file_attributes.xdrEncode(xdr);
        linkdir_wcc.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        file_attributes = new post_op_attr(xdr);
        linkdir_wcc = new wcc_data(xdr);
    }

}
// End of LINK3resfail.cs
