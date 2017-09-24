Imports System.Net.Http
Imports System.Web.Http
Imports Microsoft.Owin.Security.OAuth
Imports Newtonsoft.Json.Serialization

Public Module WebApiConfig
    Public Sub Register(config As HttpConfiguration)
      ' Web API 設定和服務
      ' 將 Web API 設定成僅使用 bearer 權杖驗證。
      config.SuppressDefaultHostAuthentication()
      config.Filters.Add(New HostAuthenticationFilter(OAuthDefaults.AuthenticationType))

      ' Web API 路由
      config.MapHttpAttributeRoutes()

      config.Routes.MapHttpRoute(
          name:="DefaultApi",
          routeTemplate:="api/{controller}/{id}",
          defaults:=New With { .id = RouteParameter.Optional }
      )
    End Sub
End Module
