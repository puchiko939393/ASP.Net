Imports System.Web.Mvc
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Namespace MvcAppliction1_WebAPI_0001_VB
    Public Class ProductController
        Inherits ApiController


        '======the magic comes ...it is json format
        Private products As Product() = New Product() {
            New Product() With {.ProductId = 1, .ProductName = "Cola Cola", .ProductCat = "Beverages", .ProductPrice = 5D},
            New Product() With {.ProductId = 2, .ProductName = "Doll", .ProductCat = "Toy", .ProductPrice = 45D},
            New Product() With {.ProductId = 3, .ProductName = "Dai Dai Photato Chips", .ProductCat = "Snacks", .ProductPrice = 5D},
            New Product() With {.ProductId = 4, .ProductName = "Hammer", .ProductCat = "Hardware", .ProductPrice = 30D}}


        '==================Using Methods Get all products
        Public Function GetAllProduct() As IEnumerable(Of Product)
            Return products
        End Function

        '=================Get product by Id
        Public Function GetProductById(id As Integer) As Product
            Dim product = products.FirstOrDefault(Function(p) p.ProductId = id)
            If product Is Nothing Then
                Throw New HttpResponseException(HttpStatusCode.NotFound)

            End If

            Return product
        End Function

        Public Function GetProductByCat(cat As String) As IEnumerable(Of Product)
            Return products.Where(Function(p) String.Equals(p.ProductCat, cat, StringComparison.OrdinalIgnoreCase))


        End Function
    End Class




End Namespace