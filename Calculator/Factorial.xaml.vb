' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class Factorial
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

    Private Sub factorial_Click(sender As Object, e As RoutedEventArgs) Handles factorial.Click
        Dim i As Decimal
        Dim a = factorialInput.Text
        If UInteger.TryParse(a, i) Then
            If i > 10000 Then
                factorialInfo.Text = "Overflow (maximum 10000)"
                factorialAnswer.Text = ""
            Else
                factorialInfo.Text = "Factorial of " & factorialInput.Text & " is :"
                If factorialInput.Text < 30 Then
                    factorialAnswer.Text = fact(factorialInput.Text).ToString()
                Else
                    Dim bigint As System.Numerics.BigInteger = fact(factorialInput.Text)
                    factorialAnswer.Text = bigint.ToString("E")
                End If
            End If
        Else
            factorialInfo.Text = "Invalid Input"
            factorialAnswer.Text = ""


        End If
    End Sub

    Private Function fact(number)
        Dim f As System.Numerics.BigInteger = 1
        For i As Integer = 1 To number
            f *= i
        Next
        Return f
    End Function

   
End Class
