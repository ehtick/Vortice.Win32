// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionConstantBuffer"]/*' />
/// <unmanaged>ID3D11ShaderReflectionConstantBuffer</unmanaged>
[Guid("eb62d63d-93dd-4318-8ae8-c6f83ad371b8")]
public unsafe partial struct ID3D11ShaderReflectionConstantBuffer : ID3D11ShaderReflectionConstantBuffer.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11ShaderReflectionConstantBuffer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x3D, 0xD6, 0x62, 0xEB,
				0xDD, 0x93,
				0x18, 0x43,
				0x8A,
				0xE8,
				0xC6,
				0xF8,
				0x3A,
				0xD3,
				0x71,
				0xB8
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderReflectionConstantBuffer));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderReflectionConstantBuffer));
#endif

	public void** lpVtbl;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionConstantBuffer::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult GetDesc(ShaderBufferDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, ShaderBufferDescription*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, ShaderBufferDescription*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionConstantBuffer::GetVariableByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public ID3D11ShaderReflectionVariable GetVariableByIndex(uint Index)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, uint, ID3D11ShaderReflectionVariable>)(lpVtbl[1]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, uint, ID3D11ShaderReflectionVariable>)(lpVtbl[1]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionConstantBuffer::GetVariableByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public ID3D11ShaderReflectionVariable GetVariableByName(sbyte* Name)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, sbyte*, ID3D11ShaderReflectionVariable>)(lpVtbl[2]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, sbyte*, ID3D11ShaderReflectionVariable>)(lpVtbl[2]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
#endif
	}

	public interface Interface 
	{
		[VtblIndex(0)]
		HResult GetDesc(ShaderBufferDescription* pDesc);

		[VtblIndex(1)]
		ID3D11ShaderReflectionVariable GetVariableByIndex(uint Index);

		[VtblIndex(2)]
		ID3D11ShaderReflectionVariable GetVariableByName(sbyte* Name);
	}
}

