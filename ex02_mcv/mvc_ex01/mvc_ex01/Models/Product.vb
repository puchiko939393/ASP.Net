Public Class Product
    Private m_Id As Integer

    Public Property ProductId() As Integer
        Get
            Return m_Id

        End Get
        Set(value As Integer)
            m_Id = value
        End Set
    End Property
    '======================================OOP method for the class
    Private m_name As String
    Public Property ProductName() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property
    '====================================
    Private m_cat As String
    Public Property ProductCat() As String
        Get
            Return m_cat
        End Get
        Set(value As String)
            m_cat = value
        End Set
    End Property
    '==================================
    Private m_price As Decimal
    Public Property ProductPrice() As Decimal
        Get
            Return m_price
        End Get
        Set(value As Decimal)
            m_price = value
        End Set
    End Property



End Class
