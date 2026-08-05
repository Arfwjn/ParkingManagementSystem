Imports System.Security.Policy

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentSettingForm
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
        Me.pnlQrisCard = New System.Windows.Forms.Panel()
        Me.lblQrisCardTitle = New System.Windows.Forms.Label()
        Me.lblQrisMerchant = New System.Windows.Forms.Label()
        Me.txtQrisMerchant = New System.Windows.Forms.TextBox()
        Me.lblQrisNmid = New System.Windows.Forms.Label()
        Me.txtQrisNmid = New System.Windows.Forms.TextBox()
        Me.lblQrisImage = New System.Windows.Forms.Label()
        Me.txtQrisImagePath = New System.Windows.Forms.TextBox()
        Me.btnBrowseQris = New System.Windows.Forms.Button()
        Me.picQrisPreview = New System.Windows.Forms.PictureBox()
        Me.pnlDebitCard = New System.Windows.Forms.Panel()
        Me.lblDebitCardTitle = New System.Windows.Forms.Label()
        Me.lblBankName = New System.Windows.Forms.Label()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.lblAccountHolder = New System.Windows.Forms.Label()
        Me.txtAccountHolder = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlQrisCard.SuspendLayout()
        CType(Me.picQrisPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDebitCard.SuspendLayout()
        Me.SuspendLayout()

        '--- pnlHeader ---
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(520, 60)
        Me.pnlHeader.TabIndex = 0

        '--- lblTitle ---
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pengelolaan Metode Pembayaran"

        '--- btnClose ---
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(470, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True

        '--- pnlMain ---
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlQrisCard)
        Me.pnlMain.Controls.Add(Me.pnlDebitCard)
        Me.pnlMain.Controls.Add(Me.btnSave)
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMain.Size = New System.Drawing.Size(520, 560)
        Me.pnlMain.TabIndex = 1

        '--- pnlQrisCard ---
        Me.pnlQrisCard.BackColor = System.Drawing.Color.White
        Me.pnlQrisCard.Controls.Add(Me.lblQrisCardTitle)
        Me.pnlQrisCard.Controls.Add(Me.lblQrisMerchant)
        Me.pnlQrisCard.Controls.Add(Me.txtQrisMerchant)
        Me.pnlQrisCard.Controls.Add(Me.lblQrisNmid)
        Me.pnlQrisCard.Controls.Add(Me.txtQrisNmid)
        Me.pnlQrisCard.Controls.Add(Me.lblQrisImage)
        Me.pnlQrisCard.Controls.Add(Me.txtQrisImagePath)
        Me.pnlQrisCard.Controls.Add(Me.btnBrowseQris)
        Me.pnlQrisCard.Controls.Add(Me.picQrisPreview)
        Me.pnlQrisCard.Location = New System.Drawing.Point(20, 20)
        Me.pnlQrisCard.Name = "pnlQrisCard"
        Me.pnlQrisCard.Size = New System.Drawing.Size(480, 220)
        Me.pnlQrisCard.TabIndex = 0

        ' Control: Card Title QRIS
        Me.lblQrisCardTitle.AutoSize = True
        Me.lblQrisCardTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblQrisCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblQrisCardTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblQrisCardTitle.Text = "Pengaturan QRIS"

        ' Control: Nama Merchant
        Me.lblQrisMerchant.AutoSize = True
        Me.lblQrisMerchant.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblQrisMerchant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblQrisMerchant.Location = New System.Drawing.Point(15, 42)
        Me.lblQrisMerchant.Text = "Nama Merchant:"

        Me.txtQrisMerchant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQrisMerchant.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtQrisMerchant.Location = New System.Drawing.Point(18, 62)
        Me.txtQrisMerchant.Size = New System.Drawing.Size(300, 23)

        ' Control: NMID
        Me.lblQrisNmid.AutoSize = True
        Me.lblQrisNmid.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblQrisNmid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblQrisNmid.Location = New System.Drawing.Point(15, 92)
        Me.lblQrisNmid.Text = "NMID (Opsional):"

        Me.txtQrisNmid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQrisNmid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtQrisNmid.Location = New System.Drawing.Point(18, 112)
        Me.txtQrisNmid.Size = New System.Drawing.Size(300, 23)

        ' Control: Gambar QRIS
        Me.lblQrisImage.AutoSize = True
        Me.lblQrisImage.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblQrisImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblQrisImage.Location = New System.Drawing.Point(15, 142)
        Me.lblQrisImage.Text = "Gambar QRIS:"

        Me.txtQrisImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQrisImagePath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtQrisImagePath.Location = New System.Drawing.Point(18, 162)
        Me.txtQrisImagePath.ReadOnly = True
        Me.txtQrisImagePath.Size = New System.Drawing.Size(200, 23)

        Me.btnBrowseQris.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnBrowseQris.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowseQris.FlatAppearance.BorderSize = 0
        Me.btnBrowseQris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseQris.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnBrowseQris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnBrowseQris.Location = New System.Drawing.Point(225, 162)
        Me.btnBrowseQris.Size = New System.Drawing.Size(93, 23)
        Me.btnBrowseQris.Text = "PILIH..."
        Me.btnBrowseQris.UseVisualStyleBackColor = False

        ' PictureBox QR Preview
        Me.picQrisPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQrisPreview.Location = New System.Drawing.Point(335, 42)
        Me.picQrisPreview.Size = New System.Drawing.Size(130, 155)
        Me.picQrisPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        '--- pnlDebitCard ---
        Me.pnlDebitCard.BackColor = System.Drawing.Color.White
        Me.pnlDebitCard.Controls.Add(Me.lblDebitCardTitle)
        Me.pnlDebitCard.Controls.Add(Me.lblBankName)
        Me.pnlDebitCard.Controls.Add(Me.txtBankName)
        Me.pnlDebitCard.Controls.Add(Me.lblAccountNumber)
        Me.pnlDebitCard.Controls.Add(Me.txtAccountNumber)
        Me.pnlDebitCard.Controls.Add(Me.lblAccountHolder)
        Me.pnlDebitCard.Controls.Add(Me.txtAccountHolder)
        Me.pnlDebitCard.Location = New System.Drawing.Point(20, 255)
        Me.pnlDebitCard.Name = "pnlDebitCard"
        Me.pnlDebitCard.Size = New System.Drawing.Size(480, 210)
        Me.pnlDebitCard.TabIndex = 1

        ' Control: Card Title Debit
        Me.lblDebitCardTitle.AutoSize = True
        Me.lblDebitCardTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDebitCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblDebitCardTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblDebitCardTitle.Text = "Pengaturan Rekening Debit / Transfer Bank"

        ' Control: Bank Name
        Me.lblBankName.AutoSize = True
        Me.lblBankName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblBankName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblBankName.Location = New System.Drawing.Point(15, 42)
        Me.lblBankName.Text = "Nama Bank:"

        Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBankName.Location = New System.Drawing.Point(18, 62)
        Me.txtBankName.Size = New System.Drawing.Size(447, 23)

        ' Control: Account Number
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblAccountNumber.Location = New System.Drawing.Point(15, 92)
        Me.lblAccountNumber.Text = "Nomor Rekening:"

        Me.txtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAccountNumber.Location = New System.Drawing.Point(18, 112)
        Me.txtAccountNumber.Size = New System.Drawing.Size(447, 23)

        ' Control: Account Holder
        Me.lblAccountHolder.AutoSize = True
        Me.lblAccountHolder.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblAccountHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblAccountHolder.Location = New System.Drawing.Point(15, 142)
        Me.lblAccountHolder.Text = "Nama Pemilik Rekening (Atas Nama):"

        Me.txtAccountHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountHolder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAccountHolder.Location = New System.Drawing.Point(18, 162)
        Me.txtAccountHolder.Size = New System.Drawing.Size(447, 23)

        '--- btnSave ---
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(20, 485)
        Me.btnSave.Size = New System.Drawing.Size(230, 42)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SIMPAN PENGATURAN"
        Me.btnSave.UseVisualStyleBackColor = False

        '--- btnCancel ---
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(270, 485)
        Me.btnCancel.Size = New System.Drawing.Size(230, 42)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "BATAL"
        Me.btnCancel.UseVisualStyleBackColor = False

        '--- Form Settings ---
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 620)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentSettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pengelolaan Metode Pembayaran"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlQrisCard.ResumeLayout(False)
        Me.pnlQrisCard.PerformLayout()
        CType(Me.picQrisPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDebitCard.ResumeLayout(False)
        Me.pnlDebitCard.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlQrisCard As System.Windows.Forms.Panel
    Friend WithEvents lblQrisCardTitle As System.Windows.Forms.Label
    Friend WithEvents lblQrisMerchant As System.Windows.Forms.Label
    Friend WithEvents txtQrisMerchant As System.Windows.Forms.TextBox
    Friend WithEvents lblQrisNmid As System.Windows.Forms.Label
    Friend WithEvents txtQrisNmid As System.Windows.Forms.TextBox
    Friend WithEvents lblQrisImage As System.Windows.Forms.Label
    Friend WithEvents txtQrisImagePath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseQris As System.Windows.Forms.Button
    Friend WithEvents picQrisPreview As System.Windows.Forms.PictureBox
    Friend WithEvents pnlDebitCard As System.Windows.Forms.Panel
    Friend WithEvents lblDebitCardTitle As System.Windows.Forms.Label
    Friend WithEvents lblBankName As System.Windows.Forms.Label
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountNumber As System.Windows.Forms.Label
    Friend WithEvents txtAccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountHolder As System.Windows.Forms.Label
    Friend WithEvents txtAccountHolder As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class