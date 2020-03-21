Module TextChange
    Public Sub ChangeColor(rt As RichTextBox, start As Int16, Optional length As Byte = 1)


        With rt
            .SelectionAlignment = HorizontalAlignment.Left
            .SelectionStart = start
            .SelectionLength = length
            .SelectionColor = Color.Crimson

        End With
    End Sub
End Module
