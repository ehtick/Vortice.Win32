// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext2"]/*' />
/// <unmanaged>ID2D1EffectContext2</unmanaged>
[Guid("577ad2a0-9fc7-4dda-8b18-dab810140052")]
[NativeTypeName("struct ID2D1EffectContext2 : ID2D1EffectContext1")]
[NativeInheritance("ID2D1EffectContext1")]
public unsafe partial struct ID2D1EffectContext2 : INativeGuid
{
	public static ref readonly Guid IID_ID2D1EffectContext2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA0, 0xD2, 0x7A, 0x57,
				0xC7, 0x9F,
				0xDA, 0x4D,
				0x8B,
				0x18,
				0xDA,
				0xB8,
				0x10,
				0x14,
				0x00,
				0x52
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1EffectContext2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1EffectContext2));
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

	/// <inheritdoc cref="ID2D1EffectContext.GetDpi" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDpi(float* dpiX, float* dpiY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, float*, float*, void>)(lpVtbl[3]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateEffect(Guid* effectId, ID2D1Effect** effect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Guid*, ID2D1Effect**, int>)(lpVtbl[4]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), effectId, effect);
	}

	/// <inheritdoc cref="ID2D1EffectContext.GetMaximumSupportedFeatureLevel" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetMaximumSupportedFeatureLevel(Graphics.Direct3D.FeatureLevel* featureLevels, uint featureLevelsCount, Graphics.Direct3D.FeatureLevel* maximumSupportedFeatureLevel)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Graphics.Direct3D.FeatureLevel*, uint, Graphics.Direct3D.FeatureLevel*, int>)(lpVtbl[5]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateTransformNodeFromEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, ID2D1Effect*, ID2D1TransformNode**, int>)(lpVtbl[6]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), effect, transformNode);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateBlendTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateBlendTransform(uint numInputs, BlendDescription* blendDescription, ID2D1BlendTransform** transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, uint, BlendDescription*, ID2D1BlendTransform**, int>)(lpVtbl[7]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), numInputs, blendDescription, transform);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateBorderTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateBorderTransform(ExtendMode extendModeX, ExtendMode extendModeY, ID2D1BorderTransform** transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)(lpVtbl[8]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), extendModeX, extendModeY, transform);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateOffsetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateOffsetTransform(System.Drawing.Point offset, ID2D1OffsetTransform** transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, System.Drawing.Point, ID2D1OffsetTransform**, int>)(lpVtbl[9]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), offset, transform);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateBoundsAdjustmentTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateBoundsAdjustmentTransform(RawRect* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, RawRect*, ID2D1BoundsAdjustmentTransform**, int>)(lpVtbl[10]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), outputRectangle, transform);
	}

	/// <inheritdoc cref="ID2D1EffectContext.LoadPixelShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult LoadPixelShader(Guid* shaderId, byte* shaderBuffer, uint shaderBufferCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Guid*, byte*, uint, int>)(lpVtbl[11]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), shaderId, shaderBuffer, shaderBufferCount);
	}

	/// <inheritdoc cref="ID2D1EffectContext.LoadVertexShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult LoadVertexShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Guid*, byte*, uint, int>)(lpVtbl[12]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
	}

	/// <inheritdoc cref="ID2D1EffectContext.LoadComputeShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult LoadComputeShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Guid*, byte*, uint, int>)(lpVtbl[13]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
	}

	/// <inheritdoc cref="ID2D1EffectContext.IsShaderLoaded" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public Bool32 IsShaderLoaded(Guid* shaderId)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Guid*, Bool32>)(lpVtbl[14]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), shaderId);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateResourceTexture" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)(lpVtbl[15]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
	}

	/// <inheritdoc cref="ID2D1EffectContext.FindResourceTexture" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult FindResourceTexture(Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Guid*, ID2D1ResourceTexture**, int>)(lpVtbl[16]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, resourceTexture);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateVertexBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)(lpVtbl[17]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
	}

	/// <inheritdoc cref="ID2D1EffectContext.FindVertexBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult FindVertexBuffer(Guid* resourceId, ID2D1VertexBuffer** buffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Guid*, ID2D1VertexBuffer**, int>)(lpVtbl[18]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, buffer);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateColorContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)(lpVtbl[19]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateColorContextFromFilename" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateColorContextFromFilename(ushort* filename, ID2D1ColorContext** colorContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, ushort*, ID2D1ColorContext**, int>)(lpVtbl[20]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), filename, colorContext);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CreateColorContextFromWicColorContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateColorContextFromWicColorContext(Graphics.Imaging.IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Graphics.Imaging.IWICColorContext*, ID2D1ColorContext**, int>)(lpVtbl[21]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
	}

	/// <inheritdoc cref="ID2D1EffectContext.CheckFeatureSupport" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CheckFeatureSupport(Feature feature, void* featureSupportData, uint featureSupportDataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Feature, void*, uint, int>)(lpVtbl[22]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), feature, featureSupportData, featureSupportDataSize);
	}

	/// <inheritdoc cref="ID2D1EffectContext.IsBufferPrecisionSupported" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public Bool32 IsBufferPrecisionSupported(BufferPrecision bufferPrecision)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, BufferPrecision, Bool32>)(lpVtbl[23]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), bufferPrecision);
	}

	/// <inheritdoc cref="ID2D1EffectContext1.CreateLookupTable3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)(lpVtbl[24]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), precision, extents, data, dataCount, strides, lookupTable);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext2::CreateColorContextFromDxgiColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateColorContextFromDxgiColorSpace(Graphics.Dxgi.Common.ColorSpaceType colorSpace, ID2D1ColorContext1** colorContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, Graphics.Dxgi.Common.ColorSpaceType, ID2D1ColorContext1**, int>)(lpVtbl[25]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), colorSpace, colorContext);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext2::CreateColorContextFromSimpleColorProfile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult CreateColorContextFromSimpleColorProfile(SimpleColorProfile* simpleProfile, ID2D1ColorContext1** colorContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext2*, SimpleColorProfile*, ID2D1ColorContext1**, int>)(lpVtbl[26]))((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), simpleProfile, colorContext);
	}
}

