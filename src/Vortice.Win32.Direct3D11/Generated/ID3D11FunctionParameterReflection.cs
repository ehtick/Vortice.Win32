// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="ID3D11FunctionParameterReflection"]/*' />
/// <unmanaged>ID3D11FunctionParameterReflection</unmanaged>
[Guid("42757488-334f-47fe-982e-1a65d08cc462")]
public unsafe partial struct ID3D11FunctionParameterReflection : INativeGuid
{
	public static ref readonly Guid IID_ID3D11FunctionParameterReflection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x88, 0x74, 0x75, 0x42,
				0x4F, 0x33,
				0xFE, 0x47,
				0x98,
				0x2E,
				0x1A,
				0x65,
				0xD0,
				0x8C,
				0xC4,
				0x62
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11FunctionParameterReflection));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11FunctionParameterReflection));
#endif

	public void** lpVtbl;

	/// <include file='Direct3D11.xml' path='doc/member[@name="ID3D11FunctionParameterReflection::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult GetDesc(ParameterDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionParameterReflection*, ParameterDescription*, int>)(lpVtbl[0]))((ID3D11FunctionParameterReflection*)Unsafe.AsPointer(ref this), pDesc);
	}
}

