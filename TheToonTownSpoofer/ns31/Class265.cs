using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using ns16;
using ns17;
using ns18;
using ns19;
using ns20;
using ns21;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns30;
using TSN.Native.Enums;

namespace ns31
{
	// Token: 0x020002D8 RID: 728
	internal static class Class265
	{
		// Token: 0x06001CD6 RID: 7382
		[DllImport("kernel32.dll")]
		public static extern void GetSystemInfo([In] [Out] ref Struct53 lpSystemInfo);

		// Token: 0x06001CD7 RID: 7383
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool GetVersionEx([In] [Out] ref Struct15 osVersionInfo);

		// Token: 0x06001CD8 RID: 7384
		[DllImport("user32.dll")]
		public static extern bool EnableMenuItem(IntPtr hMenu, Enum71 uIDEnableItem, Enum134 uEnable);

		// Token: 0x06001CD9 RID: 7385
		[DllImport("user32.dll")]
		public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

		// Token: 0x06001CDA RID: 7386
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		public static extern bool ShutdownBlockReasonCreate(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] string pwszReason);

		// Token: 0x06001CDB RID: 7387
		[DllImport("user32.dll")]
		public static extern bool ShutdownBlockReasonDestroy(IntPtr hWnd);

		// Token: 0x06001CDC RID: 7388
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetProcessAffinityMask(HandleRef handle, IntPtr mask);

		// Token: 0x06001CDD RID: 7389
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern bool GetWindowPlacement(HandleRef hWnd, ref Struct28 placement);

		// Token: 0x06001CDE RID: 7390
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern bool SetWindowPlacement(HandleRef hWnd, ref Struct28 placement);

		// Token: 0x06001CDF RID: 7391
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern SafeFileHandle CreateFile(string pipeName, Enum64 dwDesiredAccess, Enum89 dwShareMode, IntPtr lpSecurityAttributes, Enum105 dwCreationDisposition, Enum122 dwFlagsAndAttributes, IntPtr hTemplate);

		// Token: 0x06001CE0 RID: 7392
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool MessageBeep(Enum95 type);

		// Token: 0x06001CE1 RID: 7393
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr SetFocus(HandleRef hWnd);

		// Token: 0x06001CE2 RID: 7394
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetFocus();

		// Token: 0x06001CE3 RID: 7395
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06001CE4 RID: 7396
		[DllImport("ntdll.dll")]
		public static extern NtStatus RtlHashUnicodeString([In] ref Struct31 String, [In] bool CaseInSensitive, [In] Enum73 HashAlgorithm, out int HashValue);

		// Token: 0x06001CE5 RID: 7397
		[DllImport("ntdll.dll")]
		public static extern int RtlCompareUnicodeString([In] ref Struct31 String1, [In] ref Struct31 String2, [In] bool CaseInSensitive);

