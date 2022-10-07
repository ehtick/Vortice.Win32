// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_RENDER_TARGET_VIEW_DESC"]/*' />
/// <unmanaged>D3D11_RENDER_TARGET_VIEW_DESC</unmanaged>
public partial struct RenderTargetViewDescription
{
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_RENDER_TARGET_VIEW_DESC::Format"]/*' />
	public Graphics.Dxgi.Common.Format Format;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_RENDER_TARGET_VIEW_DESC::ViewDimension"]/*' />
	public RtvDimension ViewDimension;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_RENDER_TARGET_VIEW_DESC::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	[UnscopedRef]
	public ref BufferRtv Buffer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Buffer;
		}
	}

	[UnscopedRef]
	public ref Texture1DRtv Texture1D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture1D;
		}
	}

	[UnscopedRef]
	public ref Texture1DArrayRtv Texture1DArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture1DArray;
		}
	}

	[UnscopedRef]
	public ref Texture2DRtv Texture2D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2D;
		}
	}

	[UnscopedRef]
	public ref Texture2DArrayRtv Texture2DArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DArray;
		}
	}

	[UnscopedRef]
	public ref Texture2DMsRtv Texture2DMS
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DMS;
		}
	}

	[UnscopedRef]
	public ref Texture2DMsArrayRtv Texture2DMSArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DMSArray;
		}
	}

	[UnscopedRef]
	public ref Texture3DRtv Texture3D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture3D;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Buffer"]/*' />
		[FieldOffset(0)]
		public BufferRtv Buffer;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture1D"]/*' />
		[FieldOffset(0)]
		public Texture1DRtv Texture1D;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture1DArray"]/*' />
		[FieldOffset(0)]
		public Texture1DArrayRtv Texture1DArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2D"]/*' />
		[FieldOffset(0)]
		public Texture2DRtv Texture2D;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DArray"]/*' />
		[FieldOffset(0)]
		public Texture2DArrayRtv Texture2DArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DMS"]/*' />
		[FieldOffset(0)]
		public Texture2DMsRtv Texture2DMS;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DMSArray"]/*' />
		[FieldOffset(0)]
		public Texture2DMsArrayRtv Texture2DMSArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture3D"]/*' />
		[FieldOffset(0)]
		public Texture3DRtv Texture3D;
	}
}
