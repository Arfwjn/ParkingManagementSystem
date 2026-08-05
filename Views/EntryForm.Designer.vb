Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class EntryForm
        Inherits System.Windows.Forms.Form

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

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.pnlCard = New System.Windows.Forms.Panel()
            Me.lblPlateNumber = New System.Windows.Forms.Label()
            Me.txtPlateNumber = New System.Windows.Forms.TextBox()
            Me.lblMemberStatus = New System.Windows.Forms.Label()
            Me.lblVehicleType = New System.Windows.Forms.Label()
            Me.cmbVehicleType = New System.Windows.Forms.ComboBox()
            Me.lblTariffInfo = New System.Windows.Forms.Label()
            Me.btnSubmit = New System.Windows.Forms.Button()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlCard.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.btnClose)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(500, 60)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(20, 18)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(193, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Transaksi Parkir Masuk"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(453, 12)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(35, 35)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "X"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.pnlMain.Controls.Add(Me.pnlCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 60)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
            Me.pnlMain.Size = New System.Drawing.Size(500, 360)
            Me.pnlMain.TabIndex = 1
            '
            'pnlCard
            '
            Me.pnlCard.BackColor = System.Drawing.Color.White
            Me.pnlCard.Controls.Add(Me.lblPlateNumber)
            Me.pnlCard.Controls.Add(Me.txtPlateNumber)
            Me.pnlCard.Controls.Add(Me.lblMemberStatus)
            Me.pnlCard.Controls.Add(Me.lblVehicleType)
            Me.pnlCard.Controls.Add(Me.cmbVehicleType)
            Me.pnlCard.Controls.Add(Me.lblTariffInfo)
            Me.pnlCard.Controls.Add(Me.btnSubmit)
            Me.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCard.Location = New System.Drawing.Point(20, 20)
            Me.pnlCard.Name = "pnlCard"
            Me.pnlCard.Padding = New System.Windows.Forms.Padding(20)
            Me.pnlCard.Size = New System.Drawing.Size(460, 320)
            Me.pnlCard.TabIndex = 0
            '
            'lblPlateNumber
            '
            Me.lblPlateNumber.AutoSize = True
            Me.lblPlateNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblPlateNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPlateNumber.Location = New System.Drawing.Point(20, 20)
            Me.lblPlateNumber.Name = "lblPlateNumber"
            Me.lblPlateNumber.Size = New System.Drawing.Size(133, 15)
            Me.lblPlateNumber.TabIndex = 0
            Me.lblPlateNumber.Text = "Plat Nomor Kendaraan:"
            '
            'txtPlateNumber
            '
            Me.txtPlateNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPlateNumber.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.txtPlateNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPlateNumber.Location = New System.Drawing.Point(23, 40)
            Me.txtPlateNumber.Name = "txtPlateNumber"
            Me.txtPlateNumber.Size = New System.Drawing.Size(414, 27)
            Me.txtPlateNumber.TabIndex = 1
            '
            'lblMemberStatus
            '
            Me.lblMemberStatus.AutoSize = True
            Me.lblMemberStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblMemberStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblMemberStatus.Location = New System.Drawing.Point(20, 72)
            Me.lblMemberStatus.Name = "lblMemberStatus"
            Me.lblMemberStatus.Size = New System.Drawing.Size(125, 15)
            Me.lblMemberStatus.TabIndex = 2
            Me.lblMemberStatus.Text = "* Status: Non-Member"
            '
            'lblVehicleType
            '
            Me.lblVehicleType.AutoSize = True
            Me.lblVehicleType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblVehicleType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblVehicleType.Location = New System.Drawing.Point(20, 105)
            Me.lblVehicleType.Name = "lblVehicleType"
            Me.lblVehicleType.Size = New System.Drawing.Size(92, 15)
            Me.lblVehicleType.TabIndex = 3
            Me.lblVehicleType.Text = "Jenis Kendaraan:"
            '
            'cmbVehicleType
            '
            Me.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbVehicleType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cmbVehicleType.FormattingEnabled = True
            Me.cmbVehicleType.Items.AddRange(New Object() {"Mobil", "Motor"})
            Me.cmbVehicleType.Location = New System.Drawing.Point(23, 125)
            Me.cmbVehicleType.Name = "cmbVehicleType"
            Me.cmbVehicleType.Size = New System.Drawing.Size(414, 25)
            Me.cmbVehicleType.TabIndex = 4
            '
            'lblTariffInfo
            '
            Me.lblTariffInfo.AutoSize = True
            Me.lblTariffInfo.Font = New System.Drawing.Font("Segoe UI Italic", 8.5!)
            Me.lblTariffInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTariffInfo.Location = New System.Drawing.Point(20, 158)
            Me.lblTariffInfo.Name = "lblTariffInfo"
            Me.lblTariffInfo.Size = New System.Drawing.Size(201, 15)
            Me.lblTariffInfo.TabIndex = 5
            Me.lblTariffInfo.Text = "* Tarif: Per Jam: Rp 0 | Inap: Rp 0"
            '
            'btnSubmit
            '
            Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSubmit.FlatAppearance.BorderSize = 0
            Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnSubmit.ForeColor = System.Drawing.Color.White
            Me.btnSubmit.Location = New System.Drawing.Point(23, 210)
            Me.btnSubmit.Name = "btnSubmit"
            Me.btnSubmit.Size = New System.Drawing.Size(414, 42)
            Me.btnSubmit.TabIndex = 6
            Me.btnSubmit.Text = "Cetak Tiket & Simpan Masuk"
            Me.btnSubmit.UseVisualStyleBackColor = False
            '
            'EntryForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(500, 420)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "EntryForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Transaksi Parkir Masuk"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlCard.ResumeLayout(False)
            Me.pnlCard.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlCard As System.Windows.Forms.Panel
        Friend WithEvents lblPlateNumber As System.Windows.Forms.Label
        Friend WithEvents txtPlateNumber As System.Windows.Forms.TextBox
        Friend WithEvents lblMemberStatus As System.Windows.Forms.Label
        Friend WithEvents lblVehicleType As System.Windows.Forms.Label
        Friend WithEvents cmbVehicleType As System.Windows.Forms.ComboBox
        Friend WithEvents lblTariffInfo As System.Windows.Forms.Label
        Friend WithEvents btnSubmit As System.Windows.Forms.Button
    End Class
End Namespace