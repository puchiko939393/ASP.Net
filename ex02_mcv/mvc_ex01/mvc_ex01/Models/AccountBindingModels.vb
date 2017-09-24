Imports System.ComponentModel.DataAnnotations
Imports Newtonsoft.Json

' 用做 AccountController 動作的模型參數。

Public Class AddExternalLoginBindingModel
    <Required>
    <Display(Name := "外部存取權杖")>
    Public Property ExternalAccessToken As String
End Class

Public Class ChangePasswordBindingModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name := "目前密碼")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage := "{0} 的長度至少必須為 {2} 個字元。", MinimumLength := 6)>
    <DataType(DataType.Password)>
    <Display(Name := "新密碼")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name := "確認新密碼")>
    <Compare("NewPassword", ErrorMessage := "新密碼與確認密碼不相符。")>
    Public Property ConfirmPassword As String
End Class

Public Class RegisterBindingModel
    <Required>
    <Display(Name := "電子郵件")>
    Public Property Email As String

    <Required>
    <StringLength(100, ErrorMessage := "{0} 的長度至少必須為 {2} 個字元。", MinimumLength := 6)>
    <DataType(DataType.Password)>
    <Display(Name := "密碼")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name := "確認密碼")>
    <Compare("Password", ErrorMessage := "密碼和確認密碼不相符。")>
    Public Property ConfirmPassword As String
End Class

Public Class RegisterExternalBindingModel
    <Required>
    <Display(Name := "電子郵件")>
    Public Property Email As String
End Class

Public Class RemoveLoginBindingModel
    <Required>
    <Display(Name := "登入提供者")>
    Public Property LoginProvider As String

    <Required>
    <Display(Name := "提供者機碼")>
    Public Property ProviderKey As String
End Class

Public Class SetPasswordBindingModel
    <Required>
    <StringLength(100, ErrorMessage := "{0} 的長度至少必須為 {2} 個字元。", MinimumLength := 6)>
    <DataType(DataType.Password)>
    <Display(Name := "新密碼")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name := "確認新密碼")>
    <Compare("NewPassword", ErrorMessage := "新密碼與確認密碼不相符。")>
    Public Property ConfirmPassword As String
End Class
