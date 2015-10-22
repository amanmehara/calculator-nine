' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class SimpleArithmeticOperations
    Inherits Common.LayoutAwarePage

    ''' <summary>
    ''' Populates the page with content passed during navigation.  Any saved state is also
    ''' provided when recreating a page from a prior session.
    ''' </summary>
    ''' <param name="navigationParameter">The parameter value passed to
    ''' <see cref="Frame.Navigate"/> when this page was initially requested.
    ''' </param>
    ''' <param name="pageState">A dictionary of state preserved by this page during an earlier
    ''' session.  This will be null the first time a page is visited.</param>
    Protected Overrides Sub LoadState(navigationParameter As Object, pageState As Dictionary(Of String, Object))

    End Sub

    ''' <summary>
    ''' Preserves state associated with this page in case the application is suspended or the
    ''' page is discarded from the navigation cache.  Values must conform to the serialization
    ''' requirements of <see cref="Common.SuspensionManager.SessionState"/>.
    ''' </summary>
    ''' <param name="pageState">An empty dictionary to be populated with serializable state.</param>
    Protected Overrides Sub SaveState(pageState As Dictionary(Of String, Object))

    End Sub
    Private Sub Addition_Click(sender As Object, e As RoutedEventArgs) Handles Addition.Click
        Dim i As Decimal
        Dim j As Decimal
        Dim a = textBox1.Text
        Dim b = textBox2.Text
        If Decimal.TryParse(a, i) Then
            If Decimal.TryParse(b, j) Then
                Answer.Text = i & " + " & j & " = " & (i + j)
            Else
                Answer.Text = "Invalid Input"
            End If
        Else
            Answer.Text = "Invalid Input"
        End If
    End Sub

    Private Sub Subtraction_Click(sender As Object, e As RoutedEventArgs) Handles Subtraction.Click
        Dim i As Decimal
        Dim j As Decimal
        Dim a = textBox1.Text
        Dim b = textBox2.Text
        If Decimal.TryParse(a, i) Then
            If Decimal.TryParse(b, j) Then
                Answer.Text = i & " - " & j & " = " & (i - j)
            Else
                Answer.Text = "Invalid Input"
            End If
        Else
            Answer.Text = "Invalid Input"
        End If
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As RoutedEventArgs) Handles Multiplication.Click
        Dim i As Decimal
        Dim j As Decimal
        Dim a = textBox1.Text
        Dim b = textBox2.Text
        If Decimal.TryParse(a, i) Then
            If Decimal.TryParse(b, j) Then
                Answer.Text = i & " * " & j & " = " & (i * j)
            Else
                Answer.Text = "Invalid Input"
            End If
        Else
            Answer.Text = "Invalid Input"
        End If
    End Sub

    Private Sub Division_Click(sender As Object, e As RoutedEventArgs) Handles Division.Click
        Dim i As Decimal
        Dim j As Decimal
        Dim a = textBox1.Text
        Dim b = textBox2.Text
        '
        If Decimal.TryParse(a, i) Then
            If Decimal.TryParse(b, j) Then
                If j = 0 Then
                    Answer.Text = "Invalid Input (Divide by Zero)"
                Else
                    Answer.Text = i & " / " & j & " = " & (i / j)
                End If
            Else
                Answer.Text = "Invalid Input"
            End If
        Else
            Answer.Text = "Invalid Input"
        End If
    End Sub

End Class
