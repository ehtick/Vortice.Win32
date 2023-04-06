// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams2"]/*' />
/// <unmanaged>IDWriteRenderingParams2</unmanaged>
[Guid("f9d711c3-9777-40ae-87e8-3e5af9bf0948")]
[NativeTypeName("struct IDWriteRenderingParams2 : IDWriteRenderingParams1")]
[NativeInheritance("IDWriteRenderingParams1")]
public unsafe partial struct IDWriteRenderingParams2 : IDWriteRenderingParams2.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteRenderingParams2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC3, 0x11, 0xD7, 0xF9,
				0x77, 0x97,
				0xAE, 0x40,
				0x87,
				0xE8,
				0x3E,
				0x5A,
				0xF9,
				0xBF,
				0x09,
				0x48
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRenderingParams2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRenderingParams2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, uint>)(lpVtbl[1]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, uint>)(lpVtbl[1]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, uint>)(lpVtbl[2]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, uint>)(lpVtbl[2]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetGamma" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public float GetGamma()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, float>)(lpVtbl[3]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, float>)(lpVtbl[3]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetEnhancedContrast" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public float GetEnhancedContrast()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, float>)(lpVtbl[4]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, float>)(lpVtbl[4]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetClearTypeLevel" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public float GetClearTypeLevel()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, float>)(lpVtbl[5]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, float>)(lpVtbl[5]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetPixelGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public PixelGeometry GetPixelGeometry()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, PixelGeometry>)(lpVtbl[6]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, PixelGeometry>)(lpVtbl[6]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public RenderingMode GetRenderingMode()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, RenderingMode>)(lpVtbl[7]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, RenderingMode>)(lpVtbl[7]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteRenderingParams1.GetGrayscaleEnhancedContrast" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public float GetGrayscaleEnhancedContrast()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, float>)(lpVtbl[8]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, float>)(lpVtbl[8]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams2::GetGridFitMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public GridFitMode GetGridFitMode()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteRenderingParams2*, GridFitMode>)(lpVtbl[9]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, GridFitMode>)(lpVtbl[9]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : IDWriteRenderingParams1.Interface
	{
		[VtblIndex(9)]
		GridFitMode GetGridFitMode();
	}
}

