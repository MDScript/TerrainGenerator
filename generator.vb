Imports System

Module Module1
    
    sub Main()
        
    End Sub

End Module

Module generator
    
    Dim height As Integer = -1
    Dim width As Integer = -1
    
    Function Generate(ByVal world As Array) As Array
        
        While true
            height += 1
        
            Try
                If world(height) Then
                    ' do nothing
                End If
            Catch
                height -= 1
                Exit While
            End Try
            
        End While
        
        
        While true
            width += 1
        
            Try
                If world(0,width) Then
                    ' do nothing
                End If
            Catch
                width -= 1
                Exit While
            End Try
            
        End While
        
    End Sub
    
End Module
