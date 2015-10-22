' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class QuadraticEquation
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

    Private Sub evaluateRoot_Click(sender As Object, e As RoutedEventArgs) Handles evaluateRoot.Click
        Dim l As Decimal
        Dim m As Decimal
        Dim n As Decimal
        Dim a = aInput.Text
        Dim b = bInput.Text
        Dim c = cInput.Text
        If Decimal.TryParse(a, l) Then
            If Decimal.TryParse(b, m) Then
                If Decimal.TryParse(c, n) Then
                    Dim D As Decimal = (m ^ 2) - (4 * l * n)
                    If D < 0 Then
                        resultBefore.Text = "Negative Discriminant (No Real Roots)"
                        result.Text = "Complex roots"
                    ElseIf D = 0 Then
                        resultBefore.Text = "Discriminant is Zero (1 Real Root)"
                        Dim x = Math.Round((-m + Math.Sqrt(D)) / (2 * l), 8)
                        result.Text = "x = " & x & " (Repeating Roots)"
                    Else
                        resultBefore.Text = "Positive Discriminant (2 Real Roots)"
                        Dim xOne = Math.Round((-m + Math.Sqrt(D)) / (2 * l), 8)
                        Dim xTwo = Math.Round((-m - Math.Sqrt(D)) / (2 * l), 8)
                        result.Text = "x = " & xOne & " , " & xTwo
                    End If
                Else
                    resultBefore.Text = "Invalid Input"
                    result.Text = ""
                End If
            Else
                resultBefore.Text = "Invalid Input"
                result.Text = ""
            End If
        Else
            resultBefore.Text = "Invalid Input"
            result.Text = ""
        End If

    End Sub

End Class
