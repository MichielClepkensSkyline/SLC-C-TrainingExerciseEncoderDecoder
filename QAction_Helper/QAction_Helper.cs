// <auto-generated>This is auto-generated code by DIS. Do not modify.</auto-generated>
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skyline.DataMiner.Scripting
{
public static class Parameter
{
	/// <summary>PID: 11 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int encoderstatus_11 = 11;
	/// <summary>PID: 11 | Type: read</summary>
	public const int encoderstatus = 11;
	/// <summary>PID: 12 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int encodercompressedbitrate_12 = 12;
	/// <summary>PID: 12 | Type: read</summary>
	public const int encodercompressedbitrate = 12;
	/// <summary>PID: 13 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int encoderautochromaweightstatus_13 = 13;
	/// <summary>PID: 13 | Type: read</summary>
	public const int encoderautochromaweightstatus = 13;
	/// <summary>PID: 14 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int encoderchromaweight_14 = 14;
	/// <summary>PID: 14 | Type: read</summary>
	public const int encoderchromaweight = 14;
	/// <summary>PID: 15 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int encoderlosslessmodestatus_15 = 15;
	/// <summary>PID: 15 | Type: read</summary>
	public const int encoderlosslessmodestatus = 15;
	/// <summary>PID: 51 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int decoderstatus_51 = 51;
	/// <summary>PID: 51 | Type: read</summary>
	public const int decoderstatus = 51;
	/// <summary>PID: 52 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int decodercompressedbitrate_52 = 52;
	/// <summary>PID: 52 | Type: read</summary>
	public const int decodercompressedbitrate = 52;
	/// <summary>PID: 53 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int decoderprogressionorder_53 = 53;
	/// <summary>PID: 53 | Type: read</summary>
	public const int decoderprogressionorder = 53;
	/// <summary>PID: 54 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int decodercodeblockwidth_54 = 54;
	/// <summary>PID: 54 | Type: read</summary>
	public const int decodercodeblockwidth = 54;
	/// <summary>PID: 55 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int decodercodeblockheight_55 = 55;
	/// <summary>PID: 55 | Type: read</summary>
	public const int decodercodeblockheight = 55;
	public class Write
	{
		/// <summary>PID: 111 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int encoderstatus_111 = 111;
		/// <summary>PID: 111 | Type: write</summary>
		public const int encoderstatus = 111;
		/// <summary>PID: 113 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int encoderautochromaweightstatus_113 = 113;
		/// <summary>PID: 113 | Type: write</summary>
		public const int encoderautochromaweightstatus = 113;
		/// <summary>PID: 114 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int encoderchromaweight_114 = 114;
		/// <summary>PID: 114 | Type: write</summary>
		public const int encoderchromaweight = 114;
		/// <summary>PID: 115 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int encoderlosslessmodestatus_115 = 115;
		/// <summary>PID: 115 | Type: write</summary>
		public const int encoderlosslessmodestatus = 115;
		/// <summary>PID: 151 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int decoderstatus_151 = 151;
		/// <summary>PID: 151 | Type: write</summary>
		public const int decoderstatus = 151;
		/// <summary>PID: 153 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int decoderprogressionorder_153 = 153;
		/// <summary>PID: 153 | Type: write</summary>
		public const int decoderprogressionorder = 153;
	}
}
public class WriteParameters
{
	/// <summary>PID: 111  | Type: write | DISCREETS: Disabled = 0, Enabled = 1</summary>
	public System.Object Encoderstatus {get { return Protocol.GetParameter(111); }set { Protocol.SetParameter(111, value); }}
	/// <summary>PID: 113  | Type: write | DISCREETS: Disabled = 0, Enabled = 1</summary>
	public System.Object Encoderautochromaweightstatus {get { return Protocol.GetParameter(113); }set { Protocol.SetParameter(113, value); }}
	/// <summary>PID: 114  | Type: write | DISCREETS: Not Available = -1</summary>
	public System.Object Encoderchromaweight {get { return Protocol.GetParameter(114); }set { Protocol.SetParameter(114, value); }}
	/// <summary>PID: 115  | Type: write | DISCREETS: Enabled = 1, Disabled = 0</summary>
	public System.Object Encoderlosslessmodestatus {get { return Protocol.GetParameter(115); }set { Protocol.SetParameter(115, value); }}
	/// <summary>PID: 151  | Type: write | DISCREETS: Disabled = 0, Enabled = 1</summary>
	public System.Object Decoderstatus {get { return Protocol.GetParameter(151); }set { Protocol.SetParameter(151, value); }}
	/// <summary>PID: 153  | Type: write | DISCREETS: LCRP = 0, RLCP = 1, RPCL = 2, PCRL = 3, CPRL = 4</summary>
	public System.Object Decoderprogressionorder {get { return Protocol.GetParameter(153); }set { Protocol.SetParameter(153, value); }}
	public SLProtocolExt Protocol;
	public WriteParameters(SLProtocolExt protocol)
	{
		Protocol = protocol;
	}
}
public interface SLProtocolExt : SLProtocol
{
	object Afterstartup_dummy { get; set; }
	object Fixedparamminusone__fixed { get; set; }
	object Fixedparamzero__fixed { get; set; }
	object Fixedparamdefaultbitrate__fixed { get; set; }
	object Fixedparamdefaultcodeblock__fixed { get; set; }
	object Encodertitle_header { get; set; }
	object Encoderstatus_11 { get; set; }
	object Encoderstatus { get; set; }
	object Encodercompressedbitrate_12 { get; set; }
	object Encodercompressedbitrate { get; set; }
	object Encoderautochromaweightstatus_13 { get; set; }
	object Encoderautochromaweightstatus { get; set; }
	object Encoderchromaweight_14 { get; set; }
	object Encoderchromaweight { get; set; }
	object Encoderlosslessmodestatus_15 { get; set; }
	object Encoderlosslessmodestatus { get; set; }
	object Decodertitle_header { get; set; }
	object Decoderstatus_51 { get; set; }
	object Decoderstatus { get; set; }
	object Decodercompressedbitrate_52 { get; set; }
	object Decodercompressedbitrate { get; set; }
	object Decoderprogressionorder_53 { get; set; }
	object Decoderprogressionorder { get; set; }
	object Decodercodeblockwidth_54 { get; set; }
	object Decodercodeblockwidth { get; set; }
	object Decodercodeblockheight_55 { get; set; }
	object Decodercodeblockheight { get; set; }
	object Encoderstatus_111 { get; set; }
	object Encoderautochromaweightstatus_113 { get; set; }
	object Encoderchromaweight_114 { get; set; }
	object Encoderlosslessmodestatus_115 { get; set; }
	object Decoderstatus_151 { get; set; }
	object Decoderprogressionorder_153 { get; set; }
	WriteParameters Write { get; set; }
}
public class ConcreteSLProtocolExt : ConcreteSLProtocol, SLProtocolExt
{
	/// <summary>PID: 2  | Type: dummy</summary>
	public System.Object Afterstartup_dummy {get { return GetParameter(2); }set { SetParameter(2, value); }}
	/// <summary>PID: 3  | Type: fixed</summary>
	public System.Object Fixedparamminusone__fixed {get { return GetParameter(3); }set { SetParameter(3, value); }}
	/// <summary>PID: 4  | Type: fixed</summary>
	public System.Object Fixedparamzero__fixed {get { return GetParameter(4); }set { SetParameter(4, value); }}
	/// <summary>PID: 5  | Type: fixed</summary>
	public System.Object Fixedparamdefaultbitrate__fixed {get { return GetParameter(5); }set { SetParameter(5, value); }}
	/// <summary>PID: 6  | Type: fixed</summary>
	public System.Object Fixedparamdefaultcodeblock__fixed {get { return GetParameter(6); }set { SetParameter(6, value); }}
	/// <summary>PID: 10  | Type: header</summary>
	public System.Object Encodertitle_header {get { return GetParameter(10); }set { SetParameter(10, value); }}
	/// <summary>PID: 11  | Type: read | DISCREETS: Disabled = 0, Enabled = 1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encoderstatus_11 {get { return GetParameter(11); }set { SetParameter(11, value); }}
	/// <summary>PID: 11  | Type: read | DISCREETS: Disabled = 0, Enabled = 1</summary>
	public System.Object Encoderstatus {get { return GetParameter(11); }set { SetParameter(11, value); }}
	/// <summary>PID: 12  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encodercompressedbitrate_12 {get { return GetParameter(12); }set { SetParameter(12, value); }}
	/// <summary>PID: 12  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	public System.Object Encodercompressedbitrate {get { return GetParameter(12); }set { SetParameter(12, value); }}
	/// <summary>PID: 13  | Type: read | DISCREETS: Disabled = 0, Enabled = 1 | EXCEPTIONS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encoderautochromaweightstatus_13 {get { return GetParameter(13); }set { SetParameter(13, value); }}
	/// <summary>PID: 13  | Type: read | DISCREETS: Disabled = 0, Enabled = 1 | EXCEPTIONS: Not Available = -1</summary>
	public System.Object Encoderautochromaweightstatus {get { return GetParameter(13); }set { SetParameter(13, value); }}
	/// <summary>PID: 14  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encoderchromaweight_14 {get { return GetParameter(14); }set { SetParameter(14, value); }}
	/// <summary>PID: 14  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	public System.Object Encoderchromaweight {get { return GetParameter(14); }set { SetParameter(14, value); }}
	/// <summary>PID: 15  | Type: read | DISCREETS: Enabled = 1, Disabled = 0 | EXCEPTIONS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encoderlosslessmodestatus_15 {get { return GetParameter(15); }set { SetParameter(15, value); }}
	/// <summary>PID: 15  | Type: read | DISCREETS: Enabled = 1, Disabled = 0 | EXCEPTIONS: Not Available = -1</summary>
	public System.Object Encoderlosslessmodestatus {get { return GetParameter(15); }set { SetParameter(15, value); }}
	/// <summary>PID: 50  | Type: header</summary>
	public System.Object Decodertitle_header {get { return GetParameter(50); }set { SetParameter(50, value); }}
	/// <summary>PID: 51  | Type: read | DISCREETS: Disabled = 0, Enabled = 1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Decoderstatus_51 {get { return GetParameter(51); }set { SetParameter(51, value); }}
	/// <summary>PID: 51  | Type: read | DISCREETS: Disabled = 0, Enabled = 1</summary>
	public System.Object Decoderstatus {get { return GetParameter(51); }set { SetParameter(51, value); }}
	/// <summary>PID: 52  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Decodercompressedbitrate_52 {get { return GetParameter(52); }set { SetParameter(52, value); }}
	/// <summary>PID: 52  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	public System.Object Decodercompressedbitrate {get { return GetParameter(52); }set { SetParameter(52, value); }}
	/// <summary>PID: 53  | Type: read | DISCREETS: LCRP = 0, RLCP = 1, RPCL = 2, PCRL = 3, CPRL = 4 | EXCEPTIONS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Decoderprogressionorder_53 {get { return GetParameter(53); }set { SetParameter(53, value); }}
	/// <summary>PID: 53  | Type: read | DISCREETS: LCRP = 0, RLCP = 1, RPCL = 2, PCRL = 3, CPRL = 4 | EXCEPTIONS: Not Available = -1</summary>
	public System.Object Decoderprogressionorder {get { return GetParameter(53); }set { SetParameter(53, value); }}
	/// <summary>PID: 54  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Decodercodeblockwidth_54 {get { return GetParameter(54); }set { SetParameter(54, value); }}
	/// <summary>PID: 54  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	public System.Object Decodercodeblockwidth {get { return GetParameter(54); }set { SetParameter(54, value); }}
	/// <summary>PID: 55  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Decodercodeblockheight_55 {get { return GetParameter(55); }set { SetParameter(55, value); }}
	/// <summary>PID: 55  | Type: read | EXCEPTIONS: Not Available = -1</summary>
	public System.Object Decodercodeblockheight {get { return GetParameter(55); }set { SetParameter(55, value); }}
	/// <summary>PID: 111  | Type: write | DISCREETS: Disabled = 0, Enabled = 1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encoderstatus_111 {get { return GetParameter(111); }set { SetParameter(111, value); }}
	/// <summary>PID: 113  | Type: write | DISCREETS: Disabled = 0, Enabled = 1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encoderautochromaweightstatus_113 {get { return GetParameter(113); }set { SetParameter(113, value); }}
	/// <summary>PID: 114  | Type: write | DISCREETS: Not Available = -1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encoderchromaweight_114 {get { return GetParameter(114); }set { SetParameter(114, value); }}
	/// <summary>PID: 115  | Type: write | DISCREETS: Enabled = 1, Disabled = 0</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Encoderlosslessmodestatus_115 {get { return GetParameter(115); }set { SetParameter(115, value); }}
	/// <summary>PID: 151  | Type: write | DISCREETS: Disabled = 0, Enabled = 1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Decoderstatus_151 {get { return GetParameter(151); }set { SetParameter(151, value); }}
	/// <summary>PID: 153  | Type: write | DISCREETS: LCRP = 0, RLCP = 1, RPCL = 2, PCRL = 3, CPRL = 4</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Decoderprogressionorder_153 {get { return GetParameter(153); }set { SetParameter(153, value); }}
	public WriteParameters Write { get; set; }
	public ConcreteSLProtocolExt()
	{
		Write = new WriteParameters(this);
	}
}
}
