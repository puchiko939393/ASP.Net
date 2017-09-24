Imports System.Web.Mvc
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http



Namespace Controller
    Public Class ProductController
        Inherits System.Web.Http.ApiController

        ' GET: Product
        ' Function Index() As ActionResult
        'Return View()
        'End Functionv


        Private productsroducts As Product() = New Product() {
            New Product() With {.ProductId = 1, .ProductName = "Cola Cola", .ProductCat = "Beverages", .ProductPrice = 5D},
            New Product() With {.ProductId = 2, .ProductName = "Doll", .ProductCat = "Toy", .ProductPrice = 45D},
            New Product() With {.ProductId = 3, .ProductName = "Dai Dai Photato Chips", .ProductCat = "Snacks", .ProductPrice = 5D},
            New Product() With {.ProductId = 4, .ProductName = "Hammer", .ProductCat = "Hardware", .ProductPrice = 30D}}


        '==================Using Methods Get all products
        Public Function GetAllProduct() As IEnumerable(Of Product)
            Return productsroducts
        End Function

        '=================Get product by Id
        Public Function GetProductById(id As Integer) As Product
            Dim product = productsroducts.FirstOrDefault(Function(p) p.ProductId = id)
            If product Is Nothing Then
                Throw New HttpResponseException(HttpStatusCode.NotFound)

            End If

            Return product
        End Function

        Public Function GetProductByCat(cat As String) As IEnumerable(Of Product)
            Return productsroducts.Where(Function(p) String.Equals(p.ProductCat, cat, StringComparison.OrdinalIgnoreCase))


        End Function
    End Class

End Namespace