		// Token: 0x06001CE6 RID: 7398
		[DllImport("ntdll.dll")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool RtlCreateUnicodeString(out Struct31 DestinationString, [MarshalAs(UnmanagedType.LPWStr)] [In] string SourceString);

		// Token: 0x06001CE7 RID: 7399
		[DllImport("ntdll.dll")]
		public static extern NtStatus RtlDuplicateUnicodeString([In] Enum80 Flags, [In] ref Struct31 StringIn, out Struct31 StringOut);

		// Token: 0x06001CE8 RID: 7400
		[DllImport("ntdll.dll")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool RtlEqualUnicodeString([In] ref Struct31 String1, [In] ref Struct31 String2, [In] bool CaseInSensitive);

		// Token: 0x06001CE9 RID: 7401
		[DllImport("ntdll.dll")]
		public static extern void RtlFreeUnicodeString([In] ref Struct31 UnicodeString);

		// Token: 0x06001CEA RID: 7402
		[DllImport("ntdll.dll")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool RtlPrefixUnicodeString([In] ref Struct31 String1, [In] ref Struct31 String2, [In] bool CaseInSensitive);

		// Token: 0x06001CEB RID: 7403
		[DllImport("ntdll.dll")]
		public static extern NtStatus NtQuerySystemInformation([In] Enum127 SystemInformationClass, [In] IntPtr SystemInformation, [In] int SystemInformationLength, out int ReturnLength);

		// Token: 0x06001CEC RID: 7404
		[DllImport("ntdll.dll")]
		public static extern NtStatus NtQueryObject([In] IntPtr Handle, [In] Enum118 ObjectInformationClass, [In] IntPtr ObjectInformation, [In] int ObjectInformationLength, out int ReturnLength);

		// Token: 0x06001CED RID: 7405
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern Class494 OpenProcess([In] Enum72 dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] [In] bool bInheritHandle, [In] uint dwProcessId);

		// Token: 0x06001CEE RID: 7406
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DuplicateHandle([In] IntPtr hSourceProcessHandle, [In] IntPtr hSourceHandle, [In] IntPtr hTargetProcessHandle, out Class522 lpTargetHandle, [In] int dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] [In] bool bInheritHandle, [In] Enum130 dwOptions);

		// Token: 0x06001CEF RID: 7407
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int QueryDosDevice([In] string lpDeviceName, [Out] StringBuilder lpTargetPath, [In] int ucchMax);

		// Token: 0x06001CF0 RID: 7408
		[DllImport("ntdll.dll")]
		public static extern void RtlFillMemory([In] IntPtr Destination, [In] IntPtr Length, [In] byte Fill);

		// Token: 0x06001CF1 RID: 7409
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseHandle([In] IntPtr hObject);

		// Token: 0x06001CF2 RID: 7410
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x06001CF3 RID: 7411
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int GetProcessId([In] IntPtr Process);

		// Token: 0x06001CF4 RID: 7412
		[DllImport("ntdll.dll")]
		public static extern Win32Error RtlNtStatusToDosError([In] NtStatus Status);

		// Token: 0x06001CF5 RID: 7413
		[DllImport("ntdll.dll")]
		public static extern void RtlMoveMemory([In] IntPtr Destination, [In] IntPtr Source, [In] IntPtr Length);

		// Token: 0x06001CF6 RID: 7414
		[DllImport("ntdll.dll")]
		public static extern NtStatus RtlFindMessage([In] IntPtr DllHandle, [In] int MessageTableId, [In] int MessageLanguageId, [In] int MessageId, out IntPtr MessageEntry);

		// Token: 0x06001CF7 RID: 7415
		[DllImport("ntdll.dll")]
		public static extern void RtlZeroMemory([In] IntPtr Destination, [In] IntPtr Length);

		// Token: 0x06001CF8 RID: 7416
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int FormatMessage([In] int Flags, [In] [Optional] IntPtr Source, [In] int MessageId, [In] int LanguageId, [In] IntPtr Buffer, [In] int Size, [In] [Optional] IntPtr Arguments);

		// Token: 0x06001CF9 RID: 7417
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr FindResource([In] [Optional] IntPtr hModule, [MarshalAs(UnmanagedType.LPWStr)] [In] string lpName, [In] string lpType);

		// Token: 0x06001CFA RID: 7418
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr LoadResource([In] [Optional] IntPtr hModule, [In] IntPtr hResInfo);

		// Token: 0x06001CFB RID: 7419
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr LockResource([In] IntPtr hResData);

		// Token: 0x06001CFC RID: 7420
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint SizeofResource([In] [Optional] IntPtr hModule, [In] IntPtr hResInfo);

		// Token: 0x06001CFD RID: 7421
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr CreateIconFromResource([In] IntPtr presbits, [In] uint dwResSize, [In] bool fIcon, [In] uint dwVer);

		// Token: 0x06001CFE RID: 7422
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pprSrc, int crKey, ref Struct29 pblend, int dwFlags);

		// Token: 0x06001CFF RID: 7423
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr GetDC(IntPtr hwnd);

