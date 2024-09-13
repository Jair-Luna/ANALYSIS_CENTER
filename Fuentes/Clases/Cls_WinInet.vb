Option Strict Off
Option Explicit On 
Module Cls_WinInet
    'Internet API declerations
    Public Declare Function InternetOpen Lib "wininet.dll" Alias "InternetOpenA" (ByVal sAgent As String, ByVal lAccessType As Integer, ByVal sProxyName As String, ByVal sProxyBypass As String, ByVal lFlags As Integer) As Integer
    Public Declare Function InternetConnect Lib "wininet.dll" Alias "InternetConnectA" (ByVal hInternetSession As Integer, ByVal sServerName As String, ByVal nServerPort As Short, ByVal sUsername As String, ByVal sPassword As String, ByVal lService As Integer, ByVal lFlags As Integer, ByVal lContext As Integer) As Integer
    Public Declare Function InternetReadFile Lib "wininet.dll" (ByVal hFile As Integer, ByVal sBuffer As String, ByVal lNumBytesToRead As Integer, ByRef lNumberOfBytesRead As Integer) As Short
    Public Declare Function InternetCloseHandle Lib "wininet.dll" (ByVal hInet As Integer) As Short
    Public Declare Function InternetFindNextFile Lib "wininet.dll" Alias "InternetFindNextFileA" (ByVal hFind As Integer, ByRef lpvFindData As WIN32_FIND_DATA) As Integer

    'FTP API declerations
    Public Declare Function FtpOpenFile Lib "wininet.dll" Alias "FtpOpenFileA" (ByVal hFtpSession As Integer, ByVal sFileName As String, ByVal lAccess As Integer, ByVal lFlags As Integer, ByVal lContext As Integer) As Integer
    Public Declare Function FtpFindFirstFile Lib "wininet.dll" Alias "FtpFindFirstFileA" (ByVal hFtpSession As Integer, ByVal lpszSearchFile As String, ByRef lpFindFileData As WIN32_FIND_DATA, ByVal dwFlags As Integer, ByVal dwContent As Integer) As Integer
    Public Declare Function FtpGetFile Lib "wininet.dll" Alias "FtpGetFileA" (ByVal hFtpSession As Integer, ByVal lpszRemoteFile As String, ByVal lpszNewFile As String, ByVal fFailIfExists As Boolean, ByVal dwFlagsAndAttributes As Integer, ByVal dwFlags As Integer, ByVal dwContext As Integer) As Boolean
    Public Declare Function FtpSetCurrentDirectory Lib "wininet.dll" Alias "FtpSetCurrentDirectoryA" (ByVal hFtpSession As Integer, ByVal lpszDirectory As String) As Boolean
    Public Declare Function FtpPutFile Lib "wininet.dll" Alias "FtpPutFileA" (ByVal hFtpSession As Integer, ByVal lpszLocalFile As String, ByVal lpszRemoteFile As String, ByVal dwFlags As Integer, ByVal dwContext As Integer) As Boolean
    Public Declare Function FtpDeleteFile Lib "wininet.dll" Alias "FtpDeleteFileA" (ByVal hFtpSession As Integer, ByVal lpszFileName As String) As Boolean
    'Misc constant declerations
    Public Const ERROR_NO_MORE_FILES As Short = 18
    Public Const INTERNET_SERVICE_FTP As Short = 1
    Public Const INTERNET_DEFAULT_FTP_PORT As Short = 21
    Public Const INTERNET_OPTION_USERNAME As Short = 28
    Public Const INTERNET_OPTION_PASSWORD As Short = 29
    Public Const INTERNET_FLAG_RELOAD As Integer = &H80000000
    Public Const scUserAgent As String = "vb wininet"
    Public Const INTERNET_OPEN_TYPE_DIRECT As Short = 1
    Public Const INTERNET_INVALID_PORT_NUMBER As Short = 0
    Public Const FTP_TRANSFER_TYPE_ASCII As Short = &H1S
    Public Const FTP_TRANSFER_TYPE_BINARY As Short = &H1S
    Public Const INTERNET_FLAG_PASSIVE As Integer = &H8000000
    Public Const MAX_PATH As Short = 260
    Public Const FILE_ATTRIBUTE_DIRECTORY As Short = &H10S

    Public Const FTP_TRANSFER_TYPE_UNKNOWN As Short = &H0S

    Public Structure FILETIME
        Dim dwLowDateTime As Integer
        Dim dwHighDateTime As Integer
    End Structure

    Public Structure WIN32_FIND_DATA
        Dim dwFileAttributes As Integer
        Dim ftCreationTime As FILETIME
        Dim ftLastAccessTime As FILETIME
        Dim ftLastWriteTime As FILETIME
        Dim nFileSizeHigh As Integer
        Dim nFileSizeLow As Integer
        Dim dwReserved0 As Integer
        Dim dwReserved1 As Integer
        <VBFixedString(MAX_PATH), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=MAX_PATH)> Public cFileName As String
        <VBFixedString(14), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=14)> Public cAlternate As String
    End Structure
End Module