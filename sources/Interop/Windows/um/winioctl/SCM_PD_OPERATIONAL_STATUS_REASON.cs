// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SCM_PD_OPERATIONAL_STATUS_REASON
    {
        ScmPhysicalDeviceOpReason_Unknown = 0,
        ScmPhysicalDeviceOpReason_Media,
        ScmPhysicalDeviceOpReason_ThresholdExceeded,
        ScmPhysicalDeviceOpReason_LostData,
        ScmPhysicalDeviceOpReason_EnergySource,
        ScmPhysicalDeviceOpReason_Configuration,
        ScmPhysicalDeviceOpReason_DeviceController,
        ScmPhysicalDeviceOpReason_MediaController,
        ScmPhysicalDeviceOpReason_Component,
        ScmPhysicalDeviceOpReason_BackgroundOperation,
        ScmPhysicalDeviceOpReason_InvalidFirmware,
        ScmPhysicalDeviceOpReason_HealthCheck,
        ScmPhysicalDeviceOpReason_LostDataPersistence,
        ScmPhysicalDeviceOpReason_DisabledByPlatform,
        ScmPhysicalDeviceOpReason_PermanentError,
        ScmPhysicalDeviceOpReason_LostWritePersistence,
        ScmPhysicalDeviceOpReason_FatalError,
        ScmPhysicalDeviceOpReason_DataPersistenceLossImminent,
        ScmPhysicalDeviceOpReason_WritePersistenceLossImminent,
        ScmPhysicalDeviceOpReason_MediaRemainingSpareBlock,
        ScmPhysicalDeviceOpReason_PerformanceDegradation,
        ScmPhysicalDeviceOpReason_ExcessiveTemperature,
        ScmPhysicalDeviceOpReason_Max,
    }
}
