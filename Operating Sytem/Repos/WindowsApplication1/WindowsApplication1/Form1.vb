Imports System.Data.OleDb '  Imports needs libaries for database conneection

Public Class FrmLogin

    'Variables

    'General Vars
    Dim logOutput As String

    'Database Connection Vars
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    ' Account Vars
    Dim username As String
    Dim password As String
    Dim firstName As String
    Dim lastName As String
    Dim email As String
    Dim permissionLevel As String
    Dim firstName_Real As String
    Dim lastName_Real As String

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Creates the windows form in fullscreen, AKA removing the startmenu.
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize

        ' Makes the loginPrompt panel NOT Visiable
        PnlLoginPrompt.Visible = False
        LblUsername.Visible = False
        LblPassword.Visible = False
        TxtUsername.Visible = False
        TxtPassword.Visible = False
        BtnLogin.Visible = False

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        ' Closes the program when the exit buttion is clicked
        Me.Close()

    End Sub

    Private Sub BtnBRMenu_Click(sender As Object, e As EventArgs) Handles BtnBRMenu.Click

        ' checks to see if the menu is open or closed 

        If PnlBRMenu.Height = 55 Then ' Closed

            ' Makes the button the correct colours 
            PnlBRMenu.BackColor = Color.FromArgb(168, 168, 168)
            BtnBRMenu.BackColor = Color.FromArgb(168, 168, 168)

            ' Opens the menu
            PnlBRMenu.Visible = False
            PnlBRMenu.Height = 500
            BRMenuAnimator.ShowSync(PnlBRMenu)

        Else

            ' Closes the menu
            PnlBRMenu.BackColor = Color.FromArgb(224, 224, 224)
            BtnBRMenu.BackColor = Color.FromArgb(224, 224, 224)
            PnlBRMenu.Visible = False
            PnlBRMenu.Height = 55
            BRMenuAnimator.ShowSync(PnlBRMenu)

        End If

    End Sub

    Private Sub BtnLoginMenu_Click(sender As Object, e As EventArgs) Handles BtnLoginMenu.Click

        ' Checks if the login button is at 100%,  aka not been pressed
        If PnlLogin.Height = 280 Then

            'Makes the login Prompy Visable
            PnlLoginPrompt.Location = New Point(815, 510)
            PnlLoginPrompt.Visible = True
            LblUsername.Visible = True
            LblPassword.Visible = True
            TxtUsername.Visible = True
            TxtPassword.Visible = True
            BtnLogin.Visible = True


            ' Pushes the Login Icon to the back aka not 100%
            PnlLogin.Height = 120
            PnlLogin.Visible = False
            PnlLoginAnimator.ShowSync(PnlLogin)

        Else

            ' Makes the loginPrompt NOT visible
            PnlLoginPrompt.Visible = False
            LblUsername.Visible = False
            LblPassword.Visible = False
            TxtUsername.Visible = False
            TxtPassword.Visible = False
            BtnLogin.Visible = False
            PnlLoginPrompt.Location = New Point(0, 0)

            ' Makes the login icon 100%
            PnlLogin.Height = 280
            PnlLogin.Visible = False
            PnlLoginAnimator.ShowSync(PnlLogin)

        End If

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\ProRyley\Desktop\Coding\UserLoginInformationDatabase.accdb"
        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        username = TxtUsername.Text
        password = TxtPassword.Text

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [UserDatabase] WHERE [username] = '" & username & "' AND [password] = '" & password & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False
        Dim firstName As String = ""
        Dim lastName As String = ""

        While dr.Read
            userFound = True
            firstName = dr("Forename").ToString
            lastName = dr("Surname").ToString
            email = dr("Email").ToString
            permissionLevel = dr("PermissionLevel").ToString

        End While

        firstName_Real = firstName
        lastName_Real = lastName

        If userFound = True Then

            MsgBox("User Found")
            myConnection.Close()

            logOutput = vbCrLf & firstName & " " & lastName & " " & "Permission Level - " & permissionLevel & " - " & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            My.Computer.FileSystem.WriteAllText("C:\Users\ProRyley\Desktop\Coding\Operating Sytem\Files\LoginLogs.txt", logOutput, True)

        Else

            MsgBox("User Not Found")

        End If

        myConnection.Close()

    End Sub
End Class
