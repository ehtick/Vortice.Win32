// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_SHADER_RESOURCE_VIEW_DESC1"]/*' />
/// <unmanaged>D3D11_SHADER_RESOURCE_VIEW_DESC1</unmanaged>
public partial struct ShaderResourceViewDescription1
{
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_SHADER_RESOURCE_VIEW_DESC1::Format"]/*' />
	public Graphics.Dxgi.Common.Format Format;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_SHADER_RESOURCE_VIEW_DESC1::ViewDimension"]/*' />
	public Graphics.Direct3D.SrvDimension ViewDimension;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_SHADER_RESOURCE_VIEW_DESC1::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	[UnscopedRef]
	public ref BufferSrv Buffer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Buffer;
		}
	}

	[UnscopedRef]
	public ref Texture1DSrv Texture1D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture1D;
		}
	}

	[UnscopedRef]
	public ref Texture1DArraySrv Texture1DArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture1DArray;
		}
	}

	[UnscopedRef]
	public ref Texture2DSrv1 Texture2D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2D;
		}
	}

	[UnscopedRef]
	public ref Texture2DArraySrv1 Texture2DArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DArray;
		}
	}

	[UnscopedRef]
	public ref Texture2DMsSrv Texture2DMS
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DMS;
		}
	}

	[UnscopedRef]
	public ref Texture2DMsArraySrv Texture2DMSArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DMSArray;
		}
	}

	[UnscopedRef]
	public ref Texture3DSrv Texture3D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture3D;
		}
	}

	[UnscopedRef]
	public ref TexureCubeSrv TextureCube
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.TextureCube;
		}
	}

	[UnscopedRef]
	public ref TexureCubeArraySrv TextureCubeArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.TextureCubeArray;
		}
	}

	[UnscopedRef]
	public ref BufferExtendedSrv BufferEx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.BufferEx;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Buffer"]/*' />
		[FieldOffset(0)]
		public BufferSrv Buffer;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture1D"]/*' />
		[FieldOffset(0)]
		public Texture1DSrv Texture1D;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture1DArray"]/*' />
		[FieldOffset(0)]
		public Texture1DArraySrv Texture1DArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2D"]/*' />
		[FieldOffset(0)]
		public Texture2DSrv1 Texture2D;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DArray"]/*' />
		[FieldOffset(0)]
		public Texture2DArraySrv1 Texture2DArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DMS"]/*' />
		[FieldOffset(0)]
		public Texture2DMsSrv Texture2DMS;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DMSArray"]/*' />
		[FieldOffset(0)]
		public Texture2DMsArraySrv Texture2DMSArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture3D"]/*' />
		[FieldOffset(0)]
		public Texture3DSrv Texture3D;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::TextureCube"]/*' />
		[FieldOffset(0)]
		public TexureCubeSrv TextureCube;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::TextureCubeArray"]/*' />
		[FieldOffset(0)]
		public TexureCubeArraySrv TextureCubeArray;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::BufferEx"]/*' />
		[FieldOffset(0)]
		public BufferExtendedSrv BufferEx;
	}
}
