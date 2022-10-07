// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference1"]/*' />
/// <unmanaged>IDWriteFontFaceReference1</unmanaged>
[Guid("c081fe77-2fd1-41ac-a5a3-34983c4ba61a")]
[NativeTypeName("struct IDWriteFontFaceReference1 : IDWriteFontFaceReference")]
[NativeInheritance("IDWriteFontFaceReference")]
public unsafe partial struct IDWriteFontFaceReference1 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFaceReference1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x77, 0xFE, 0x81, 0xC0,
				0xD1, 0x2F,
				0xAC, 0x41,
				0xA5,
				0xA3,
				0x34,
				0x98,
				0x3C,
				0x4B,
				0xA6,
				0x1A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFaceReference1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFaceReference1));
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

	/// <inheritdoc cref="IDWriteFontFaceReference.CreateFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateFontFace(IDWriteFontFace3** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)(lpVtbl[3]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.CreateFontFaceWithSimulations" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateFontFaceWithSimulations(FontSimulations fontFaceSimulationFlags, IDWriteFontFace3** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations, IDWriteFontFace3**, int>)(lpVtbl[4]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceSimulationFlags, fontFace);
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.Equals" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public Bool32 Equals(IDWriteFontFaceReference* fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, Bool32>)(lpVtbl[5]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceReference);
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.GetFontFaceIndex" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public uint GetFontFaceIndex()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)(lpVtbl[6]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.GetSimulations" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public FontSimulations GetSimulations()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations>)(lpVtbl[7]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.GetFontFile" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFontFile(IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFile);
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.GetLocalFileSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ulong GetLocalFileSize()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)(lpVtbl[9]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.GetFileSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ulong GetFileSize()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)(lpVtbl[10]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.GetFileTime" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFileTime(ulong* lastWriteTime)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong*, int>)(lpVtbl[11]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), lastWriteTime);
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.GetLocality" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public Locality GetLocality()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Locality>)(lpVtbl[12]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.EnqueueFontDownloadRequest" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult EnqueueFontDownloadRequest()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, int>)(lpVtbl[13]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.EnqueueCharacterDownloadRequest" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult EnqueueCharacterDownloadRequest(ushort* characters, uint characterCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)(lpVtbl[14]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), characters, characterCount);
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.EnqueueGlyphDownloadRequest" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult EnqueueGlyphDownloadRequest(ushort* glyphIndices, uint glyphCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)(lpVtbl[15]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount);
	}

	/// <inheritdoc cref="IDWriteFontFaceReference.EnqueueFileFragmentDownloadRequest" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong, ulong, int>)(lpVtbl[16]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference1::CreateFontFace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateFontFace(IDWriteFontFace5** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace5**, int>)(lpVtbl[17]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference1::GetFontAxisValueCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public uint GetFontAxisValueCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)(lpVtbl[18]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference1::GetFontAxisValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontAxisValue*, uint, int>)(lpVtbl[19]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
	}
}

