// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="WICBitmapPlane"]/*' />
/// <unmanaged>WICBitmapPlane</unmanaged>
public partial struct WICBitmapPlane
{
	/// <include file='../Imaging.xml' path='doc/member[@name="WICBitmapPlane::Format"]/*' />
	public Guid Format;

	/// <include file='../Imaging.xml' path='doc/member[@name="WICBitmapPlane::pbBuffer"]/*' />
	public unsafe byte* pbBuffer;

	/// <include file='../Imaging.xml' path='doc/member[@name="WICBitmapPlane::cbStride"]/*' />
	public uint cbStride;

	/// <include file='../Imaging.xml' path='doc/member[@name="WICBitmapPlane::cbBufferSize"]/*' />
	public uint cbBufferSize;
}
