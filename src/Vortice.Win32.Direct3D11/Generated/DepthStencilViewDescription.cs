// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC"]/*' />
/// <unmanaged>D3D11_DEPTH_STENCIL_VIEW_DESC</unmanaged>
public partial struct DepthStencilViewDescription
{
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC::Format"]/*' />
	public Graphics.Dxgi.Common.Format Format;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC::ViewDimension"]/*' />
	public DsvDimension ViewDimension;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC::Flags"]/*' />
	public DsvFlags Flags;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	[UnscopedRef]
	public ref Texture1DDsv Texture1D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture1D;
		}
	}

	[UnscopedRef]
	public ref Texture1DArrayDsv Texture1DArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture1DArray;
		}
	}

	[UnscopedRef]
	public ref Texture2DDsv Texture2D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2D;
		}
	}

	[UnscopedRef]
	public ref Texture2DArrayDsv Texture2DArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DArray;
		}
	}

	[UnscopedRef]
	public ref Texture2DMsDsv Texture2DMS
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DMS;
		}
	}

	[UnscopedRef]
	public ref Texture2DMsArrayDsv Texture2DMSArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DMSArray;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture1D"]/*' />
		[FieldOffset(0)]
		public Texture1DDsv Texture1D;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture1DArray"]/*' />
		[FieldOffset(0)]
		public Texture1DArrayDsv Texture1DArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2D"]/*' />
		[FieldOffset(0)]
		public Texture2DDsv Texture2D;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DArray"]/*' />
		[FieldOffset(0)]
		public Texture2DArrayDsv Texture2DArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DMS"]/*' />
		[FieldOffset(0)]
		public Texture2DMsDsv Texture2DMS;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DMSArray"]/*' />
		[FieldOffset(0)]
		public Texture2DMsArrayDsv Texture2DMSArray;
	}
}
