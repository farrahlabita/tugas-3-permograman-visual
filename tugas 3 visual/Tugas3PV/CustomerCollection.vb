Public Class CustomerCollection
    Inherits CollectionBase
    'Add a customer to the collection
    'Private member
    Private objEmailHashtable As New Hashtable

    'EmailHashtable property to return the Email Hashtable
    Public ReadOnly Property EmailHashtable() As Hashtable
        Get
            Return objEmailHashtable
        End Get
    End Property
    Public Sub Add(newCustomer As Customer)
        Me.List.Add(newCustomer)
        'Add the email address to the Hashtable
        EmailHashtable.Add(newCustomer.Email, newCustomer)
    End Sub
    'Remove a customer from the collection
    Public Sub Remove(oldCustomer As Customer)
        Me.List.Remove(oldCustomer)
    End Sub
    'Item property to read or update a customer at a given position
    'in the list
    Default Public Property Item(index As Integer) As Customer
        Get
            Return CType(Me.List.Item(index), Customer)
        End Get
        Set(value As Customer)
            Me.List.Item(index) = value
        End Set
    End Property

    'Overload Item property to find a customer by email address
    Default Public ReadOnly Property Item(email As String) As Customer
        Get
            Return CType(EmailHashtable.Item(email), Customer)
        End Get
    End Property

End Class
