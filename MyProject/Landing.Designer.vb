<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Landing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.string_welcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataTable = New System.Windows.Forms.DataGridView()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.testButton = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.exportButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.genderBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.birthTextBox = New System.Windows.Forms.TextBox()
        Me.profileBox = New System.Windows.Forms.TextBox()
        Me.bioBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.csvImport = New System.Windows.Forms.Button()
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'string_welcome
        '
        Me.string_welcome.AutoSize = True
        Me.string_welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.string_welcome.Location = New System.Drawing.Point(12, 9)
        Me.string_welcome.Name = "string_welcome"
        Me.string_welcome.Size = New System.Drawing.Size(130, 25)
        Me.string_welcome.TabIndex = 0
        Me.string_welcome.Text = "WELCOME "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Users:"
        '
        'dataTable
        '
        Me.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataTable.Location = New System.Drawing.Point(17, 83)
        Me.dataTable.Name = "dataTable"
        Me.dataTable.RowHeadersWidth = 51
        Me.dataTable.RowTemplate.Height = 24
        Me.dataTable.Size = New System.Drawing.Size(689, 455)
        Me.dataTable.TabIndex = 2
        '
        'loadButton
        '
        Me.loadButton.Location = New System.Drawing.Point(712, 83)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(178, 38)
        Me.loadButton.TabIndex = 3
        Me.loadButton.Text = "Re/Load Data"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'testButton
        '
        Me.testButton.Location = New System.Drawing.Point(896, 83)
        Me.testButton.Name = "testButton"
        Me.testButton.Size = New System.Drawing.Size(179, 38)
        Me.testButton.TabIndex = 4
        Me.testButton.Text = "Test Connection"
        Me.testButton.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(712, 438)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(363, 30)
        Me.back_btn.TabIndex = 5
        Me.back_btn.Text = "Backup Database"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'exportButton
        '
        Me.exportButton.Location = New System.Drawing.Point(712, 509)
        Me.exportButton.Name = "exportButton"
        Me.exportButton.Size = New System.Drawing.Size(363, 29)
        Me.exportButton.TabIndex = 6
        Me.exportButton.Text = "EXPORT Data Grid"
        Me.exportButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(712, 127)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(113, 31)
        Me.addButton.TabIndex = 7
        Me.addButton.Text = "Add User"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(831, 127)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(113, 31)
        Me.updateButton.TabIndex = 8
        Me.updateButton.Text = "Update User"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(950, 127)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(125, 31)
        Me.deleteButton.TabIndex = 9
        Me.deleteButton.Text = "Delete User"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'idTextBox
        '
        Me.idTextBox.Enabled = False
        Me.idTextBox.Location = New System.Drawing.Point(712, 180)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(182, 22)
        Me.idTextBox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(712, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(712, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "First Name:"
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Location = New System.Drawing.Point(712, 224)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(182, 22)
        Me.fnameTextBox.TabIndex = 12
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Location = New System.Drawing.Point(712, 268)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(182, 22)
        Me.lnameTextBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(712, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(900, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Username:"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(900, 180)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(175, 22)
        Me.usernameTextBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(900, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Email:"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(900, 224)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(175, 22)
        Me.emailTextBox.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(900, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Password:"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(900, 268)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(175, 22)
        Me.passwordTextBox.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(712, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Gender:"
        '
        'genderBox
        '
        Me.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genderBox.FormattingEnabled = True
        Me.genderBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.genderBox.Location = New System.Drawing.Point(712, 312)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(182, 24)
        Me.genderBox.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(900, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Birthdate:"
        '
        'birthTextBox
        '
        Me.birthTextBox.Location = New System.Drawing.Point(900, 314)
        Me.birthTextBox.Name = "birthTextBox"
        Me.birthTextBox.Size = New System.Drawing.Size(175, 22)
        Me.birthTextBox.TabIndex = 25
        '
        'profileBox
        '
        Me.profileBox.Location = New System.Drawing.Point(712, 358)
        Me.profileBox.Name = "profileBox"
        Me.profileBox.Size = New System.Drawing.Size(182, 22)
        Me.profileBox.TabIndex = 27
        '
        'bioBox
        '
        Me.bioBox.Location = New System.Drawing.Point(900, 358)
        Me.bioBox.Name = "bioBox"
        Me.bioBox.Size = New System.Drawing.Size(175, 22)
        Me.bioBox.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(712, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Profile Picture Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(900, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "BIO"
        '
        'csvImport
        '
        Me.csvImport.Location = New System.Drawing.Point(712, 474)
        Me.csvImport.Name = "csvImport"
        Me.csvImport.Size = New System.Drawing.Size(363, 29)
        Me.csvImport.TabIndex = 31
        Me.csvImport.Text = "Import CSV File"
        Me.csvImport.UseVisualStyleBackColor = True
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 550)
        Me.Controls.Add(Me.csvImport)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.bioBox)
        Me.Controls.Add(Me.profileBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.birthTextBox)
        Me.Controls.Add(Me.genderBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lnameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fnameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.exportButton)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.testButton)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.dataTable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.string_welcome)
        Me.Name = "Landing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Landing"
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents string_welcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dataTable As DataGridView
    Friend WithEvents loadButton As Button
    Friend WithEvents testButton As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents exportButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fnameTextBox As TextBox
    Friend WithEvents lnameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents genderBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents birthTextBox As TextBox
    Friend WithEvents profileBox As TextBox
    Friend WithEvents bioBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents csvImport As Button
End Class
