' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class LinearEquationTwoVariable
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

    Private Sub EvaluateRoot_Click(sender As Object, e As RoutedEventArgs) Handles EvaluateRoot.Click
        Dim l, m, n, o, p, q As Decimal
        Dim a1 = a1Input.Text
        Dim b1 = b1Input.Text
        Dim c1 = c1Input.Text
        Dim a2 = a2Input.Text
        Dim b2 = b2Input.Text
        Dim c2 = c2Input.Text
        If Decimal.TryParse(a1, l) And Decimal.TryParse(b1, m) And Decimal.TryParse(c1, n) Then
            If Decimal.TryParse(a2, o) And Decimal.TryParse(b2, p) And Decimal.TryParse(c2, q) Then
                If ((l * p) - (m * o)) Then
                    resultInfo.Text = "Unique Solution"
                    Dim x As Decimal = ((m * q) - (p * n)) / ((l * p) - (o * m))
                    Dim y As Decimal = ((n * o) - (q * l)) / ((l * p) - (o * m))
                    resultx.Text = "x = " & x
                    resulty.Text = "y = " & y
                ElseIf ((l * p) - (m * o)) = 0 And ((m * q) - (n * p)) = 0 And ((l * q) - (n * o)) = 0 Then
                    If (l = 0 And m = 0) Or (o = 0 And p = 0) Then
                        resultInfo.Text = "Error"
                        resultx.Text = ""
                        resulty.Text = ""
                        Exit Sub
                    End If
                    resultInfo.Text = "Infinitely Many Solutions"
                    resultx.Text = "x = k"
                    If l = 0 Then
                        resultInfo.Text = "Unique Solution"
                        resultx.Text = "A 1 variable Linear Equation"
                        resulty.Text = "y = " & (-(n / m))
                    ElseIf m = 0 Then
                        resultInfo.Text = "Unique Solution"
                        resultx.Text = "x = " & (-(n / l))
                        resulty.Text = "A 1 variable Linear Equation"
                    Else
                        If (n / m) > 0 Then
                            If (-(l / m)) = 1 Then
                                resulty.Text = "y = k-" & (n / m)
                            ElseIf (-(l / m)) = 1 Then
                                resulty.Text = "y = -k-" & (n / m)
                            Else
                                resulty.Text = "y = " & (-(l / m)) & "k-" & (n / m)
                            End If
                        ElseIf (n / m) < 0 Then
                            If (-(l / m)) = 1 Then
                                resulty.Text = "y = k+" & (n / m)
                            ElseIf (-(l / m)) = 1 Then
                                resulty.Text = "y = -k+" & (n / m)
                            Else
                                resulty.Text = "y = " & (-(l / m)) & "k+" & (n / m)
                            End If
                        Else
                            If (-(l / m)) = 1 Then
                                resulty.Text = "y = k"
                            ElseIf (-(l / m)) = 1 Then
                                resulty.Text = "y = -k"
                            Else
                                resulty.Text = "y = " & (-(l / m)) & "k"
                            End If
                        End If
                    End If
                Else
                    resultInfo.Text = "No Solution"
                    resultx.Text = "Lines never Intersect"
                    resulty.Text = "Parallel Lines"
                End If
            Else
                resultInfo.Text = "Invalid Input"
                resultx.Text = ""
                resulty.Text = ""
            End If
        Else
            resultInfo.Text = "Invalid Input"
            resultx.Text = ""
            resulty.Text = ""

        End If

    End Sub

End Class
