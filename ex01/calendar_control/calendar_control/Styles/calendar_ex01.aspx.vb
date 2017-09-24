Public Class calendar_ex01
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Page.IsPostBack = False) Then
            Calendar1.SelectedDate = Now
            Label2.Text = "Please take a day !"
      

        End If

    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        Label2.Text = "You Selected" & Calendar1.SelectedDate.ToString()
    End Sub
End Class

