Imports System.Collections.Generic
Imports System.Linq
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.Google
Imports Microsoft.Owin.Security.OAuth
Imports Owin

Public Partial Class Startup
    Private Shared _OAuthOptions As OAuthAuthorizationServerOptions
    Private Shared _PublicClientId As String

    Public Shared Property OAuthOptions() As OAuthAuthorizationServerOptions
        Get
            Return _OAuthOptions
        End Get
        Private Set
            _OAuthOptions = Value
        End Set
    End Property

    Public Shared Property PublicClientId() As String
        Get
            Return _PublicClientId
        End Get
        Private Set
            _PublicClientId = Value
        End Set
    End Property

    ' 如需設定驗證的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301864
    Public Sub ConfigureAuth(app As IAppBuilder)
        ' 設定資料庫內容和使用者管理員以針對每個要求使用單一執行個體
        app.CreatePerOwinContext(AddressOf ApplicationDbContext.Create)
        app.CreatePerOwinContext(Of ApplicationUserManager)(AddressOf ApplicationUserManager.Create)

        ' 讓應用程式使用 Cookie 儲存已登入使用者的資訊
        ' 並使用 Cookie 暫時儲存使用者利用協力廠商登入提供者登入的相關資訊；
        app.UseCookieAuthentication(New CookieAuthenticationOptions())
        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        ' 設定 OAuth 基礎流程的應用程式
        ' 在生產模式中設定 AllowInsecureHttp = False
        PublicClientId = "self"
        OAuthOptions = New OAuthAuthorizationServerOptions() With {
          .TokenEndpointPath = New PathString("/Token"),
          .Provider = New ApplicationOAuthProvider(PublicClientId),
          .AuthorizeEndpointPath = New PathString("/api/Account/ExternalLogin"),
          .AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
          .AllowInsecureHttp = True
        }

        ' 讓應用程式使用 Bearer 權杖驗證使用者
        app.UseOAuthBearerTokens(OAuthOptions)

        ' 註銷下列各行以啟用利用協力廠商登入提供者登入
        'app.UseMicrosoftAccountAuthentication(
        '    clientId:="",
        '    clientSecret:="")

        'app.UseTwitterAuthentication(
        '    consumerKey:="",
        '    consumerSecret:="")

        'app.UseFacebookAuthentication(
        '    appId:="",
        '    appSecret:="")

        'app.UseGoogleAuthentication(New GoogleOAuth2AuthenticationOptions() With {
        '    .ClientId = "",
        '    .ClientSecret = ""})
    End Sub
End Class
