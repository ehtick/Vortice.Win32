// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_VIDEO_COLOR"]/*' />
/// <unmanaged>D3D11_VIDEO_COLOR</unmanaged>
public partial struct VideoColor
{
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_VIDEO_COLOR::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	[UnscopedRef]
	public ref VideoColorYcbcra YCbCr
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.YCbCr;
		}
	}

	[UnscopedRef]
	public ref VideoColorRgba RGBA
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.RGBA;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::YCbCr"]/*' />
		[FieldOffset(0)]
		public VideoColorYcbcra YCbCr;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::RGBA"]/*' />
		[FieldOffset(0)]
		public VideoColorRgba RGBA;
	}
}
