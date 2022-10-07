// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList"]/*' />
/// <unmanaged>ID3D12GraphicsCommandList</unmanaged>
[Guid("5b160d0f-ac1b-4185-8ba8-b3ae42a5a455")]
[NativeTypeName("struct ID3D12GraphicsCommandList : ID3D12CommandList")]
[NativeInheritance("ID3D12CommandList")]
public unsafe partial struct ID3D12GraphicsCommandList : INativeGuid
{
	public static ref readonly Guid IID_ID3D12GraphicsCommandList
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x0F, 0x0D, 0x16, 0x5B,
				0x1B, 0xAC,
				0x85, 0x41,
				0x8B,
				0xA8,
				0xB3,
				0xAE,
				0x42,
				0xA5,
				0xA4,
				0x55
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12GraphicsCommandList));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12GraphicsCommandList));
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

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ushort*, int>)(lpVtbl[6]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <inheritdoc cref="ID3D12CommandList.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public new CommandListType GetType()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, CommandListType>)(lpVtbl[8]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this));
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::Close"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult Close()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, int>)(lpVtbl[9]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this));
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::Reset"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)(lpVtbl[10]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pAllocator, pInitialState);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ClearState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void ClearState(ID3D12PipelineState* pPipelineState)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12PipelineState*, void>)(lpVtbl[11]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pPipelineState);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::DrawInstanced"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, uint, uint, void>)(lpVtbl[12]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::DrawIndexedInstanced"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, uint, int, uint, void>)(lpVtbl[13]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::Dispatch"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, uint, void>)(lpVtbl[14]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::CopyBufferRegion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)(lpVtbl[15]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::CopyTextureRegion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)(lpVtbl[16]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::CopyResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12Resource*, ID3D12Resource*, void>)(lpVtbl[17]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::CopyTiles"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)(lpVtbl[18]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ResolveSubresource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Graphics.Dxgi.Common.Format Format)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12Resource*, uint, ID3D12Resource*, uint, Graphics.Dxgi.Common.Format, void>)(lpVtbl[19]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::IASetPrimitiveTopology"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void IASetPrimitiveTopology(Graphics.Direct3D.PrimitiveTopology PrimitiveTopology)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, Graphics.Direct3D.PrimitiveTopology, void>)(lpVtbl[20]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), PrimitiveTopology);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::RSSetViewports"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public void RSSetViewports(uint NumViewports, Viewport* pViewports)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, Viewport*, void>)(lpVtbl[21]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::RSSetScissorRects"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public void RSSetScissorRects(uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, RawRect*, void>)(lpVtbl[22]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumRects, pRects);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::OMSetBlendFactor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void OMSetBlendFactor(float* BlendFactor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, float*, void>)(lpVtbl[23]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), BlendFactor);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::OMSetStencilRef"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public void OMSetStencilRef(uint StencilRef)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, void>)(lpVtbl[24]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), StencilRef);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetPipelineState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public void SetPipelineState(ID3D12PipelineState* pPipelineState)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12PipelineState*, void>)(lpVtbl[25]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pPipelineState);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ResourceBarrier"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, ResourceBarrier*, void>)(lpVtbl[26]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ExecuteBundle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12GraphicsCommandList*, void>)(lpVtbl[27]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pCommandList);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetDescriptorHeaps"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public void SetDescriptorHeaps(uint NumDescriptorHeaps, ID3D12DescriptorHeap** ppDescriptorHeaps)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, ID3D12DescriptorHeap**, void>)(lpVtbl[28]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumDescriptorHeaps, ppDescriptorHeaps);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetComputeRootSignature"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public void SetComputeRootSignature(ID3D12RootSignature* pRootSignature)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12RootSignature*, void>)(lpVtbl[29]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pRootSignature);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetGraphicsRootSignature"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12RootSignature*, void>)(lpVtbl[30]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pRootSignature);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetComputeRootDescriptorTable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public void SetComputeRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle* BaseDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, GpuDescriptorHandle*, void>)(lpVtbl[31]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetGraphicsRootDescriptorTable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public void SetGraphicsRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle* BaseDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, GpuDescriptorHandle*, void>)(lpVtbl[32]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetComputeRoot32BitConstant"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, uint, void>)(lpVtbl[33]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetGraphicsRoot32BitConstant"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, uint, void>)(lpVtbl[34]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetComputeRoot32BitConstants"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, void*, uint, void>)(lpVtbl[35]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetGraphicsRoot32BitConstants"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, void*, uint, void>)(lpVtbl[36]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetComputeRootConstantBufferView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public void SetComputeRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, ulong, void>)(lpVtbl[37]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetGraphicsRootConstantBufferView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public void SetGraphicsRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, ulong, void>)(lpVtbl[38]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetComputeRootShaderResourceView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public void SetComputeRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, ulong, void>)(lpVtbl[39]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetGraphicsRootShaderResourceView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public void SetGraphicsRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, ulong, void>)(lpVtbl[40]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetComputeRootUnorderedAccessView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public void SetComputeRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, ulong, void>)(lpVtbl[41]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetGraphicsRootUnorderedAccessView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, ulong, void>)(lpVtbl[42]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::IASetIndexBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public void IASetIndexBuffer(IndexBufferView* pView)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, IndexBufferView*, void>)(lpVtbl[43]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pView);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::IASetVertexBuffers"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public void IASetVertexBuffers(uint StartSlot, uint NumViews, VertexBufferView* pViews)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, VertexBufferView*, void>)(lpVtbl[44]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SOSetTargets"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public void SOSetTargets(uint StartSlot, uint NumViews, StreamOutputBufferView* pViews)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, uint, StreamOutputBufferView*, void>)(lpVtbl[45]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::OMSetRenderTargets"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public void OMSetRenderTargets(uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, Bool32 RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, CpuDescriptorHandle*, Bool32, CpuDescriptorHandle*, void>)(lpVtbl[46]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ClearDepthStencilView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public void ClearDepthStencilView(CpuDescriptorHandle* DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, CpuDescriptorHandle*, ClearFlags, float, byte, uint, RawRect*, void>)(lpVtbl[47]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ClearRenderTargetView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public void ClearRenderTargetView(CpuDescriptorHandle* RenderTargetView, float* ColorRGBA, uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, CpuDescriptorHandle*, float*, uint, RawRect*, void>)(lpVtbl[48]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RenderTargetView, ColorRGBA, NumRects, pRects);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ClearUnorderedAccessViewUint"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public void ClearUnorderedAccessViewUint(GpuDescriptorHandle* ViewGPUHandleInCurrentHeap, CpuDescriptorHandle* ViewCPUHandle, ID3D12Resource* pResource, uint* Values, uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, GpuDescriptorHandle*, CpuDescriptorHandle*, ID3D12Resource*, uint*, uint, RawRect*, void>)(lpVtbl[49]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ClearUnorderedAccessViewFloat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public void ClearUnorderedAccessViewFloat(GpuDescriptorHandle* ViewGPUHandleInCurrentHeap, CpuDescriptorHandle* ViewCPUHandle, ID3D12Resource* pResource, float* Values, uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, GpuDescriptorHandle*, CpuDescriptorHandle*, ID3D12Resource*, float*, uint, RawRect*, void>)(lpVtbl[50]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::DiscardResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12Resource*, DiscardRegion*, void>)(lpVtbl[51]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pResource, pRegion);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::BeginQuery"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)(lpVtbl[52]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::EndQuery"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)(lpVtbl[53]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ResolveQueryData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)(lpVtbl[54]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetPredication"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOperation Operation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, PredicationOperation, void>)(lpVtbl[55]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::SetMarker"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public void SetMarker(uint Metadata, void* pData, uint Size)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, void*, uint, void>)(lpVtbl[56]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::BeginEvent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public void BeginEvent(uint Metadata, void* pData, uint Size)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, uint, void*, uint, void>)(lpVtbl[57]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::EndEvent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(58)]
	public void EndEvent()
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, void>)(lpVtbl[58]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this));
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList::ExecuteIndirect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(59)]
	public void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)(lpVtbl[59]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
	}
}

