Namespace Views
    Partial Class UpdateCapacityForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.lblCarSlot = New System.Windows.Forms.Label()
            Me.numCarCapacity = New System.Windows.Forms.NumericUpDown()
            Me.lblMotorSlot = New System.Windows.Forms.Label()
            Me.numMotorCapacity = New System.Windows.Forms.NumericUpDown()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            CType(Me.numCarCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numMotorCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.pnlHeader.Size = New System.Drawing.Size(450, 55)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(20, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(280, 25)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "UPDATE KAPASITAS SLOT PARKIR"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.Location = New System.Drawing.Point(400, 10)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(40, 35)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "✕"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.White
            Me.pnlMain.Controls.Add(Me.btnCancel)
            Me.pnlMain.Controls.Add(Me.btnSave)
            Me.pnlMain.Controls.Add(Me.numMotorCapacity)
            Me.pnlMain.Controls.Add(Me.lblMotorSlot)
            Me.pnlMain.Controls.Add(Me.numCarCapacity)
            Me.pnlMain.Controls.Add(Me.lblCarSlot)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 55)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(25)
            Me.pnlMain.Size = New System.Drawing.Size(450, 265)
            Me.pnlMain.TabIndex = 1
            '
            'lblCarSlot
            '
            Me.lblCarSlot.AutoSize = True
            Me.lblCarSlot.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblCarSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblCarSlot.Location = New System.Drawing.Point(25, 25)
            Me.lblCarSlot.Name = "lblCarSlot"
            Me.lblCarSlot.Size = New System.Drawing.Size(161, 20)
            Me.lblCarSlot.TabIndex = 0
            Me.lblCarSlot.Text = "Kapasitas Slot Mobil:"
            '
            'numCarCapacity
            '
            Me.numCarCapacity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.numCarCapacity.Location = New System.Drawing.Point(25, 50)
            Me.numCarCapacity.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.numCarCapacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numCarCapacity.Name = "numCarCapacity"
            Me.numCarCapacity.Size = New System.Drawing.Size(400, 30)
            Me.numCarCapacity.TabIndex = 1
            Me.numCarCapacity.Value = New Decimal(New Integer() {50, 0, 0, 0})
            '
            'lblMotorSlot
            '
            Me.lblMotorSlot.AutoSize = True
            Me.lblMotorSlot.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblMotorSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblMotorSlot.Location = New System.Drawing.Point(25, 95)
            Me.lblMotorSlot.Name = "lblMotorSlot"
            Me.lblMotorSlot.Size = New System.Drawing.Size(213, 20)
            Me.lblMotorSlot.TabIndex = 2
            Me.lblMotorSlot.Text = "Kapasitas Slot Sepeda Motor:"
            '
            'numMotorCapacity
            '
            Me.numMotorCapacity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.numMotorCapacity.Location = New System.Drawing.Point(25, 120)
            Me.numMotorCapacity.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.numMotorCapacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numMotorCapacity.Name = "numMotorCapacity"
            Me.numMotorCapacity.Size = New System.Drawing.Size(400, 30)
            Me.numMotorCapacity.TabIndex = 3
            Me.numMotorCapacity.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(25, 185)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(190, 42)
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "SIMPAN"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnCancel.ForeColor = System.Drawing.Color.White
            Me.btnCancel.Location = New System.Drawing.Point(235, 185)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(190, 42)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "BATAL"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'UpdateCapacityForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(450, 320)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "UpdateCapacityForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Update Kapasitas Parkir"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlMain.PerformLayout()
            CType(Me.numCarCapacity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numMotorCapacity, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents lblCarSlot As System.Windows.Forms.Label
        Friend WithEvents numCarCapacity As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblMotorSlot As System.Windows.Forms.Label
        Friend WithEvents numMotorCapacity As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
    End Class
End Namespace
