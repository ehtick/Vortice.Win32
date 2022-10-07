// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Device1"]/*' />
/// <unmanaged>ID3D12Device1</unmanaged>
[Guid("77acce80-638e-4e65-8895-c1f23386863e")]
[NativeTypeName("struct ID3D12Device1 : ID3D12Device")]
[NativeInheritance("ID3D12Device")]
public unsafe partial struct ID3D12Device1 : INativeGuid
{
	public static ref readonly Guid IID_ID3D12Device1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x80, 0xCE, 0xAC, 0x77,
				0x8E, 0x63,
				0x65, 0x4E,
				0x88,
				0x95,
				0xC1,
				0xF2,
				0x33,
				0x86,
				0x86,
				0x3E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Device1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Device1));
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
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Device1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Device1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Device1*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, ushort*, int>)(lpVtbl[6]))((ID3D12Device1*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12Device.GetNodeCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetNodeCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, uint>)(lpVtbl[7]))((ID3D12Device1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Device.CreateCommandQueue" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateCommandQueue(CommandQueueDescription* pDesc, Guid* riid, void** ppCommandQueue)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, CommandQueueDescription*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
	}

	/// <inheritdoc cref="ID3D12Device.CreateCommandAllocator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateCommandAllocator(CommandListType type, Guid* riid, void** ppCommandAllocator)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, CommandListType, Guid*, void**, int>)(lpVtbl[9]))((ID3D12Device1*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
	}

	/// <inheritdoc cref="ID3D12Device.CreateGraphicsPipelineState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateGraphicsPipelineState(GraphicsPipelineStateDescription* pDesc, Guid* riid, void** ppPipelineState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, GraphicsPipelineStateDescription*, Guid*, void**, int>)(lpVtbl[10]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
	}

	/// <inheritdoc cref="ID3D12Device.CreateComputePipelineState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateComputePipelineState(ComputePipelineStateDescription* pDesc, Guid* riid, void** ppPipelineState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, ComputePipelineStateDescription*, Guid*, void**, int>)(lpVtbl[11]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
	}

	/// <inheritdoc cref="ID3D12Device.CreateCommandList" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)(lpVtbl[12]))((ID3D12Device1*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
	}

	/// <inheritdoc cref="ID3D12Device.CheckFeatureSupport" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, Feature, void*, uint, int>)(lpVtbl[13]))((ID3D12Device1*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
	}

	/// <inheritdoc cref="ID3D12Device.CreateDescriptorHeap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateDescriptorHeap(DescriptorHeapDescription* pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, DescriptorHeapDescription*, Guid*, void**, int>)(lpVtbl[14]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
	}

	/// <inheritdoc cref="ID3D12Device.GetDescriptorHandleIncrementSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public uint GetDescriptorHandleIncrementSize(DescriptorHeapType DescriptorHeapType)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, DescriptorHeapType, uint>)(lpVtbl[15]))((ID3D12Device1*)Unsafe.AsPointer(ref this), DescriptorHeapType);
	}

	/// <inheritdoc cref="ID3D12Device.CreateRootSignature" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, uint, void*, nuint, Guid*, void**, int>)(lpVtbl[16]))((ID3D12Device1*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
	}

	/// <inheritdoc cref="ID3D12Device.CreateConstantBufferView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void CreateConstantBufferView(ConstantBufferViewDescription* pDesc, CpuDescriptorHandle* DestDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, ConstantBufferViewDescription*, CpuDescriptorHandle*, void>)(lpVtbl[17]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
	}

	/// <inheritdoc cref="ID3D12Device.CreateShaderResourceView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void CreateShaderResourceView(ID3D12Resource* pResource, ShaderResourceViewDescription* pDesc, CpuDescriptorHandle* DestDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, ID3D12Resource*, ShaderResourceViewDescription*, CpuDescriptorHandle*, void>)(lpVtbl[18]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
	}

	/// <inheritdoc cref="ID3D12Device.CreateUnorderedAccessView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDescription* pDesc, CpuDescriptorHandle* DestDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDescription*, CpuDescriptorHandle*, void>)(lpVtbl[19]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pResource, pCounterResource, pDesc, DestDescriptor);
	}

	/// <inheritdoc cref="ID3D12Device.CreateRenderTargetView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void CreateRenderTargetView(ID3D12Resource* pResource, RenderTargetViewDescription* pDesc, CpuDescriptorHandle* DestDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, ID3D12Resource*, RenderTargetViewDescription*, CpuDescriptorHandle*, void>)(lpVtbl[20]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
	}

	/// <inheritdoc cref="ID3D12Device.CreateDepthStencilView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public void CreateDepthStencilView(ID3D12Resource* pResource, DepthStencilViewDescription* pDesc, CpuDescriptorHandle* DestDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, ID3D12Resource*, DepthStencilViewDescription*, CpuDescriptorHandle*, void>)(lpVtbl[21]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
	}

	/// <inheritdoc cref="ID3D12Device.CreateSampler" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public void CreateSampler(SamplerDescription* pDesc, CpuDescriptorHandle* DestDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, SamplerDescription*, CpuDescriptorHandle*, void>)(lpVtbl[22]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
	}

	/// <inheritdoc cref="ID3D12Device.CopyDescriptors" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)(lpVtbl[23]))((ID3D12Device1*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
	}

	/// <inheritdoc cref="ID3D12Device.CopyDescriptorsSimple" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public void CopyDescriptorsSimple(uint NumDescriptors, CpuDescriptorHandle* DestDescriptorRangeStart, CpuDescriptorHandle* SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, uint, CpuDescriptorHandle*, CpuDescriptorHandle*, DescriptorHeapType, void>)(lpVtbl[24]))((ID3D12Device1*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
	}

	/// <inheritdoc cref="ID3D12Device.GetResourceAllocationInfo" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, ResourceDescription* pResourceDescs)
	{
		ResourceAllocationInfo result;
		return *((delegate* unmanaged[Stdcall]<ID3D12Device1*, ResourceAllocationInfo*, uint, uint, ResourceDescription*, ResourceAllocationInfo*>)(lpVtbl[25]))((ID3D12Device1*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
	}

	/// <inheritdoc cref="ID3D12Device.GetCustomHeapProperties" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HeapProperties GetCustomHeapProperties(uint nodeMask, HeapType heapType)
	{
		HeapProperties result;
		return *((delegate* unmanaged[Stdcall]<ID3D12Device1*, HeapProperties*, uint, HeapType, HeapProperties*>)(lpVtbl[26]))((ID3D12Device1*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
	}

	/// <inheritdoc cref="ID3D12Device.CreateCommittedResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDescription* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, HeapProperties*, HeapFlags, ResourceDescription*, ResourceStates, ClearValue*, Guid*, void**, int>)(lpVtbl[27]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
	}

	/// <inheritdoc cref="ID3D12Device.CreateHeap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult CreateHeap(HeapDescription* pDesc, Guid* riid, void** ppvHeap)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, HeapDescription*, Guid*, void**, int>)(lpVtbl[28]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
	}

	/// <inheritdoc cref="ID3D12Device.CreatePlacedResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDescription* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, ID3D12Heap*, ulong, ResourceDescription*, ResourceStates, ClearValue*, Guid*, void**, int>)(lpVtbl[29]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
	}

	/// <inheritdoc cref="ID3D12Device.CreateReservedResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CreateReservedResource(ResourceDescription* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, ResourceDescription*, ResourceStates, ClearValue*, Guid*, void**, int>)(lpVtbl[30]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
	}

	/// <inheritdoc cref="ID3D12Device.CreateSharedHandle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult CreateSharedHandle(ID3D12DeviceChild* pObject, Security.SECURITY_ATTRIBUTES* pAttributes, uint Access, ushort* Name, Handle* pHandle)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, ID3D12DeviceChild*, Security.SECURITY_ATTRIBUTES*, uint, ushort*, Handle*, int>)(lpVtbl[31]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pObject, pAttributes, Access, Name, pHandle);
	}

	/// <inheritdoc cref="ID3D12Device.OpenSharedHandle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult OpenSharedHandle(Handle NTHandle, Guid* riid, void** ppvObj)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, Handle, Guid*, void**, int>)(lpVtbl[32]))((ID3D12Device1*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
	}

	/// <inheritdoc cref="ID3D12Device.OpenSharedHandleByName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult OpenSharedHandleByName(ushort* Name, uint Access, Handle* pNTHandle)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, ushort*, uint, Handle*, int>)(lpVtbl[33]))((ID3D12Device1*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
	}

	/// <inheritdoc cref="ID3D12Device.MakeResident" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult MakeResident(uint NumObjects, ID3D12Pageable** ppObjects)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, uint, ID3D12Pageable**, int>)(lpVtbl[34]))((ID3D12Device1*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
	}

	/// <inheritdoc cref="ID3D12Device.Evict" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult Evict(uint NumObjects, ID3D12Pageable** ppObjects)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, uint, ID3D12Pageable**, int>)(lpVtbl[35]))((ID3D12Device1*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
	}

	/// <inheritdoc cref="ID3D12Device.CreateFence" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult CreateFence(ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, ulong, FenceFlags, Guid*, void**, int>)(lpVtbl[36]))((ID3D12Device1*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
	}

	/// <inheritdoc cref="ID3D12Device.GetDeviceRemovedReason" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult GetDeviceRemovedReason()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, int>)(lpVtbl[37]))((ID3D12Device1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Device.GetCopyableFootprints" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public void GetCopyableFootprints(ResourceDescription* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, ResourceDescription*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)(lpVtbl[38]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
	}

	/// <inheritdoc cref="ID3D12Device.CreateQueryHeap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult CreateQueryHeap(QueryHeapDescription* pDesc, Guid* riid, void** ppvHeap)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, QueryHeapDescription*, Guid*, void**, int>)(lpVtbl[39]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
	}

	/// <inheritdoc cref="ID3D12Device.SetStablePowerState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult SetStablePowerState(Bool32 Enable)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, Bool32, int>)(lpVtbl[40]))((ID3D12Device1*)Unsafe.AsPointer(ref this), Enable);
	}

	/// <inheritdoc cref="ID3D12Device.CreateCommandSignature" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult CreateCommandSignature(CommandSignatureDescription* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, CommandSignatureDescription*, ID3D12RootSignature*, Guid*, void**, int>)(lpVtbl[41]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pDesc, pRootSignature, riid, ppvCommandSignature);
	}

	/// <inheritdoc cref="ID3D12Device.GetResourceTiling" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Device1*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)(lpVtbl[42]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
	}

	/// <inheritdoc cref="ID3D12Device.GetAdapterLuid" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public Luid GetAdapterLuid()
	{
		Luid result;
		return *((delegate* unmanaged[Stdcall]<ID3D12Device1*, Luid*, Luid*>)(lpVtbl[43]))((ID3D12Device1*)Unsafe.AsPointer(ref this), &result);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Device1::CreatePipelineLibrary"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public HResult CreatePipelineLibrary(void* pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, void*, nuint, Guid*, void**, int>)(lpVtbl[44]))((ID3D12Device1*)Unsafe.AsPointer(ref this), pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Device1::SetEventOnMultipleFenceCompletion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public HResult SetEventOnMultipleFenceCompletion(ID3D12Fence** ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, Handle hEvent)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, Handle, int>)(lpVtbl[45]))((ID3D12Device1*)Unsafe.AsPointer(ref this), ppFences, pFenceValues, NumFences, Flags, hEvent);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Device1::SetResidencyPriority"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public HResult SetResidencyPriority(uint NumObjects, ID3D12Pageable** ppObjects, ResidencyPriority* pPriorities)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Device1*, uint, ID3D12Pageable**, ResidencyPriority*, int>)(lpVtbl[46]))((ID3D12Device1*)Unsafe.AsPointer(ref this), NumObjects, ppObjects, pPriorities);
	}
}

