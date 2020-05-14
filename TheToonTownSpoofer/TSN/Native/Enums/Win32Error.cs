using System;

namespace TSN.Native.Enums
{
	// Token: 0x020003D7 RID: 983
	public enum Win32Error : uint
	{
		// Token: 0x0400123B RID: 4667
		Success,
		// Token: 0x0400123C RID: 4668
		InvalidFunction,
		// Token: 0x0400123D RID: 4669
		FileNotFound,
		// Token: 0x0400123E RID: 4670
		PathNotFound,
		// Token: 0x0400123F RID: 4671
		TooManyOpenFiles,
		// Token: 0x04001240 RID: 4672
		AccessDenied,
		// Token: 0x04001241 RID: 4673
		InvalidHandle,
		// Token: 0x04001242 RID: 4674
		ArenaTrashed,
		// Token: 0x04001243 RID: 4675
		NotEnoughMemory,
		// Token: 0x04001244 RID: 4676
		InvalidBlock,
		// Token: 0x04001245 RID: 4677
		BadEnvironment,
		// Token: 0x04001246 RID: 4678
		BadFormat,
		// Token: 0x04001247 RID: 4679
		InvalidAccess,
		// Token: 0x04001248 RID: 4680
		InvalidData,
		// Token: 0x04001249 RID: 4681
		OutOfMemory,
		// Token: 0x0400124A RID: 4682
		InvalidDrive,
		// Token: 0x0400124B RID: 4683
		CurrentDirectory,
		// Token: 0x0400124C RID: 4684
		NotSameDevice,
		// Token: 0x0400124D RID: 4685
		NoMoreFiles,
		// Token: 0x0400124E RID: 4686
		WriteProtect,
		// Token: 0x0400124F RID: 4687
		BadUnit,
		// Token: 0x04001250 RID: 4688
		NotReady,
		// Token: 0x04001251 RID: 4689
		BadCommand,
		// Token: 0x04001252 RID: 4690
		Crc,
		// Token: 0x04001253 RID: 4691
		BadLength,
		// Token: 0x04001254 RID: 4692
		Seek,
		// Token: 0x04001255 RID: 4693
		NotDosDisk,
		// Token: 0x04001256 RID: 4694
		SectorNotFound,
		// Token: 0x04001257 RID: 4695
		OutOfPaper,
		// Token: 0x04001258 RID: 4696
		WriteFault,
		// Token: 0x04001259 RID: 4697
		ReadFault,
		// Token: 0x0400125A RID: 4698
		GenFailure,
		// Token: 0x0400125B RID: 4699
		SharingViolation,
		// Token: 0x0400125C RID: 4700
		LockViolation,
		// Token: 0x0400125D RID: 4701
		WrongDisk,
		// Token: 0x0400125E RID: 4702
		SharingBufferExceeded = 36U,
		// Token: 0x0400125F RID: 4703
		HandleEof = 38U,
		// Token: 0x04001260 RID: 4704
		HandleDiskFull,
		// Token: 0x04001261 RID: 4705
		NotSupported = 50U,
		// Token: 0x04001262 RID: 4706
		RemNotList,
		// Token: 0x04001263 RID: 4707
		DupName,
		// Token: 0x04001264 RID: 4708
		BadNetPath,
		// Token: 0x04001265 RID: 4709
		NetworkBusy,
		// Token: 0x04001266 RID: 4710
		DevNotExist,
		// Token: 0x04001267 RID: 4711
		TooManyCmds,
		// Token: 0x04001268 RID: 4712
		FileExists = 80U,
		// Token: 0x04001269 RID: 4713
		CannotMake = 82U,
		// Token: 0x0400126A RID: 4714
		AlreadyAssigned = 85U,
		// Token: 0x0400126B RID: 4715
		InvalidPassword,
		// Token: 0x0400126C RID: 4716
		InvalidParameter,
		// Token: 0x0400126D RID: 4717
		NetWriteFault,
		// Token: 0x0400126E RID: 4718
		NoProcSlots,
		// Token: 0x0400126F RID: 4719
		TooManySemaphores = 100U,
		// Token: 0x04001270 RID: 4720
		ExclSemAlreadyOwned,
		// Token: 0x04001271 RID: 4721
		SemIsSet,
		// Token: 0x04001272 RID: 4722
		TooManySemRequests,
		// Token: 0x04001273 RID: 4723
		InvalidAtInterruptTime,
		// Token: 0x04001274 RID: 4724
		SemOwnerDied,
		// Token: 0x04001275 RID: 4725
		SemUserLimit,
		// Token: 0x04001276 RID: 4726
		Canceled = 1223U
	}
}
