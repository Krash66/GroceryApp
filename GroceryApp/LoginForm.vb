Public Class LoginForm

    Dim arrUsername() As String = {"Admin", "Clerk", "Manager"}
    Dim arrPasswords() As String = {"P@ssword", "pa$$word", "passwOrd"}
    Dim User As String

    '/// Initial Sub run when form is loaded
    Public Function doLogin() As String
        'Show this form Modally 
        Me.ShowDialog()
        'Wait for DailogResult to see what needs to happen next with thisform
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            'Login Successful, Close this Modal form and let user use Parent form 
            Me.Close()
            Return User
        Else
            'The close form button "X" was clicked to cancel out of the Login Form
            Me.Close()
            Return User
        End If
    End Function

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        'Set Username and Password Variables from the Form Values
        Dim UN As String = txtUsername.Text
        Dim PW As String = txtPassword.Text
        'Set the MainUser for the Application from form Vallue
        User = UN
        Login(UN, PW)
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'Do not set DialogResult, simply exit the Application
        Application.Exit()
    End Sub

    Sub Login(username As String, password As String)
        'Verify the UserName and Password
        If VerifyUsername(username) = True Then
            Dim idx As Integer
            idx = Array.IndexOf(arrUsername, username)
            If VerifyPassword(password, idx) = True Then
                'Login Successful
                'Set Dialog result of this form so It will close and allow access to Parent Form
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'Throw New LoginException      Note*** This will cause and UnHandled exception to occur if LoginException is called
                MessageBox.Show("Password Incorrect, Please try again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Do NOT set DialogResult so forn remains open for more user input
            End If
        Else
            'Throw New LoginException      Note*** This will cause and UnHandled exception to occur if LoginException is called
            MessageBox.Show("Username Incorrect, Please try again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Do NOT set DialogResult so forn remains open for more user input
        End If
    End Sub

    Function VerifyUsername(UN As String) As Boolean
        'Set Boolean Value for Whether UserName is True or False
        Dim UNtrue As Boolean = False
        'Test to see if the UserName Entered is contained in the Username Array
        If arrUsername.Contains(UN) Then
            UNtrue = True
        End If
        'Return whether UserName is Valid
        Return UNtrue
    End Function

    Function VerifyPassword(password As String, index As Integer) As Boolean
        'Set Boolean Value for Whether Password is True or False
        Dim PWTrue As Boolean = False
        'Test to see if the Password Entered is the correct one corresponding to it's position in the PW Array relative to the UN position in the UN Array
        If password = arrPasswords(index) Then
            PWTrue = True
        End If
        'Return Whether the Password is Valid
        Return PWTrue
    End Function

End Class