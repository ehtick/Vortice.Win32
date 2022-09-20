// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Numerics;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Direct3D12;

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection"]/*' />
/// <unmanaged>ID3D12ShaderReflection</unmanaged>
[Guid("5a58797d-a72c-478d-8ba2-efc6b0efe88e")]
[NativeTypeName("struct ID3D12ShaderReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12ShaderReflection
{
	public static ref readonly Guid IID_ID3D12ShaderReflection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x7D, 0x79, 0x58, 0x5A,
				0x2C, 0xA7,
				0x8D, 0x47,
				0x8B,
				0xA2,
				0xEF,
				0xC6,
				0xB0,
				0xEF,
				0xE8,
				0x8E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ShaderReflection));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetDesc(ShaderDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, ShaderDescription*, int>)(lpVtbl[3]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetConstantBufferByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, ID3D12ShaderReflectionConstantBuffer>)(lpVtbl[4]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Index);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetConstantBufferByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName(sbyte* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, sbyte*, ID3D12ShaderReflectionConstantBuffer>)(lpVtbl[5]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetResourceBindingDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, ShaderInputBindDescription*, int>)(lpVtbl[6]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetInputParameterDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetInputParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDescription*, int>)(lpVtbl[7]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetOutputParameterDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetOutputParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDescription*, int>)(lpVtbl[8]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetPatchConstantParameterDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetPatchConstantParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDescription*, int>)(lpVtbl[9]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetVariableByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ID3D12ShaderReflectionVariable GetVariableByName(sbyte* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, sbyte*, ID3D12ShaderReflectionVariable>)(lpVtbl[10]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetResourceBindingDescByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetResourceBindingDescByName(sbyte* Name, ShaderInputBindDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, sbyte*, ShaderInputBindDescription*, int>)(lpVtbl[11]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetMovInstructionCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public uint GetMovInstructionCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(lpVtbl[12]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetMovcInstructionCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public uint GetMovcInstructionCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(lpVtbl[13]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetConversionInstructionCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public uint GetConversionInstructionCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(lpVtbl[14]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetBitwiseInstructionCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public uint GetBitwiseInstructionCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(lpVtbl[15]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetGSInputPrimitive"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public Graphics.Direct3D.Primitive GetGSInputPrimitive()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Graphics.Direct3D.Primitive>)(lpVtbl[16]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::IsSampleFrequencyShader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public Bool32 IsSampleFrequencyShader()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Bool32>)(lpVtbl[17]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetNumInterfaceSlots"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public uint GetNumInterfaceSlots()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(lpVtbl[18]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetMinFeatureLevel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetMinFeatureLevel(Graphics.Direct3D.FeatureLevel* pLevel)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Graphics.Direct3D.FeatureLevel*, int>)(lpVtbl[19]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetThreadGroupSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(lpVtbl[20]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflection::GetRequiresFlags"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public ulong GetRequiresFlags()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, ulong>)(lpVtbl[21]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
	}
}

