// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_BLEND_DESC1"]/*' />
/// <unmanaged>D3D11_BLEND_DESC1</unmanaged>
public partial struct BlendDescription1
{
	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_BLEND_DESC1::AlphaToCoverageEnable"]/*' />
	public Bool32 AlphaToCoverageEnable;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_BLEND_DESC1::IndependentBlendEnable"]/*' />
	public Bool32 IndependentBlendEnable;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_BLEND_DESC1::RenderTarget"]/*' />
	public RenderTarget__FixedBuffer RenderTarget;

	public unsafe struct RenderTarget__FixedBuffer
	{
		public RenderTargetBlendDescription1 e0;
		public RenderTargetBlendDescription1 e1;
		public RenderTargetBlendDescription1 e2;
		public RenderTargetBlendDescription1 e3;
		public RenderTargetBlendDescription1 e4;
		public RenderTargetBlendDescription1 e5;
		public RenderTargetBlendDescription1 e6;
		public RenderTargetBlendDescription1 e7;

		[UnscopedRef]
		public ref RenderTargetBlendDescription1 this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ref AsSpan()[index];
			}
		}

		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<RenderTargetBlendDescription1> AsSpan()
		{
			return MemoryMarshal.CreateSpan(ref e0, 8);
		}
	}
}
