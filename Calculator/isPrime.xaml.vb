﻿' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class isPrime
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

    Private Sub isPrime_Click(sender As Object, e As RoutedEventArgs) Handles isPrime.Click
        Dim m As ULong
        Dim a = isPrimeInput.Text
        If ULong.TryParse(a, m) Then
            If m = 0 Then
                isPrimeAnswer.Text = "Invalid Input"
                Exit Sub
            End If
            If m = 1 Then
                isPrimeAnswer.Text = "isPrime(" & isPrimeInput.Text & ") = False"
                Exit Sub
            End If
            For i As Decimal = 2 To Math.Sqrt(m)
                If (isPrimeInput.Text Mod i = 0) Then
                    isPrimeAnswer.Text = "isPrime(" & isPrimeInput.Text & ") = False"
                    Exit Sub
                End If
            Next
            isPrimeAnswer.Text = "isPrime(" & isPrimeInput.Text & ") = True"
        Else
            isPrimeAnswer.Text = "Invalid Input"
        End If

    End Sub

End Class