		// Token: 0x06001D00 RID: 7424
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, Enum96 fsModifiers, Keys vk);

		// Token: 0x06001D01 RID: 7425
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x06001D02 RID: 7426
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern SafeWaitHandle OpenMutex(MutexRights desiredAccess, bool inheritHandle, string name);

		// Token: 0x06001D03 RID: 7427
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool DrawIconEx(IntPtr hDC, int xLeft, int yTop, IntPtr hIcon, int cxWidth, int cyWidth, int istepIfAniCur, IntPtr hbrFlickerFreeDraw, Enum56 diFlags);

		// Token: 0x06001D04 RID: 7428
		[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr LoadImage(IntPtr hInst, string lpsz, Enum46 uType, int cx, int cy, Enum103 uFlags);

		// Token: 0x06001D05 RID: 7429
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadImage", SetLastError = true)]
		public static extern IntPtr LoadImage_1(IntPtr hInst, [MarshalAs(UnmanagedType.SysInt)] int lpsz, Enum46 uType, int cx, int cy, Enum103 uFlags);

		// Token: 0x06001D06 RID: 7430
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr CopyImage(IntPtr hImage, Enum46 uType, int cxDesired, int cyDesired, Enum38 uFlags);

		// Token: 0x06001D07 RID: 7431
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool DestroyCursor(IntPtr hCursor);

		// Token: 0x06001D08 RID: 7432
		[DllImport("user32.dll", SetLastError = true)]
		public static extern uint SendInput(uint nInputs, Struct44[] pInputs, int cbSize);

		// Token: 0x06001D09 RID: 7433
		[DllImport("user32.dll")]
		public static extern void mouse_event(Enum129 dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo);

		// Token: 0x06001D0A RID: 7434
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetModuleHandle([In] [Optional] string moduleName);

		// Token: 0x06001D0B RID: 7435
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetModuleFileName([In] IntPtr hModule, [Out] StringBuilder lpFilename, [MarshalAs(UnmanagedType.U4)] [In] int nSize);

		// Token: 0x06001D0C RID: 7436
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int GetCurrentProcessId();

		// Token: 0x06001D0D RID: 7437
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint GetCurrentThreadId();

		// Token: 0x06001D0E RID: 7438
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool GetWindowRect(IntPtr hwnd, out Struct24 lpRect);

		// Token: 0x06001D0F RID: 7439
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int MapWindowPoints(IntPtr hwndFrom, IntPtr hwndTo, ref Struct24 lpPoints, uint cPoints);

		// Token: 0x06001D10 RID: 7440
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, Enum31 flags);

		// Token: 0x06001D11 RID: 7441
		[DllImport("user32.dll", EntryPoint = "SetWindowPos", SetLastError = true)]
		public static extern bool SetWindowPos_1(HandleRef hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, Enum31 flags);

		// Token: 0x06001D12 RID: 7442
		[DllImport("user32.dll", EntryPoint = "SetWindowPos", SetLastError = true)]
		public static extern bool SetWindowPos_2(HandleRef hWnd, HandleRef hWndInsertAfter, int X, int Y, int cx, int cy, Enum31 flags);

		// Token: 0x06001D13 RID: 7443
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern bool AnimateWindow(HandleRef windowHandle, int time, Enum120 flags);

		// Token: 0x06001D14 RID: 7444
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr GetWindowDC(IntPtr hWnd);

		// Token: 0x06001D15 RID: 7445
		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

		// Token: 0x06001D16 RID: 7446
		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

		// Token: 0x06001D17 RID: 7447
		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

		// Token: 0x06001D18 RID: 7448
		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, Enum37 dwRop);

		// Token: 0x06001D19 RID: 7449
		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern bool DeleteDC(IntPtr hDC);

		// Token: 0x06001D1A RID: 7450
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

		// Token: 0x06001D1B RID: 7451
		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern bool DeleteObject(IntPtr hObject);

		// Token: 0x06001D1C RID: 7452
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr GetDesktopWindow();

		// Token: 0x06001D1D RID: 7453
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetForegroundWindow(HandleRef hwnd);

		// Token: 0x06001D1E RID: 7454
		[DllImport("user32.dll", EntryPoint = "SetForegroundWindow", SetLastError = true)]
		public static extern bool SetForegroundWindow_1(IntPtr hwnd);

		// Token: 0x06001D1F RID: 7455
		[DllImport("user32.dll")]
		public static extern bool ShowWindowAsync(IntPtr hWnd, Enum117 cmdShow);

		// Token: 0x06001D20 RID: 7456
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(HandleRef hWnd, Enum117 cmdShow);

		// Token: 0x06001D21 RID: 7457
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int SetWindowLong(IntPtr hWnd, Enum55 nIndex, int dwNewLong);

		// Token: 0x06001D22 RID: 7458
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr SetWindowLongPtr(IntPtr hWnd, Enum55 nIndex, IntPtr dwNewLong);

		// Token: 0x06001D23 RID: 7459
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowLong(IntPtr hWnd, Enum55 nIndex);

		// Token: 0x06001D24 RID: 7460
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr GetWindowLongPtr(IntPtr hWnd, Enum55 nIndex);

		// Token: 0x06001D25 RID: 7461
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetSystemMetrics(Enum67 smIndex);

		// Token: 0x06001D26 RID: 7462
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool GetClientRect(IntPtr hWnd, out Struct24 lpRect);

		// Token: 0x06001D27 RID: 7463
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetClassLong(HandleRef hWnd, Enum104 nIndex);

		// Token: 0x06001D28 RID: 7464
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr GetClassLongPtr(HandleRef hWnd, Enum104 nIndex);

		// Token: 0x06001D29 RID: 7465
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetLayeredWindowAttributes([In] HandleRef hWnd, [In] uint crKey, [In] byte bAlpha, [In] Enum21 dwFlags);

		// Token: 0x06001D2A RID: 7466
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		// Token: 0x06001D2B RID: 7467
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		// Token: 0x06001D2C RID: 7468
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

		// Token: 0x06001D2D RID: 7469
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SendNotifyMessage(IntPtr hWnd, Enum16 msg, Enum71 wParam, int lParam);

		// Token: 0x06001D2E RID: 7470
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetCursorPos(int X, int Y);

		// Token: 0x06001D2F RID: 7471
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool PostMessage(IntPtr hWnd, Enum16 Msg, int wParam, int lParam);

		// Token: 0x06001D30 RID: 7472
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SendMessage(IntPtr hWnd, Enum16 Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06001D31 RID: 7473
		[DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
		public static extern IntPtr SendMessage_1(IntPtr hWnd, Enum16 Msg, IntPtr wParam, ref Struct20 lParam);

		// Token: 0x06001D32 RID: 7474
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SendMessageTimeout(IntPtr hWnd, Enum16 Msg, IntPtr wParam, ref Struct20 lParam, Enum88 fuFlags, uint uTimeout, out IntPtr lpdwResult);

		// Token: 0x06001D33 RID: 7475
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr LocalFree(IntPtr p);

		// Token: 0x06001D34 RID: 7476
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr LocalAlloc(Enum63 flag, IntPtr size);

		// Token: 0x06001D35 RID: 7477
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool ScreenToClient(IntPtr handle, ref Point point);

		// Token: 0x06001D36 RID: 7478
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

		// Token: 0x06001D37 RID: 7479
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr GetWindow(IntPtr hWnd, Enum119 uCmd);

		// Token: 0x06001D38 RID: 7480
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SystemParametersInfo(Enum94 action, uint param, ref uint vparam, uint init);

		// Token: 0x06001D39 RID: 7481
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumWindows(Class265.Delegate174 lpEnumFunc, IntPtr lParam);

		// Token: 0x06001D3A RID: 7482
		[DllImport("user32.dll")]
		public static extern bool IsWindowVisible(IntPtr hWnd);

		// Token: 0x06001D3B RID: 7483
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateWindow(IntPtr hWnd);

		// Token: 0x06001D3C RID: 7484
		[DllImport("user32.dll")]
		public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, Enum45 flags);

		// Token: 0x06001D3D RID: 7485
		[DllImport("user32.dll")]
		public static extern IntPtr GetMessageExtraInfo();

		// Token: 0x06001D3E RID: 7486
		[DllImport("user32.dll")]
		public static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

		// Token: 0x06001D3F RID: 7487
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public static extern IntPtr SendMessage_2(IntPtr hwnd, Enum16 wMsg, bool wParam, int lParam);

		// Token: 0x06001D40 RID: 7488
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public static extern IntPtr SendMessage_3(IntPtr hwnd, Enum16 wMsg, int wParam, int lParam);

		// Token: 0x06001D41 RID: 7489
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public static extern IntPtr SendMessage_4(HandleRef hwnd, Enum16 wMsg, bool wParam, int lParam);

		// Token: 0x06001D42 RID: 7490
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public static extern IntPtr SendMessage_5(HandleRef hwnd, Enum16 wMsg, int wParam, int lParam);

		// Token: 0x06001D43 RID: 7491
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr GetParent(IntPtr hWnd);

		// Token: 0x06001D44 RID: 7492
		[DllImport("user32.dll")]
		public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

		// Token: 0x06001D45 RID: 7493
		[DllImport("user32.dll")]
		public static extern bool IsWindow(IntPtr hWndParent);

		// Token: 0x06001D46 RID: 7494 RVA: 0x0005DEDC File Offset: 0x0005C0DC
		public static string smethod_0(IntPtr dllHandle, int messageTableId, int messageLanguageId, int messageId)
		{
			IntPtr memory;
			NtStatus status = Class265.RtlFindMessage(dllHandle, messageTableId, messageLanguageId, messageId, out memory);
			if (status.smethod_1())
			{
				return null;
			}
			string result;
			using (Class128 @class = new Class128(memory))
			{
				if ((ushort)(@class.method_21<Struct19>().enum114_0 & Enum114.flag_1) == 1)
				{
					result = @class.method_24(Struct19.int_0);
				}
				else
				{
					result = @class.method_7(Struct19.int_0);
				}
			}
			return result;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0005DF54 File Offset: 0x0005C154
		public static bool smethod_1(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException(Class265.string_5);
			}
			if (name.Length > 260)
			{
				throw new ArgumentException(string.Format(Class217.cultureInfo_0, Class265.string_4, new object[]
				{
					name
				}));
			}
			bool result;
			using (SafeWaitHandle safeWaitHandle = Class265.OpenMutex(MutexRights.Synchronize, false, name))
			{
				if (safeWaitHandle.IsInvalid)
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0005DFE8 File Offset: 0x0005C1E8
		public static long smethod_2(IntPtr hWnd, Enum55 nIndex)
		{
			long num;
			if (Environment.Is64BitProcess)
			{
				num = Class265.GetWindowLongPtr(hWnd, nIndex).ToInt64();
			}
			else
			{
				num = (long)((ulong)Class265.GetWindowLong(hWnd, nIndex));
			}
			if (num == 0L)
			{
				throw new Win32Exception();
			}
			return num;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0005E02C File Offset: 0x0005C22C
		public static IntPtr smethod_3(HandleRef hWnd, Enum104 nIndex)
		{
			if (Environment.Is64BitProcess)
			{
				IntPtr classLongPtr = Class265.GetClassLongPtr(hWnd, nIndex);
				if (classLongPtr == IntPtr.Zero)
				{
					throw new Win32Exception();
				}
				return classLongPtr;
			}
			else
			{
				uint classLong = Class265.GetClassLong(hWnd, nIndex);
				if (classLong == 0U)
				{
					throw new Win32Exception();
				}
				return new IntPtr((long)((ulong)classLong));
			}
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0000AF9B File Offset: 0x0000919B
		public static void smethod_4(IntPtr hWnd, Enum55 nIndex, int dwNewLong)
		{
			if (Environment.Is64BitProcess)
			{
				if (Class265.SetWindowLongPtr(hWnd, nIndex, new IntPtr(dwNewLong)) == IntPtr.Zero)
				{
					throw new Win32Exception();
				}
			}
			else if (Class265.SetWindowLong(hWnd, nIndex, dwNewLong) == 0)
			{
				throw new Win32Exception();
			}
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0005E078 File Offset: 0x0005C278
		public static string smethod_5()
		{
			StringBuilder stringBuilder = null;
			string result;
			try
			{
				stringBuilder = new StringBuilder(1024);
				IntPtr moduleHandle = Class265.GetModuleHandle(null);
				if (moduleHandle == IntPtr.Zero)
				{
					throw new Win32Exception();
				}
				if (Class265.GetModuleFileName(moduleHandle, stringBuilder, stringBuilder.Capacity) == 0)
				{
					throw new Win32Exception();
				}
				result = stringBuilder.ToString();
			}
			finally
			{
				stringBuilder.Clear();
				stringBuilder = null;
			}
			return result;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0005E0E8 File Offset: 0x0005C2E8
		public static uint smethod_6()
		{
			uint num = 0U;
			if (!Class265.SystemParametersInfo(Enum94.const_0, 0U, ref num, 0U))
			{
				new Win32Exception().smethod_0();
				num = 31U;
			}
			else if (num > 31U)
			{
				num = 31U;
			}
			return num;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0005E11C File Offset: 0x0005C31C
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static Process smethod_7(IntPtr hWnd)
		{
			int processId;
			if (Class265.GetWindowThreadProcessId(hWnd, out processId) == 0)
			{
				throw new Win32Exception();
			}
			return Process.GetProcessById(processId);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0000AFD3 File Offset: 0x000091D3
		public static short smethod_8(byte a, byte b)
		{
			return (short)((int)(a & byte.MaxValue) | (int)(b & byte.MaxValue) << 8);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x0000AFE9 File Offset: 0x000091E9
		public static byte smethod_9(short a)
		{
			return (byte)(a & 255);
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x0000AFF3 File Offset: 0x000091F3
		public static byte smethod_10(short a)
		{
			return (byte)(a >> 8);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x0000AFF9 File Offset: 0x000091F9
		public static int smethod_11(short a, short b)
		{
			return ((int)a & 65535) | ((int)b & 65535) << 16;
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x0000B00D File Offset: 0x0000920D
		public static short smethod_12(int a)
		{
			return (short)(a >> 16);
		}

		// Token: 0x04000A92 RID: 2706
		public const string string_0 = "kernel32.dll";

		// Token: 0x04000A93 RID: 2707
		public const string string_1 = "user32.dll";

		// Token: 0x04000A94 RID: 2708
		public const string string_2 = "gdi32.dll";

		// Token: 0x04000A95 RID: 2709
		public const string string_3 = "ntdll.dll";

		// Token: 0x04000A96 RID: 2710
		public static readonly uint uint_0 = 2147942583U;

		// Token: 0x04000A97 RID: 2711
		private static readonly string string_4 = "The mutex name '{0}' is too long";

		// Token: 0x04000A98 RID: 2712
		private static readonly string string_5 = "The mutex name is empty.";

		// Token: 0x04000A99 RID: 2713
		public static readonly IntPtr intptr_0 = new IntPtr(-1);

		// Token: 0x04000A9A RID: 2714
		public static readonly IntPtr intptr_1 = new IntPtr(1);

		// Token: 0x04000A9B RID: 2715
		public static readonly IntPtr intptr_2 = new IntPtr(-2);

		// Token: 0x04000A9C RID: 2716
		public static readonly IntPtr intptr_3 = new IntPtr(0);

		// Token: 0x04000A9D RID: 2717
		public static readonly IntPtr intptr_4 = new IntPtr(-1);

		// Token: 0x020002D9 RID: 729
		// (Invoke) Token: 0x06001D55 RID: 7509
		public delegate bool Delegate174(IntPtr hWnd, IntPtr lParam);
	}
}
