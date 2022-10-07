// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='Imaging.xml' path='doc/member[@name="IWICDdsDecoder"]/*' />
/// <unmanaged>IWICDdsDecoder</unmanaged>
[Guid("409cd537-8532-40cb-9774-e2feb2df4e9c")]
[NativeTypeName("struct IWICDdsDecoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICDdsDecoder : INativeGuid
{
	public static ref readonly Guid IID_IWICDdsDecoder
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x37, 0xD5, 0x9C, 0x40,
				0x32, 0x85,
				0xCB, 0x40,
				0x97,
				0x74,
				0xE2,
				0xFE,
				0xB2,
				0xDF,
				0x4E,
				0x9C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsDecoder));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsDecoder));
#endif

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

	/// <include file='Imaging.xml' path='doc/member[@name="IWICDdsDecoder::GetParameters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetParameters(WICDdsParameters* pParameters)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, WICDdsParameters*, int>)(lpVtbl[3]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this), pParameters);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICDdsDecoder::GetFrame"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFrame(uint arrayIndex, uint mipLevel, uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint, uint, uint, IWICBitmapFrameDecode**, int>)(lpVtbl[4]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this), arrayIndex, mipLevel, sliceIndex, ppIBitmapFrame);
	}
}

