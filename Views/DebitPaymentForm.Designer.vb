Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DebitPaymentForm
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
            Me.pnlBankInfo = New System.Windows.Forms.Panel()
            Me.lblBankTitle = New System.Windows.Forms.Label()
            Me.lblAccountNo = New System.Windows.Forms.Label()
            Me.lblAccountHolder = New System.Windows.Forms.Label()
            Me.lblCardOrRefTitle = New System.Windows.Forms.Label()
            Me.txtCardOrRefNo = New System.Windows.Forms.TextBox()
            Me.btnConfirm = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlCard.SuspendLayout()
            Me.pnlBankInfo.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(420, 55)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(20, 16)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(217, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Pembayaran Debit / Transfer"
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.pnlMain.Controls.Add(Me.pnlCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 55)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(15)
            Me.pnlMain.Size = New System.Drawing.Size(420, 425)
            Me.pnlMain.TabIndex = 1
            '
            'pnlCard
            '
            Me.pnlCard.BackColor = System.Drawing.Color.White
            Me.pnlCard.Controls.Add(Me.lblTransactionTitle)
            Me.pnlCard.Controls.Add(Me.lblAmountTitle)
            Me.pnlCard.Controls.Add(Me.lblAmountValue)
            Me.pnlCard.Controls.Add(Me.pnlBankInfo)
            Me.pnlCard.Controls.Add(Me.lblCardOrRefTitle)
            Me.pnlCard.Controls.Add(Me.txtCardOrRefNo)
            Me.pnlCard.Controls.Add(Me.btnConfirm)
            Me.pnlCard.Controls.Add(Me.btnCancel)
            Me.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCard.Location = New System.Drawing.Point(15, 15)
            Me.pnlCard.Name = "pnlCard"
            Me.pnlCard.Padding = New System.Windows.Forms.Padding(15)
            Me.pnlCard.Size = New System.Drawing.Size(390, 395)
            Me.pnlCard.TabIndex = 0
            '
            'lblTransactionTitle
            '
            Me.lblTransactionTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblTransactionTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblTransactionTitle.Location = New System.Drawing.Point(15, 10)
            Me.lblTransactionTitle.Name = "lblTransactionTitle"
            Me.lblTransactionTitle.Size = New System.Drawing.Size(360, 20)
            Me.lblTransactionTitle.TabIndex = 0
            Me.lblTransactionTitle.Text = "Pembayaran Member Parkir"
            Me.lblTransactionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblAmountTitle
            '
            Me.lblAmountTitle.AutoSize = True
            Me.lblAmountTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.lblAmountTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblAmountTitle.Location = New System.Drawing.Point(150, 35)
            Me.lblAmountTitle.Name = "lblAmountTitle"
            Me.lblAmountTitle.Size = New System.Drawing.Size(91, 15)
            Me.lblAmountTitle.TabIndex = 1
            Me.lblAmountTitle.Text = "TOTAL TAGIHAN"
            '
            'lblAmountValue
            '
            Me.lblAmountValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblAmountValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.lblAmountValue.Location = New System.Drawing.Point(15, 52)
            Me.lblAmountValue.Name = "lblAmountValue"
            Me.lblAmountValue.Size = New System.Drawing.Size(360, 35)
            Me.lblAmountValue.TabIndex = 2
            Me.lblAmountValue.Text = "Rp 0"
            Me.lblAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlBankInfo
            '
            Me.pnlBankInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.pnlBankInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlBankInfo.Controls.Add(Me.lblBankTitle)
            Me.pnlBankInfo.Controls.Add(Me.lblAccountNo)
            Me.pnlBankInfo.Controls.Add(Me.lblAccountHolder)
            Me.pnlBankInfo.Location = New System.Drawing.Point(15, 95)
            Me.pnlBankInfo.Name = "pnlBankInfo"
            Me.pnlBankInfo.Size = New System.Drawing.Size(360, 90)
            Me.pnlBankInfo.TabIndex = 3
            '
            'lblBankTitle
            '
            Me.lblBankTitle.AutoSize = True
            Me.lblBankTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblBankTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.lblBankTitle.Location = New System.Drawing.Point(12, 10)
            Me.lblBankTitle.Name = "lblBankTitle"
            Me.lblBankTitle.Size = New System.Drawing.Size(130, 15)
            Me.lblBankTitle.TabIndex = 0
            Me.lblBankTitle.Text = "Bank Mandiri / EDC"
            '
            'lblAccountNo
            '
            Me.lblAccountNo.AutoSize = True
            Me.lblAccountNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblAccountNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.lblAccountNo.Location = New System.Drawing.Point(11, 30)
            Me.lblAccountNo.Name = "lblAccountNo"
            Me.lblAccountNo.Size = New System.Drawing.Size(180, 21)
            Me.lblAccountNo.TabIndex = 1
            Me.lblAccountNo.Text = "139-00-8899-7711"
            '
            'lblAccountHolder
            '
            Me.lblAccountHolder.AutoSize = True
            Me.lblAccountHolder.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.lblAccountHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblAccountHolder.Location = New System.Drawing.Point(12, 58)
            Me.lblAccountHolder.Name = "lblAccountHolder"
            Me.lblAccountHolder.Size = New System.Drawing.Size(193, 15)
            Me.lblAccountHolder.TabIndex = 2
            Me.lblAccountHolder.Text = "a.n. PT SYSTEM MANAGEMENT PARKIR"
            '
            'lblCardOrRefTitle
            '
            Me.lblCardOrRefTitle.AutoSize = True
            Me.lblCardOrRefTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblCardOrRefTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblCardOrRefTitle.Location = New System.Drawing.Point(15, 200)
            Me.lblCardOrRefTitle.Name = "lblCardOrRefTitle"
            Me.lblCardOrRefTitle.Size = New System.Drawing.Size(201, 15)
            Me.lblCardOrRefTitle.TabIndex = 4
            Me.lblCardOrRefTitle.Text = "Nomor Kartu Debit / Ref Transaksi (*):"
            '
            'txtCardOrRefNo
            '
            Me.txtCardOrRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCardOrRefNo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtCardOrRefNo.Location = New System.Drawing.Point(15, 220)
            Me.txtCardOrRefNo.Name = "txtCardOrRefNo"
            Me.txtCardOrRefNo.Size = New System.Drawing.Size(360, 25)
            Me.txtCardOrRefNo.TabIndex = 5
            '
            'btnConfirm
            '
            Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnConfirm.FlatAppearance.BorderSize = 0
            Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnConfirm.ForeColor = System.Drawing.Color.White
            Me.btnConfirm.Location = New System.Drawing.Point(15, 280)
            Me.btnConfirm.Name = "btnConfirm"
            Me.btnConfirm.Size = New System.Drawing.Size(360, 42)
            Me.btnConfirm.TabIndex = 6
            Me.btnConfirm.Text = "Konfirmasi Pembayaran Debit"
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
            Me.btnCancel.Location = New System.Drawing.Point(15, 330)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(360, 35)
            Me.btnCancel.TabIndex = 7
            Me.btnCancel.Text = "Batal Pembayaran"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'DebitPaymentForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(420, 480)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "DebitPaymentForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Pembayaran Debit"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlCard.ResumeLayout(False)
            Me.pnlCard.PerformLayout()
            Me.pnlBankInfo.ResumeLayout(False)
            Me.pnlBankInfo.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlCard As System.Windows.Forms.Panel
        Friend WithEvents lblTransactionTitle As System.Windows.Forms.Label
        Friend WithEvents lblAmountTitle As System.Windows.Forms.Label
        Friend WithEvents lblAmountValue As System.Windows.Forms.Label
        Friend WithEvents pnlBankInfo As System.Windows.Forms.Panel
        Friend WithEvents lblBankTitle As System.Windows.Forms.Label
        Friend WithEvents lblAccountNo As System.Windows.Forms.Label
        Friend WithEvents lblAccountHolder As System.Windows.Forms.Label
        Friend WithEvents lblCardOrRefTitle As System.Windows.Forms.Label
        Friend WithEvents txtCardOrRefNo As System.Windows.Forms.TextBox
        Friend WithEvents btnConfirm As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
    End Class
End Namespace