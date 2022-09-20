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

namespace Win32.Graphics.Direct3D;

/// <include file='../../Direct3D.xml' path='doc/member[@name="ID3DInclude"]/*' />
/// <unmanaged>ID3DInclude</unmanaged>
public unsafe partial struct ID3DInclude
{
	public void** lpVtbl;

	/// <include file='../../Direct3D.xml' path='doc/member[@name="ID3DInclude::Open"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult Open(IncludeType IncludeType, sbyte* pFileName, void* pParentData, void** ppData, uint* pBytes)
	{
		return ((delegate* unmanaged[Stdcall]<ID3DInclude*, IncludeType, sbyte*, void*, void**, uint*, int>)(lpVtbl[0]))((ID3DInclude*)Unsafe.AsPointer(ref this), IncludeType, pFileName, pParentData, ppData, pBytes);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="ID3DInclude::Close"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public HResult Close(void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)(lpVtbl[1]))((ID3DInclude*)Unsafe.AsPointer(ref this), pData);
	}
}

