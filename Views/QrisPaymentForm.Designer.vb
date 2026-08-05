Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class QrisPaymentForm
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
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.pnlCard = New System.Windows.Forms.Panel()
            Me.lblTransactionTitle = New System.Windows.Forms.Label()
            Me.lblAmountTitle = New System.Windows.Forms.Label()
            Me.lblAmountValue = New System.Windows.Forms.Label()
            Me.picQrisCode = New System.Windows.Forms.PictureBox()
            Me.lblNotice = New System.Windows.Forms.Label()
            Me.btnConfirm = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlCard.SuspendLayout()
            CType(Me.picQrisCode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(560, 68)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(27, 20)
            Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(238, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Pembayaran QRIS Statis"
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.pnlMain.Controls.Add(Me.pnlCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 68)
            Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(20, 18, 20, 18)
            Me.pnlMain.Size = New System.Drawing.Size(560, 597)
            Me.pnlMain.TabIndex = 1
            '
            'pnlCard
            '
            Me.pnlCard.BackColor = System.Drawing.Color.White
            Me.pnlCard.Controls.Add(Me.lblTransactionTitle)
            Me.pnlCard.Controls.Add(Me.lblAmountTitle)
            Me.pnlCard.Controls.Add(Me.lblAmountValue)
            Me.pnlCard.Controls.Add(Me.picQrisCode)
            Me.pnlCard.Controls.Add(Me.lblNotice)
            Me.pnlCard.Controls.Add(Me.btnConfirm)
            Me.pnlCard.Controls.Add(Me.btnCancel)
            Me.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCard.Location = New System.Drawing.Point(20, 18)
            Me.pnlCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlCard.Name = "pnlCard"
            Me.pnlCard.Padding = New System.Windows.Forms.Padding(20, 18, 20, 18)
            Me.pnlCard.Size = New System.Drawing.Size(520, 561)
            Me.pnlCard.TabIndex = 0
            '
            'lblTransactionTitle
            '
            Me.lblTransactionTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblTransactionTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblTransactionTitle.Location = New System.Drawing.Point(20, 12)
            Me.lblTransactionTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTransactionTitle.Name = "lblTransactionTitle"
            Me.lblTransactionTitle.Size = New System.Drawing.Size(480, 25)
            Me.lblTransactionTitle.TabIndex = 0
            Me.lblTransactionTitle.Text = "Pembayaran Member Parkir"
            Me.lblTransactionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblAmountTitle
            '
            Me.lblAmountTitle.AutoSize = True
            Me.lblAmountTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.lblAmountTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblAmountTitle.Location = New System.Drawing.Point(200, 43)
            Me.lblAmountTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblAmountTitle.Name = "lblAmountTitle"
            Me.lblAmountTitle.Size = New System.Drawing.Size(117, 20)
            Me.lblAmountTitle.TabIndex = 1
            Me.lblAmountTitle.Text = "TOTAL TAGIHAN"
            '
            'lblAmountValue
            '
            Me.lblAmountValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblAmountValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.lblAmountValue.Location = New System.Drawing.Point(20, 64)
            Me.lblAmountValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblAmountValue.Name = "lblAmountValue"
            Me.lblAmountValue.Size = New System.Drawing.Size(480, 43)
            Me.lblAmountValue.TabIndex = 2
            Me.lblAmountValue.Text = "Rp 0"
            Me.lblAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'picQrisCode
            '
            Me.picQrisCode.BackColor = System.Drawing.Color.White
            Me.picQrisCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picQrisCode.Location = New System.Drawing.Point(127, 117)
            Me.picQrisCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.picQrisCode.Name = "picQrisCode"
            Me.picQrisCode.Size = New System.Drawing.Size(266, 246)
            Me.picQrisCode.TabIndex = 3
            Me.picQrisCode.TabStop = False
            '
            'lblNotice
            '
            Me.lblNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
            Me.lblNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblNotice.Location = New System.Drawing.Point(20, 372)
            Me.lblNotice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblNotice.Name = "lblNotice"
            Me.lblNotice.Size = New System.Drawing.Size(480, 43)
            Me.lblNotice.TabIndex = 4
            Me.lblNotice.Text = "Scan QRIS di atas menggunakan m-Banking atau E-Wallet (Gopay, OVO, Dana, ShopeePa" &
    "y, LinkAja)."
            Me.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnConfirm
            '
            Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnConfirm.FlatAppearance.BorderSize = 0
            Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnConfirm.ForeColor = System.Drawing.Color.White
            Me.btnConfirm.Location = New System.Drawing.Point(20, 431)
            Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnConfirm.Name = "btnConfirm"
            Me.btnConfirm.Size = New System.Drawing.Size(480, 52)
            Me.btnConfirm.TabIndex = 5
            Me.btnConfirm.Text = "Konfirmasi Sudah Bayar"
            Me.btnConfirm.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(20, 492)
            Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(480, 43)
            Me.btnCancel.TabIndex = 6
            Me.btnCancel.Text = "Batal Pembayaran"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'QrisPaymentForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(560, 665)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "QrisPaymentForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Pembayaran QRIS"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlCard.ResumeLayout(False)
            Me.pnlCard.PerformLayout()
            CType(Me.picQrisCode, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlCard As System.Windows.Forms.Panel
        Friend WithEvents lblTransactionTitle As System.Windows.Forms.Label
        Friend WithEvents lblAmountTitle As System.Windows.Forms.Label
        Friend WithEvents lblAmountValue As System.Windows.Forms.Label
        Friend WithEvents picQrisCode As System.Windows.Forms.PictureBox
        Friend WithEvents lblNotice As System.Windows.Forms.Label
        Friend WithEvents btnConfirm As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
    End Class
End Namespace