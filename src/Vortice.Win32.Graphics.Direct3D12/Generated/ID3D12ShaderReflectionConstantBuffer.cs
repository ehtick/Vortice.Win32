// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer"]/*' />
/// <unmanaged>ID3D12ShaderReflectionConstantBuffer</unmanaged>
[Guid("c59598b4-48b3-4869-b9b1-b1618b14a8b7")]
public unsafe partial struct ID3D12ShaderReflectionConstantBuffer : ID3D12ShaderReflectionConstantBuffer.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12ShaderReflectionConstantBuffer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB4, 0x98, 0x95, 0xC5,
				0xB3, 0x48,
				0x69, 0x48,
				0xB9,
				0xB1,
				0xB1,
				0x61,
				0x8B,
				0x14,
				0xA8,
				0xB7
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ShaderReflectionConstantBuffer));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ShaderReflectionConstantBuffer));
#endif

	public void** lpVtbl;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult GetDesc(ShaderBufferDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*, ShaderBufferDescription*, int>)(lpVtbl[0]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionConstantBuffer*, ShaderBufferDescription*, int>)(lpVtbl[0]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer::GetVariableByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public ID3D12ShaderReflectionVariable GetVariableByIndex(uint Index)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*, uint, ID3D12ShaderReflectionVariable>)(lpVtbl[1]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionConstantBuffer*, uint, ID3D12ShaderReflectionVariable>)(lpVtbl[1]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer::GetVariableByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public ID3D12ShaderReflectionVariable GetVariableByName(sbyte* Name)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*, sbyte*, ID3D12ShaderReflectionVariable>)(lpVtbl[2]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionConstantBuffer*, sbyte*, ID3D12ShaderReflectionVariable>)(lpVtbl[2]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
#endif
	}

	public interface Interface 
	{
		[VtblIndex(0)]
		HResult GetDesc(ShaderBufferDescription* pDesc);

		[VtblIndex(1)]
		ID3D12ShaderReflectionVariable GetVariableByIndex(uint Index);

		[VtblIndex(2)]
		ID3D12ShaderReflectionVariable GetVariableByName(sbyte* Name);
	}
}

