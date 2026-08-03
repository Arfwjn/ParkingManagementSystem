Imports System.Windows.Forms

Namespace Views
    Partial Class EntryForm

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.lblTitle = New Label()
            Me.lblPlateNumber = New Label()
            Me.txtPlateNumber = New TextBox()
            Me.lblVehicleType = New Label()
            Me.cmbVehicleType = New ComboBox()
            Me.btnSave = New Button()
            Me.btnClose = New Button()
            Me.lblStatusMessage = New Label()
            Me.SuspendLayout()
            '
            ' lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.Location = New System.Drawing.Point(30, 20)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(202, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "INPUT KENDARAAN MASUK"
            '
            ' lblPlateNumber
            '
            Me.lblPlateNumber.AutoSize = True
            Me.lblPlateNumber.Location = New System.Drawing.Point(30, 65)
            Me.lblPlateNumber.Name = "lblPlateNumber"
            Me.lblPlateNumber.Size = New System.Drawing.Size(76, 15)
            Me.lblPlateNumber.TabIndex = 1
            Me.lblPlateNumber.Text = "Nomor Polisi:"
            '
            ' txtPlateNumber
            '
            Me.txtPlateNumber.CharacterCasing = CharacterCasing.Upper
            Me.txtPlateNumber.Font = New System.Drawing.Font("Segoe UI", 11.0!)
            Me.txtPlateNumber.Location = New System.Drawing.Point(33, 85)
            Me.txtPlateNumber.Name = "txtPlateNumber"
            Me.txtPlateNumber.Size = New System.Drawing.Size(320, 27)
            Me.txtPlateNumber.TabIndex = 2
            '
            ' lblVehicleType
            '
            Me.lblVehicleType.AutoSize = True
            Me.lblVehicleType.Location = New System.Drawing.Point(30, 125)
            Me.lblVehicleType.Name = "lblVehicleType"
            Me.lblVehicleType.Size = New System.Drawing.Size(91, 15)
            Me.lblVehicleType.TabIndex = 3
            Me.lblVehicleType.Text = "Jenis Kendaraan:"
            '
            ' cmbVehicleType
            '
            Me.cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbVehicleType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cmbVehicleType.FormattingEnabled = True
            Me.cmbVehicleType.Items.AddRange(New Object() {"Mobil", "Motor"})
            Me.cmbVehicleType.Location = New System.Drawing.Point(33, 145)
            Me.cmbVehicleType.Name = "cmbVehicleType"
            Me.cmbVehicleType.Size = New System.Drawing.Size(320, 25)
            Me.cmbVehicleType.TabIndex = 4
            '
            ' lblStatusMessage
            '
            Me.lblStatusMessage.AutoSize = True
            Me.lblStatusMessage.ForeColor = System.Drawing.Color.Red
            Me.lblStatusMessage.Location = New System.Drawing.Point(30, 185)
            Me.lblStatusMessage.Name = "lblStatusMessage"
            Me.lblStatusMessage.Size = New System.Drawing.Size(0, 15)
            Me.lblStatusMessage.TabIndex = 5
            '
            ' btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
            Me.btnSave.FlatStyle = FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(33, 220)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(150, 40)
            Me.btnSave.TabIndex = 6
            Me.btnSave.Text = "SIMPAN"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            ' btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Gray
            Me.btnClose.FlatStyle = FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.Location = New System.Drawing.Point(203, 220)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(150, 40)
            Me.btnClose.TabIndex = 7
            Me.btnClose.Text = "BATAL"
            Me.btnClose.UseVisualStyleBackColor = False
            '
            ' EntryForm
            '
            Me.ClientSize = New System.Drawing.Size(390, 290)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.lblStatusMessage)
            Me.Controls.Add(Me.cmbVehicleType)
            Me.Controls.Add(Me.lblVehicleType)
            Me.Controls.Add(Me.txtPlateNumber)
            Me.Controls.Add(Me.lblPlateNumber)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "EntryForm"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Parking App - Entry System"
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents lblPlateNumber As Label
        Friend WithEvents txtPlateNumber As TextBox
        Friend WithEvents lblVehicleType As Label
        Friend WithEvents cmbVehicleType As ComboBox
        Friend WithEvents btnSave As Button
        Friend WithEvents btnClose As Button
        Friend WithEvents lblStatusMessage As Label
    End Class
End Namespace