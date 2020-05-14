using System;

namespace TSN.Native.Enums
{
	// Token: 0x02000365 RID: 869
	public enum NtStatus : uint
	{
		// Token: 0x04000E44 RID: 3652
		Success,
		// Token: 0x04000E45 RID: 3653
		Wait0 = 0U,
		// Token: 0x04000E46 RID: 3654
		Wait1,
		// Token: 0x04000E47 RID: 3655
		Wait2,
		// Token: 0x04000E48 RID: 3656
		Wait3,
		// Token: 0x04000E49 RID: 3657
		Wait63 = 63U,
		// Token: 0x04000E4A RID: 3658
		Abandoned = 128U,
		// Token: 0x04000E4B RID: 3659
		AbandonedWait0 = 128U,
		// Token: 0x04000E4C RID: 3660
		AbandonedWait1,
		// Token: 0x04000E4D RID: 3661
		AbandonedWait2,
		// Token: 0x04000E4E RID: 3662
		AbandonedWait3,
		// Token: 0x04000E4F RID: 3663
		AbandonedWait63 = 191U,
		// Token: 0x04000E50 RID: 3664
		UserApc,
		// Token: 0x04000E51 RID: 3665
		KernelApc = 256U,
		// Token: 0x04000E52 RID: 3666
		Alerted,
		// Token: 0x04000E53 RID: 3667
		Timeout,
		// Token: 0x04000E54 RID: 3668
		Pending,
		// Token: 0x04000E55 RID: 3669
		Reparse,
		// Token: 0x04000E56 RID: 3670
		MoreEntries,
		// Token: 0x04000E57 RID: 3671
		NotAllAssigned,
		// Token: 0x04000E58 RID: 3672
		SomeNotMapped,
		// Token: 0x04000E59 RID: 3673
		OpLockBreakInProgress,
		// Token: 0x04000E5A RID: 3674
		VolumeMounted,
		// Token: 0x04000E5B RID: 3675
		RxActCommitted,
		// Token: 0x04000E5C RID: 3676
		NotifyCleanup,
		// Token: 0x04000E5D RID: 3677
		NotifyEnumDir,
		// Token: 0x04000E5E RID: 3678
		NoQuotasForAccount,
		// Token: 0x04000E5F RID: 3679
		PrimaryTransportConnectFailed,
		// Token: 0x04000E60 RID: 3680
		PageFaultTransition = 272U,
		// Token: 0x04000E61 RID: 3681
		PageFaultDemandZero,
		// Token: 0x04000E62 RID: 3682
		PageFaultCopyOnWrite,
		// Token: 0x04000E63 RID: 3683
		PageFaultGuardPage,
		// Token: 0x04000E64 RID: 3684
		PageFaultPagingFile,
		// Token: 0x04000E65 RID: 3685
		CrashDump = 278U,
		// Token: 0x04000E66 RID: 3686
		ReparseObject = 280U,
		// Token: 0x04000E67 RID: 3687
		NothingToTerminate = 290U,
		// Token: 0x04000E68 RID: 3688
		ProcessNotInJob,
		// Token: 0x04000E69 RID: 3689
		ProcessInJob,
		// Token: 0x04000E6A RID: 3690
		ProcessCloned = 297U,
		// Token: 0x04000E6B RID: 3691
		FileLockedWithOnlyReaders,
		// Token: 0x04000E6C RID: 3692
		FileLockedWithWriters,
		// Token: 0x04000E6D RID: 3693
		Informational = 1073741824U,
		// Token: 0x04000E6E RID: 3694
		ObjectNameExists = 1073741824U,
		// Token: 0x04000E6F RID: 3695
		ThreadWasSuspended,
		// Token: 0x04000E70 RID: 3696
		WorkingSetLimitRange,
		// Token: 0x04000E71 RID: 3697
		ImageNotAtBase,
		// Token: 0x04000E72 RID: 3698
		RegistryRecovered = 1073741833U,
		// Token: 0x04000E73 RID: 3699
		Warning = 2147483648U,
		// Token: 0x04000E74 RID: 3700
		GuardPageViolation,
		// Token: 0x04000E75 RID: 3701
		DatatypeMisalignment,
		// Token: 0x04000E76 RID: 3702
		Breakpoint,
		// Token: 0x04000E77 RID: 3703
		SingleStep,
		// Token: 0x04000E78 RID: 3704
		BufferOverflow,
		// Token: 0x04000E79 RID: 3705
		NoMoreFiles,
		// Token: 0x04000E7A RID: 3706
		HandlesClosed = 2147483658U,
		// Token: 0x04000E7B RID: 3707
		PartialCopy = 2147483661U,
		// Token: 0x04000E7C RID: 3708
		DeviceBusy = 2147483665U,
		// Token: 0x04000E7D RID: 3709
		InvalidEaName = 2147483667U,
		// Token: 0x04000E7E RID: 3710
		EaListInconsistent,
		// Token: 0x04000E7F RID: 3711
		NoMoreEntries = 2147483674U,
		// Token: 0x04000E80 RID: 3712
		LongJump = 2147483686U,
		// Token: 0x04000E81 RID: 3713
		DllMightBeInsecure = 2147483691U,
		// Token: 0x04000E82 RID: 3714
		Error = 3221225472U,
		// Token: 0x04000E83 RID: 3715
		Unsuccessful,
		// Token: 0x04000E84 RID: 3716
		NotImplemented,
		// Token: 0x04000E85 RID: 3717
		InvalidInfoClass,
		// Token: 0x04000E86 RID: 3718
		InfoLengthMismatch,
		// Token: 0x04000E87 RID: 3719
		AccessViolation,
		// Token: 0x04000E88 RID: 3720
		InPageError,
		// Token: 0x04000E89 RID: 3721
		PagefileQuota,
		// Token: 0x04000E8A RID: 3722
		InvalidHandle,
		// Token: 0x04000E8B RID: 3723
		BadInitialStack,
		// Token: 0x04000E8C RID: 3724
		BadInitialPc,
		// Token: 0x04000E8D RID: 3725
		InvalidCid,
		// Token: 0x04000E8E RID: 3726
		TimerNotCanceled,
		// Token: 0x04000E8F RID: 3727
		InvalidParameter,
		// Token: 0x04000E90 RID: 3728
		NoSuchDevice,
		// Token: 0x04000E91 RID: 3729
		NoSuchFile,
		// Token: 0x04000E92 RID: 3730
		InvalidDeviceRequest,
		// Token: 0x04000E93 RID: 3731
		EndOfFile,
		// Token: 0x04000E94 RID: 3732
		WrongVolume,
		// Token: 0x04000E95 RID: 3733
		NoMediaInDevice,
		// Token: 0x04000E96 RID: 3734
		NoMemory = 3221225495U,
		// Token: 0x04000E97 RID: 3735
		NotMappedView = 3221225497U,
		// Token: 0x04000E98 RID: 3736
		UnableToFreeVm,
		// Token: 0x04000E99 RID: 3737
		UnableToDeleteSection,
		// Token: 0x04000E9A RID: 3738
		IllegalInstruction = 3221225501U,
		// Token: 0x04000E9B RID: 3739
		AlreadyCommitted = 3221225505U,
		// Token: 0x04000E9C RID: 3740
		AccessDenied,
		// Token: 0x04000E9D RID: 3741
		BufferTooSmall,
		// Token: 0x04000E9E RID: 3742
		ObjectTypeMismatch,
		// Token: 0x04000E9F RID: 3743
		NonContinuableException,
		// Token: 0x04000EA0 RID: 3744
		BadStack = 3221225512U,
		// Token: 0x04000EA1 RID: 3745
		NotLocked = 3221225514U,
		// Token: 0x04000EA2 RID: 3746
		NotCommitted = 3221225517U,
		// Token: 0x04000EA3 RID: 3747
		InvalidParameterMix = 3221225520U,
		// Token: 0x04000EA4 RID: 3748
		ObjectNameInvalid = 3221225523U,
		// Token: 0x04000EA5 RID: 3749
		ObjectNameNotFound,
		// Token: 0x04000EA6 RID: 3750
		ObjectNameCollision,
		// Token: 0x04000EA7 RID: 3751
		ObjectPathInvalid = 3221225529U,
		// Token: 0x04000EA8 RID: 3752
		ObjectPathNotFound,
		// Token: 0x04000EA9 RID: 3753
		ObjectPathSyntaxBad,
		// Token: 0x04000EAA RID: 3754
		DataOverrun,
		// Token: 0x04000EAB RID: 3755
		DataLate,
		// Token: 0x04000EAC RID: 3756
		DataError,
		// Token: 0x04000EAD RID: 3757
		CrcError,
		// Token: 0x04000EAE RID: 3758
		SectionTooBig,
		// Token: 0x04000EAF RID: 3759
		PortConnectionRefused,
		// Token: 0x04000EB0 RID: 3760
		InvalidPortHandle,
		// Token: 0x04000EB1 RID: 3761
		SharingViolation,
		// Token: 0x04000EB2 RID: 3762
		QuotaExceeded,
		// Token: 0x04000EB3 RID: 3763
		InvalidPageProtection,
		// Token: 0x04000EB4 RID: 3764
		MutantNotOwned,
		// Token: 0x04000EB5 RID: 3765
		SemaphoreLimitExceeded,
		// Token: 0x04000EB6 RID: 3766
		PortAlreadySet,
		// Token: 0x04000EB7 RID: 3767
		SectionNotImage,
		// Token: 0x04000EB8 RID: 3768
		SuspendCountExceeded,
		// Token: 0x04000EB9 RID: 3769
		ThreadIsTerminating,
		// Token: 0x04000EBA RID: 3770
		BadWorkingSetLimit,
		// Token: 0x04000EBB RID: 3771
		IncompatibleFileMap,
		// Token: 0x04000EBC RID: 3772
		SectionProtection,
		// Token: 0x04000EBD RID: 3773
		EasNotSupported,
		// Token: 0x04000EBE RID: 3774
		EaTooLarge,
		// Token: 0x04000EBF RID: 3775
		NonExistentEaEntry,
		// Token: 0x04000EC0 RID: 3776
		NoEasOnFile,
		// Token: 0x04000EC1 RID: 3777
		EaCorruptError,
		// Token: 0x04000EC2 RID: 3778
		FileLockConflict,
		// Token: 0x04000EC3 RID: 3779
		LockNotGranted,
		// Token: 0x04000EC4 RID: 3780
		DeletePending,
		// Token: 0x04000EC5 RID: 3781
		CtlFileNotSupported,
		// Token: 0x04000EC6 RID: 3782
		UnknownRevision,
		// Token: 0x04000EC7 RID: 3783
		RevisionMismatch,
		// Token: 0x04000EC8 RID: 3784
		InvalidOwner,
		// Token: 0x04000EC9 RID: 3785
		InvalidPrimaryGroup,
		// Token: 0x04000ECA RID: 3786
		NoImpersonationToken,
		// Token: 0x04000ECB RID: 3787
		CantDisableMandatory,
		// Token: 0x04000ECC RID: 3788
		NoLogonServers,
		// Token: 0x04000ECD RID: 3789
		NoSuchLogonSession,
		// Token: 0x04000ECE RID: 3790
		NoSuchPrivilege,
		// Token: 0x04000ECF RID: 3791
		PrivilegeNotHeld,
		// Token: 0x04000ED0 RID: 3792
		InvalidAccountName,
		// Token: 0x04000ED1 RID: 3793
		UserExists,
		// Token: 0x04000ED2 RID: 3794
		NoSuchUser,
		// Token: 0x04000ED3 RID: 3795
		GroupExists,
		// Token: 0x04000ED4 RID: 3796
		NoSuchGroup,
		// Token: 0x04000ED5 RID: 3797
		MemberInGroup,
		// Token: 0x04000ED6 RID: 3798
		MemberNotInGroup,
		// Token: 0x04000ED7 RID: 3799
		LastAdmin,
		// Token: 0x04000ED8 RID: 3800
		WrongPassword,
		// Token: 0x04000ED9 RID: 3801
		IllFormedPassword,
		// Token: 0x04000EDA RID: 3802
		PasswordRestriction,
		// Token: 0x04000EDB RID: 3803
		LogonFailure,
		// Token: 0x04000EDC RID: 3804
		AccountRestriction,
		// Token: 0x04000EDD RID: 3805
		InvalidLogonHours,
		// Token: 0x04000EDE RID: 3806
		InvalidWorkstation,
		// Token: 0x04000EDF RID: 3807
		PasswordExpired,
		// Token: 0x04000EE0 RID: 3808
		AccountDisabled,
		// Token: 0x04000EE1 RID: 3809
		NoneMapped,
		// Token: 0x04000EE2 RID: 3810
		TooManyLuidsRequested,
		// Token: 0x04000EE3 RID: 3811
		LuidsExhausted,
		// Token: 0x04000EE4 RID: 3812
		InvalidSubAuthority,
		// Token: 0x04000EE5 RID: 3813
		InvalidAcl,
		// Token: 0x04000EE6 RID: 3814
		InvalidSid,
		// Token: 0x04000EE7 RID: 3815
		InvalidSecurityDescr,
		// Token: 0x04000EE8 RID: 3816
		ProcedureNotFound,
		// Token: 0x04000EE9 RID: 3817
		InvalidImageFormat,
		// Token: 0x04000EEA RID: 3818
		NoToken,
		// Token: 0x04000EEB RID: 3819
		BadInheritanceAcl,
		// Token: 0x04000EEC RID: 3820
		RangeNotLocked,
		// Token: 0x04000EED RID: 3821
		DiskFull,
		// Token: 0x04000EEE RID: 3822
		ServerDisabled,
		// Token: 0x04000EEF RID: 3823
		ServerNotDisabled,
		// Token: 0x04000EF0 RID: 3824
		TooManyGuidsRequested,
		// Token: 0x04000EF1 RID: 3825
		GuidsExhausted,
		// Token: 0x04000EF2 RID: 3826
		InvalidIdAuthority,
		// Token: 0x04000EF3 RID: 3827
		AgentsExhausted,
		// Token: 0x04000EF4 RID: 3828
		InvalidVolumeLabel,
		// Token: 0x04000EF5 RID: 3829
		SectionNotExtended,
		// Token: 0x04000EF6 RID: 3830
		NotMappedData,
		// Token: 0x04000EF7 RID: 3831
		ResourceDataNotFound,
		// Token: 0x04000EF8 RID: 3832
		ResourceTypeNotFound,
		// Token: 0x04000EF9 RID: 3833
		ResourceNameNotFound,
		// Token: 0x04000EFA RID: 3834
		ArrayBoundsExceeded,
		// Token: 0x04000EFB RID: 3835
		FloatDenormalOperand,
		// Token: 0x04000EFC RID: 3836
		FloatDivideByZero,
		// Token: 0x04000EFD RID: 3837
		FloatInexactResult,
		// Token: 0x04000EFE RID: 3838
		FloatInvalidOperation,
		// Token: 0x04000EFF RID: 3839
		FloatOverflow,
		// Token: 0x04000F00 RID: 3840
		FloatStackCheck,
		// Token: 0x04000F01 RID: 3841
		FloatUnderflow,
		// Token: 0x04000F02 RID: 3842
		IntegerDivideByZero,
		// Token: 0x04000F03 RID: 3843
		IntegerOverflow,
		// Token: 0x04000F04 RID: 3844
		PrivilegedInstruction,
		// Token: 0x04000F05 RID: 3845
		TooManyPagingFiles,
		// Token: 0x04000F06 RID: 3846
		FileInvalid,
		// Token: 0x04000F07 RID: 3847
		InstanceNotAvailable = 3221225643U,
		// Token: 0x04000F08 RID: 3848
		PipeNotAvailable,
		// Token: 0x04000F09 RID: 3849
		InvalidPipeState,
		// Token: 0x04000F0A RID: 3850
		PipeBusy,
		// Token: 0x04000F0B RID: 3851
		IllegalFunction,
		// Token: 0x04000F0C RID: 3852
		PipeDisconnected,
		// Token: 0x04000F0D RID: 3853
		PipeClosing,
		// Token: 0x04000F0E RID: 3854
		PipeConnected,
		// Token: 0x04000F0F RID: 3855
		PipeListening,
		// Token: 0x04000F10 RID: 3856
		InvalidReadMode,
		// Token: 0x04000F11 RID: 3857
		IoTimeout,
		// Token: 0x04000F12 RID: 3858
		FileForcedClosed,
		// Token: 0x04000F13 RID: 3859
		ProfilingNotStarted,
		// Token: 0x04000F14 RID: 3860
		ProfilingNotStopped,
		// Token: 0x04000F15 RID: 3861
		NotSameDevice = 3221225684U,
		// Token: 0x04000F16 RID: 3862
		FileRenamed,
		// Token: 0x04000F17 RID: 3863
		CantWait = 3221225688U,
		// Token: 0x04000F18 RID: 3864
		PipeEmpty,
		// Token: 0x04000F19 RID: 3865
		CantTerminateSelf = 3221225691U,
		// Token: 0x04000F1A RID: 3866
		InternalError = 3221225701U,
		// Token: 0x04000F1B RID: 3867
		InvalidParameter1 = 3221225711U,
		// Token: 0x04000F1C RID: 3868
		InvalidParameter2,
		// Token: 0x04000F1D RID: 3869
		InvalidParameter3,
		// Token: 0x04000F1E RID: 3870
		InvalidParameter4,
		// Token: 0x04000F1F RID: 3871
		InvalidParameter5,
		// Token: 0x04000F20 RID: 3872
		InvalidParameter6,
		// Token: 0x04000F21 RID: 3873
		InvalidParameter7,
		// Token: 0x04000F22 RID: 3874
		InvalidParameter8,
		// Token: 0x04000F23 RID: 3875
		InvalidParameter9,
		// Token: 0x04000F24 RID: 3876
		InvalidParameter10,
		// Token: 0x04000F25 RID: 3877
		InvalidParameter11,
		// Token: 0x04000F26 RID: 3878
		InvalidParameter12,
		// Token: 0x04000F27 RID: 3879
		MappedFileSizeZero = 3221225758U,
		// Token: 0x04000F28 RID: 3880
		TooManyOpenedFiles,
		// Token: 0x04000F29 RID: 3881
		Canceled,
		// Token: 0x04000F2A RID: 3882
		CannotDelete,
		// Token: 0x04000F2B RID: 3883
		InvalidComputerName,
		// Token: 0x04000F2C RID: 3884
		FileDeleted,
		// Token: 0x04000F2D RID: 3885
		SpecialAccount,
		// Token: 0x04000F2E RID: 3886
		SpecialGroup,
		// Token: 0x04000F2F RID: 3887
		SpecialUser,
		// Token: 0x04000F30 RID: 3888
		MembersPrimaryGroup,
		// Token: 0x04000F31 RID: 3889
		FileClosed,
		// Token: 0x04000F32 RID: 3890
		TooManyThreads,
		// Token: 0x04000F33 RID: 3891
		ThreadNotInProcess,
		// Token: 0x04000F34 RID: 3892
		TokenAlreadyInUse,
		// Token: 0x04000F35 RID: 3893
		PagefileQuotaExceeded,
		// Token: 0x04000F36 RID: 3894
		CommitmentLimit,
		// Token: 0x04000F37 RID: 3895
		InvalidImageLeFormat,
		// Token: 0x04000F38 RID: 3896
		InvalidImageNotMz,
		// Token: 0x04000F39 RID: 3897
		InvalidImageProtect,
		// Token: 0x04000F3A RID: 3898
		InvalidImageWin16,
		// Token: 0x04000F3B RID: 3899
		LogonServer,
		// Token: 0x04000F3C RID: 3900
		DifferenceAtDc,
		// Token: 0x04000F3D RID: 3901
		SynchronizationRequired,
		// Token: 0x04000F3E RID: 3902
		DllNotFound,
		// Token: 0x04000F3F RID: 3903
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x04000F40 RID: 3904
		OrdinalNotFound,
		// Token: 0x04000F41 RID: 3905
		EntryPointNotFound,
		// Token: 0x04000F42 RID: 3906
		ControlCExit,
		// Token: 0x04000F43 RID: 3907
		PortNotSet = 3221226323U,
		// Token: 0x04000F44 RID: 3908
		DebuggerInactive,
		// Token: 0x04000F45 RID: 3909
		CallbackBypass = 3221226755U,
		// Token: 0x04000F46 RID: 3910
		PortClosed = 3221227264U,
		// Token: 0x04000F47 RID: 3911
		MessageLost,
		// Token: 0x04000F48 RID: 3912
		InvalidMessage,
		// Token: 0x04000F49 RID: 3913
		RequestCanceled,
		// Token: 0x04000F4A RID: 3914
		RecursiveDispatch,
		// Token: 0x04000F4B RID: 3915
		LpcReceiveBufferExpected,
		// Token: 0x04000F4C RID: 3916
		LpcInvalidConnectionUsage,
		// Token: 0x04000F4D RID: 3917
		LpcRequestsNotAllowed,
		// Token: 0x04000F4E RID: 3918
		ResourceInUse,
		// Token: 0x04000F4F RID: 3919
		ProcessIsProtected = 3221227282U,
		// Token: 0x04000F50 RID: 3920
		VolumeDirty = 3221227526U,
		// Token: 0x04000F51 RID: 3921
		FileCheckedOut = 3221227777U,
		// Token: 0x04000F52 RID: 3922
		CheckOutRequired,
		// Token: 0x04000F53 RID: 3923
		BadFileType,
		// Token: 0x04000F54 RID: 3924
		FileTooLarge,
		// Token: 0x04000F55 RID: 3925
		FormsAuthRequired,
		// Token: 0x04000F56 RID: 3926
		VirusInfected,
		// Token: 0x04000F57 RID: 3927
		VirusDeleted,
		// Token: 0x04000F58 RID: 3928
		TransactionalConflict = 3222863873U,
		// Token: 0x04000F59 RID: 3929
		InvalidTransaction,
		// Token: 0x04000F5A RID: 3930
		TransactionNotActive,
		// Token: 0x04000F5B RID: 3931
		TmInitializationFailed,
		// Token: 0x04000F5C RID: 3932
		RmNotActive,
		// Token: 0x04000F5D RID: 3933
		RmMetadataCorrupt,
		// Token: 0x04000F5E RID: 3934
		TransactionNotJoined,
		// Token: 0x04000F5F RID: 3935
		DirectoryNotRm,
		// Token: 0x04000F60 RID: 3936
		CouldNotResizeLog,
		// Token: 0x04000F61 RID: 3937
		TransactionsUnsupportedRemote,
		// Token: 0x04000F62 RID: 3938
		LogResizeInvalidSize,
		// Token: 0x04000F63 RID: 3939
		RemoteFileVersionMismatch,
		// Token: 0x04000F64 RID: 3940
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x04000F65 RID: 3941
		TransactionPropagationFailed,
		// Token: 0x04000F66 RID: 3942
		CrmProtocolNotFound,
		// Token: 0x04000F67 RID: 3943
		TransactionSuperiorExists,
		// Token: 0x04000F68 RID: 3944
		TransactionRequestNotValid,
		// Token: 0x04000F69 RID: 3945
		TransactionNotRequested,
		// Token: 0x04000F6A RID: 3946
		TransactionAlreadyAborted,
		// Token: 0x04000F6B RID: 3947
		TransactionAlreadyCommitted,
		// Token: 0x04000F6C RID: 3948
		TransactionInvalidMarshallBuffer,
		// Token: 0x04000F6D RID: 3949
		CurrentTransactionNotValid,
		// Token: 0x04000F6E RID: 3950
		LogGrowthFailed,
		// Token: 0x04000F6F RID: 3951
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x04000F70 RID: 3952
		StreamMiniversionNotFound,
		// Token: 0x04000F71 RID: 3953
		StreamMiniversionNotValid,
		// Token: 0x04000F72 RID: 3954
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x04000F73 RID: 3955
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x04000F74 RID: 3956
		CantCreateMoreStreamMiniversions,
		// Token: 0x04000F75 RID: 3957
		HandleNoLongerValid = 3222863912U,
		// Token: 0x04000F76 RID: 3958
		NoTxfMetadata,
		// Token: 0x04000F77 RID: 3959
		LogCorruptionDetected = 3222863920U,
		// Token: 0x04000F78 RID: 3960
		CantRecoverWithHandleOpen,
		// Token: 0x04000F79 RID: 3961
		RmDisconnected,
		// Token: 0x04000F7A RID: 3962
		EnlistmentNotSuperior,
		// Token: 0x04000F7B RID: 3963
		RecoveryNotNeeded,
		// Token: 0x04000F7C RID: 3964
		RmAlreadyStarted,
		// Token: 0x04000F7D RID: 3965
		FileIdentityNotPersistent,
		// Token: 0x04000F7E RID: 3966
		CantBreakTransactionalDependency,
		// Token: 0x04000F7F RID: 3967
		CantCrossRmBoundary,
		// Token: 0x04000F80 RID: 3968
		TxfDirNotEmpty,
		// Token: 0x04000F81 RID: 3969
		IndoubtTransactionsExist,
		// Token: 0x04000F82 RID: 3970
		TmVolatile,
		// Token: 0x04000F83 RID: 3971
		RollbackTimerExpired,
		// Token: 0x04000F84 RID: 3972
		TxfAttributeCorrupt,
		// Token: 0x04000F85 RID: 3973
		EfsNotAllowedInTransaction,
		// Token: 0x04000F86 RID: 3974
		TransactionalOpenNotAllowed,
		// Token: 0x04000F87 RID: 3975
		TransactedMappingUnsupportedRemote,
		// Token: 0x04000F88 RID: 3976
		TxfMetadataAlreadyPresent,
		// Token: 0x04000F89 RID: 3977
		TransactionScopeCallbacksNotSet,
		// Token: 0x04000F8A RID: 3978
		TransactionRequiredPromotion,
		// Token: 0x04000F8B RID: 3979
		CannotExecuteFileInTransaction,
		// Token: 0x04000F8C RID: 3980
		TransactionsNotFrozen,
		// Token: 0x04000F8D RID: 3981
		MaximumNtStatus = 4294967295U
	}
}
