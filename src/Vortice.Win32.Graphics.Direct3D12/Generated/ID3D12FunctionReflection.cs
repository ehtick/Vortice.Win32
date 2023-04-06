// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionReflection"]/*' />
/// <unmanaged>ID3D12FunctionReflection</unmanaged>
[Guid("1108795c-2772-4ba9-b2a8-d464dc7e2799")]
public unsafe partial struct ID3D12FunctionReflection : ID3D12FunctionReflection.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12FunctionReflection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5C, 0x79, 0x08, 0x11,
				0x72, 0x27,
				0xA9, 0x4B,
				0xB2,
				0xA8,
				0xD4,
				0x64,
				0xDC,
				0x7E,
				0x27,
				0x99
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12FunctionReflection));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12FunctionReflection));
#endif

	public void** lpVtbl;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionReflection::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult GetDesc(FunctionDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12FunctionReflection*, FunctionDescription*, int>)(lpVtbl[0]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, FunctionDescription*, int>)(lpVtbl[0]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionReflection::GetConstantBufferByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint BufferIndex)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer>)(lpVtbl[1]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer>)(lpVtbl[1]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionReflection::GetConstantBufferByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName(sbyte* Name)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12FunctionReflection*, sbyte*, ID3D12ShaderReflectionConstantBuffer>)(lpVtbl[2]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, sbyte*, ID3D12ShaderReflectionConstantBuffer>)(lpVtbl[2]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionReflection::GetResourceBindingDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12FunctionReflection*, uint, ShaderInputBindDescription*, int>)(lpVtbl[3]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ShaderInputBindDescription*, int>)(lpVtbl[3]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionReflection::GetVariableByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public ID3D12ShaderReflectionVariable GetVariableByName(sbyte* Name)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12FunctionReflection*, sbyte*, ID3D12ShaderReflectionVariable>)(lpVtbl[4]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, sbyte*, ID3D12ShaderReflectionVariable>)(lpVtbl[4]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionReflection::GetResourceBindingDescByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetResourceBindingDescByName(sbyte* Name, ShaderInputBindDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12FunctionReflection*, sbyte*, ShaderInputBindDescription*, int>)(lpVtbl[5]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, sbyte*, ShaderInputBindDescription*, int>)(lpVtbl[5]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionReflection::GetFunctionParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public ID3D12FunctionParameterReflection GetFunctionParameter(int ParameterIndex)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection>)(lpVtbl[6]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection>)(lpVtbl[6]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
#endif
	}

	public interface Interface 
	{
		[VtblIndex(0)]
		HResult GetDesc(FunctionDescription* pDesc);

		[VtblIndex(1)]
		ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint BufferIndex);

		[VtblIndex(2)]
		ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName(sbyte* Name);

		[VtblIndex(3)]
		HResult GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDescription* pDesc);

		[VtblIndex(4)]
		ID3D12ShaderReflectionVariable GetVariableByName(sbyte* Name);

		[VtblIndex(5)]
		HResult GetResourceBindingDescByName(sbyte* Name, ShaderInputBindDescription* pDesc);

		[VtblIndex(6)]
		ID3D12FunctionParameterReflection GetFunctionParameter(int ParameterIndex);
	}
}

