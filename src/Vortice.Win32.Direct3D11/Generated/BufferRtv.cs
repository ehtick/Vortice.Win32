// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_BUFFER_RTV"]/*' />
/// <unmanaged>D3D11_BUFFER_RTV</unmanaged>
public partial struct BufferRtv
{
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_BUFFER_RTV::Anonymous1"]/*' />
	public _Anonymous1_e__Union Anonymous1;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_BUFFER_RTV::Anonymous2"]/*' />
	public _Anonymous2_e__Union Anonymous2;

	[UnscopedRef]
	public ref uint NumElements
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous2.NumElements;
		}
	}

	[UnscopedRef]
	public ref uint ElementWidth
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous2.ElementWidth;
		}
	}

	[UnscopedRef]
	public ref uint FirstElement
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous1.FirstElement;
		}
	}

	[UnscopedRef]
	public ref uint ElementOffset
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous1.ElementOffset;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous2_e__Union
	{
		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous2_e__Union::NumElements"]/*' />
		[FieldOffset(0)]
		public uint NumElements;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous2_e__Union::ElementWidth"]/*' />
		[FieldOffset(0)]
		public uint ElementWidth;
	}
	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous1_e__Union
	{
		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous1_e__Union::FirstElement"]/*' />
		[FieldOffset(0)]
		public uint FirstElement;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous1_e__Union::ElementOffset"]/*' />
		[FieldOffset(0)]
		public uint ElementOffset;
	}
}
