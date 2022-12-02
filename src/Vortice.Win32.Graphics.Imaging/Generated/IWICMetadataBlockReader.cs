// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockReader"]/*' />
/// <unmanaged>IWICMetadataBlockReader</unmanaged>
[Guid("feaa2a8d-b3f3-43e4-b25c-d1de990a1ae1")]
[NativeTypeName("struct IWICMetadataBlockReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICMetadataBlockReader : IWICMetadataBlockReader.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICMetadataBlockReader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x8D, 0x2A, 0xAA, 0xFE,
				0xF3, 0xB3,
				0xE4, 0x43,
				0xB2,
				0x5C,
				0xD1,
				0xDE,
				0x99,
				0x0A,
				0x1A,
				0xE1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockReader));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockReader));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint>)(lpVtbl[1]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint>)(lpVtbl[2]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockReader::GetContainerFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockReader::GetCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCount(uint* pcCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pcCount);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockReader::GetReaderByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockReader::GetEnumerator"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetEnumerator(Com.IEnumUnknown** ppIEnumMetadata)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Com.IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetContainerFormat(Guid* pguidContainerFormat);

		[VtblIndex(4)]
		HResult GetCount(uint* pcCount);

		[VtblIndex(5)]
		HResult GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader);

		[VtblIndex(6)]
		HResult GetEnumerator(Com.IEnumUnknown** ppIEnumMetadata);
	}
}

