Public Class ListItem
   Public ItemId     As Integer
   Public ItemName   As String

   Public Sub New(ByVal id As Integer, ByVal name As String)
      ItemId = id
      ItemName = name
   End Sub

   Public Overrides Function ToString() As String
      Return ItemName 
   End Function
End Class
