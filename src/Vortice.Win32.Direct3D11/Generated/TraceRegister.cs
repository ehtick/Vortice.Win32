// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_REGISTER"]/*' />
/// <unmanaged>D3D11_TRACE_REGISTER</unmanaged>
public partial struct TraceRegister
{
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_REGISTER::RegType"]/*' />
	public TraceRegisterType RegType;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_REGISTER::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_REGISTER::OperandIndex"]/*' />
	public byte OperandIndex;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_REGISTER::Flags"]/*' />
	public byte Flags;

	[UnscopedRef]
	public ref ushort Index1D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Index1D;
		}
	}

	[UnscopedRef]
	public unsafe Span<ushort> Index2D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return MemoryMarshal.CreateSpan(ref Anonymous.Index2D[0], 2);
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Index1D"]/*' />
		[FieldOffset(0)]
		public ushort Index1D;

		/// <include file='Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Index2D"]/*' />
		[FieldOffset(0)]
		public unsafe fixed ushort Index2D[2];
	}
}
