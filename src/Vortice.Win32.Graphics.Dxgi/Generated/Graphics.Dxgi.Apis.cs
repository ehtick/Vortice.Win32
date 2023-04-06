// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

public static partial class Apis
{
	public const uint DXGI_MAX_SWAP_CHAIN_BUFFERS = 16;

	public const uint DXGI_SHARED_RESOURCE_READ = 2147483648;

	public const uint DXGI_SHARED_RESOURCE_WRITE = 1;

	public const uint DXGI_DEBUG_BINARY_VERSION = 1;

	public static ref readonly Guid DXGI_DEBUG_ALL
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x83, 0xE2, 0x8A, 0xE4,
				0x80, 0xDA,
				0x0B, 0x49,
				0x87,
				0xE6,
				0x43,
				0xE9,
				0xA9,
				0xCF,
				0xDA,
				0x08
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static ref readonly Guid DXGI_DEBUG_DX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFC, 0xD7, 0xCD, 0x35,
				0xB2, 0x13,
				0x1D, 0x42,
				0xA5,
				0xD7,
				0x7E,
				0x44,
				0x51,
				0x28,
				0x7D,
				0x64
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static ref readonly Guid DXGI_DEBUG_DXGI
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA4, 0xDA, 0xCD, 0x25,
				0xC6, 0xB1,
				0xE1, 0x47,
				0xAC,
				0x3E,
				0x98,
				0x87,
				0x5B,
				0x5A,
				0x2E,
				0x2A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static ref readonly Guid DXGI_DEBUG_APP
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x01, 0x6E, 0xCD, 0x06,
				0x19, 0x42,
				0xBD, 0x4E,
				0x87,
				0x09,
				0x27,
				0xED,
				0x23,
				0x36,
				0x0C,
				0x62
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public const uint DXGI_INFO_QUEUE_MESSAGE_ID_STRING_FROM_APPLICATION = 0;

	public const uint DXGI_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;

	public const uint DXGI_CREATE_FACTORY_DEBUG = 1;

	public static readonly HResult DXGI_ERROR_INVALID_CALL = -2005270527;

	public static readonly HResult DXGI_ERROR_NOT_FOUND = -2005270526;

	public static readonly HResult DXGI_ERROR_MORE_DATA = -2005270525;

	public static readonly HResult DXGI_ERROR_UNSUPPORTED = -2005270524;

	public static readonly HResult DXGI_ERROR_DEVICE_REMOVED = -2005270523;

	public static readonly HResult DXGI_ERROR_DEVICE_HUNG = -2005270522;

	public static readonly HResult DXGI_ERROR_DEVICE_RESET = -2005270521;

	public static readonly HResult DXGI_ERROR_WAS_STILL_DRAWING = -2005270518;

	public static readonly HResult DXGI_ERROR_FRAME_STATISTICS_DISJOINT = -2005270517;

	public static readonly HResult DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = -2005270516;

	public static readonly HResult DXGI_ERROR_DRIVER_INTERNAL_ERROR = -2005270496;

	public static readonly HResult DXGI_ERROR_NONEXCLUSIVE = -2005270495;

	public static readonly HResult DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = -2005270494;

	public static readonly HResult DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = -2005270493;

	public static readonly HResult DXGI_ERROR_REMOTE_OUTOFMEMORY = -2005270492;

	public static readonly HResult DXGI_ERROR_ACCESS_LOST = -2005270490;

	public static readonly HResult DXGI_ERROR_WAIT_TIMEOUT = -2005270489;

	public static readonly HResult DXGI_ERROR_SESSION_DISCONNECTED = -2005270488;

	public static readonly HResult DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = -2005270487;

	public static readonly HResult DXGI_ERROR_CANNOT_PROTECT_CONTENT = -2005270486;

	public static readonly HResult DXGI_ERROR_ACCESS_DENIED = -2005270485;

	public static readonly HResult DXGI_ERROR_NAME_ALREADY_EXISTS = -2005270484;

	public static readonly HResult DXGI_ERROR_SDK_COMPONENT_MISSING = -2005270483;

	public static readonly HResult DXGI_ERROR_NOT_CURRENT = -2005270482;

	public static readonly HResult DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = -2005270480;

	public static readonly HResult DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION = -2005270479;

	public static readonly HResult DXGI_ERROR_NON_COMPOSITED_UI = -2005270478;

	public static readonly HResult DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = -2005270491;

	public static readonly HResult DXGI_ERROR_CACHE_CORRUPT = -2005270477;

	public static readonly HResult DXGI_ERROR_CACHE_FULL = -2005270476;

	public static readonly HResult DXGI_ERROR_CACHE_HASH_COLLISION = -2005270475;

	public static readonly HResult DXGI_ERROR_ALREADY_EXISTS = -2005270474;

	public static readonly HResult DXGI_ERROR_MPO_UNPINNED = -2005270428;
}

