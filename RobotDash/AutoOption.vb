Public Class AutoOption
   Public autoIndex        As Integer
   Public description      As String
   Public startPositions   As Integer
   Public validForLRL      As Boolean
   Public validForRLR      As Boolean
   Public validForLLL      As Boolean
   Public validForRRR      As Boolean

   Public Sub New(index As Integer, desc As String, start As Integer, LRL As Boolean, RLR As Boolean, LLL As Boolean, RRR As Boolean)
      autoIndex = index
      description = desc
      startPositions = start
      validForLRL = LRL
      validForRLR = RLR
      validForLLL = LLL
      validForRRR = RRR
   End Sub
End Class
