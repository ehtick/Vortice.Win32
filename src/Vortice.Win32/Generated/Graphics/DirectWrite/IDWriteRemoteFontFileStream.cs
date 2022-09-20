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

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileStream"]/*' />
/// <unmanaged>IDWriteRemoteFontFileStream</unmanaged>
[Guid("4db3757a-2c72-4ed9-b2b6-1ababe1aff9c")]
[NativeTypeName("struct IDWriteRemoteFontFileStream : IDWriteFontFileStream")]
[NativeInheritance("IDWriteFontFileStream")]
public unsafe partial struct IDWriteRemoteFontFileStream
{
	public static ref readonly Guid IID_IDWriteRemoteFontFileStream
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x7A, 0x75, 0xB3, 0x4D,
				0x72, 0x2C,
				0xD9, 0x4E,
				0xB2,
				0xB6,
				0x1A,
				0xBA,
				0xBE,
				0x1A,
				0xFF,
				0x9C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRemoteFontFileStream));

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

	/// <inheritdoc cref="IDWriteFontFileStream.ReadFileFragment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ReadFileFragment(void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)(lpVtbl[3]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentStart, fileOffset, fragmentSize, fragmentContext);
	}

	/// <inheritdoc cref="IDWriteFontFileStream.ReleaseFileFragment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ReleaseFileFragment(void* fragmentContext)
	{
		((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void*, void>)(lpVtbl[4]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentContext);
	}

	/// <inheritdoc cref="IDWriteFontFileStream.GetFileSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetFileSize(ulong* fileSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[5]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileSize);
	}

	/// <inheritdoc cref="IDWriteFontFileStream.GetLastWriteTime" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetLastWriteTime(ulong* lastWriteTime)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[6]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), lastWriteTime);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileStream::GetLocalFileSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetLocalFileSize(ulong* localFileSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[7]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), localFileSize);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileStream::GetFileFragmentLocality"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFileFragmentLocality(ulong fileOffset, ulong fragmentSize, Bool32* isLocal, ulong* partialSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, Bool32*, ulong*, int>)(lpVtbl[8]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize, isLocal, partialSize);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileStream::GetLocality"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public Locality GetLocality()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Locality>)(lpVtbl[9]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileStream::BeginDownload"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult BeginDownload(Guid* downloadOperationID, FileFragment* fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)(lpVtbl[10]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), downloadOperationID, fileFragments, fragmentCount, asyncResult);
	}
}

