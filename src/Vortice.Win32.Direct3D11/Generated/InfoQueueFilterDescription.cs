// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC"]/*' />
/// <unmanaged>D3D11_INFO_QUEUE_FILTER_DESC</unmanaged>
public partial struct InfoQueueFilterDescription
{
	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC::NumCategories"]/*' />
	public uint NumCategories;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC::pCategoryList"]/*' />
	public unsafe MessageCategory* pCategoryList;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC::NumSeverities"]/*' />
	public uint NumSeverities;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC::pSeverityList"]/*' />
	public unsafe MessageSeverity* pSeverityList;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC::NumIDs"]/*' />
	public uint NumIDs;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC::pIDList"]/*' />
	public unsafe MessageId* pIDList;
}
