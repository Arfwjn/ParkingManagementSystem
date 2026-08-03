Imports System.Windows.Forms

Namespace Views
    Partial Class ExitForm
        Inherits Form

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
            Me.btnSearch = New Button()
            Me.grpRincian = New GroupBox()
            Me.lblDiscountVal = New Label()
            Me.lblDiscountTitle = New Label()
            Me.lblOvernightVal = New Label()
            Me.lblOvernightTitle = New Label()
            Me.lblFineVal = New Label()
            Me.lblFineTitle = New Label()
            Me.lblBaseFeeVal = New Label()
            Me.lblBaseFeeTitle = New Label()
            Me.lblDurationVal = New Label()
            Me.lblDurationTitle = New Label()
            Me.lblEntryTimeVal = New Label()
            Me.lblEntryTimeTitle = New Label()
            Me.lblTypeVal = New Label()
            Me.lblTypeTitle = New Label()
            Me.chkLostTicket = New CheckBox()
            Me.lblTotalPay = New Label()
            Me.lblTotalPayTitle = New Label()
            Me.lblPaymentMethod = New Label()
            Me.cmbPaymentMethod = New ComboBox()
            Me.btnProcessPayment = New Button()
            Me.btnClose = New Button()
            Me.lblMemberInfo = New Label()
            Me.grpRincian.SuspendLayout()
            Me.SuspendLayout()
            '
            ' lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.Location = New System.Drawing.Point(25, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(248, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "KENDARAAN KELUAR & BAYAR"
            '
            ' lblPlateNumber
            '
            Me.lblPlateNumber.AutoSize = True
            Me.lblPlateNumber.Location = New System.Drawing.Point(25, 50)
            Me.lblPlateNumber.Name = "lblPlateNumber"
            Me.lblPlateNumber.Size = New System.Drawing.Size(76, 15)
            Me.lblPlateNumber.TabIndex = 1
            Me.lblPlateNumber.Text = "Nomor Polisi:"
            '
            ' txtPlateNumber
            '
            Me.txtPlateNumber.CharacterCasing = CharacterCasing.Upper
            Me.txtPlateNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtPlateNumber.Location = New System.Drawing.Point(28, 68)
            Me.txtPlateNumber.Name = "txtPlateNumber"
            Me.txtPlateNumber.Size = New System.Drawing.Size(220, 25)
            Me.txtPlateNumber.TabIndex = 2
            '
            ' btnSearch
            '
            Me.btnSearch.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnSearch.FlatStyle = FlatStyle.Flat
            Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnSearch.ForeColor = System.Drawing.Color.White
            Me.btnSearch.Location = New System.Drawing.Point(255, 67)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(100, 27)
            Me.btnSearch.TabIndex = 3
            Me.btnSearch.Text = "CARI"
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            ' grpRincian
            '
            Me.grpRincian.Controls.Add(Me.lblDiscountVal)
            Me.grpRincian.Controls.Add(Me.lblDiscountTitle)
            Me.grpRincian.Controls.Add(Me.lblOvernightVal)
            Me.grpRincian.Controls.Add(Me.lblOvernightTitle)
            Me.grpRincian.Controls.Add(Me.lblFineVal)
            Me.grpRincian.Controls.Add(Me.lblFineTitle)
            Me.grpRincian.Controls.Add(Me.lblBaseFeeVal)
            Me.grpRincian.Controls.Add(Me.lblBaseFeeTitle)
            Me.grpRincian.Controls.Add(Me.lblDurationVal)
            Me.grpRincian.Controls.Add(Me.lblDurationTitle)
            Me.grpRincian.Controls.Add(Me.lblEntryTimeVal)
            Me.grpRincian.Controls.Add(Me.lblEntryTimeTitle)
            Me.grpRincian.Controls.Add(Me.lblTypeVal)
            Me.grpRincian.Controls.Add(Me.lblTypeTitle)
            Me.grpRincian.Location = New System.Drawing.Point(28, 125)
            Me.grpRincian.Name = "grpRincian"
            Me.grpRincian.Size = New System.Drawing.Size(327, 210)
            Me.grpRincian.TabIndex = 4
            Me.grpRincian.TabStop = False
            Me.grpRincian.Text = "Rincian Transaksi"
            '
            ' lblTypeTitle
            '
            Me.lblTypeTitle.AutoSize = True
            Me.lblTypeTitle.Location = New System.Drawing.Point(15, 25)
            Me.lblTypeTitle.Name = "lblTypeTitle"
            Me.lblTypeTitle.Size = New System.Drawing.Size(91, 15)
            Me.lblTypeTitle.Text = "Jenis Kendaraan:"
            '
            ' lblTypeVal
            '
            Me.lblTypeVal.AutoSize = True
            Me.lblTypeVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblTypeVal.Location = New System.Drawing.Point(140, 25)
            Me.lblTypeVal.Name = "lblTypeVal"
            Me.lblTypeVal.Size = New System.Drawing.Size(12, 15)
            Me.lblTypeVal.Text = "-"
            '
            ' lblEntryTimeTitle
            '
            Me.lblEntryTimeTitle.AutoSize = True
            Me.lblEntryTimeTitle.Location = New System.Drawing.Point(15, 50)
            Me.lblEntryTimeTitle.Name = "lblEntryTimeTitle"
            Me.lblEntryTimeTitle.Size = New System.Drawing.Size(81, 15)
            Me.lblEntryTimeTitle.Text = "Waktu Masuk:"
            '
            ' lblEntryTimeVal
            '
            Me.lblEntryTimeVal.AutoSize = True
            Me.lblEntryTimeVal.Location = New System.Drawing.Point(140, 50)
            Me.lblEntryTimeVal.Name = "lblEntryTimeVal"
            Me.lblEntryTimeVal.Size = New System.Drawing.Size(12, 15)
            Me.lblEntryTimeVal.Text = "-"
            '
            ' lblDurationTitle
            '
            Me.lblDurationTitle.AutoSize = True
            Me.lblDurationTitle.Location = New System.Drawing.Point(15, 75)
            Me.lblDurationTitle.Name = "lblDurationTitle"
            Me.lblDurationTitle.Text = "Durasi Parkir:"
            '
            ' lblDurationVal
            '
            Me.lblDurationVal.AutoSize = True
            Me.lblDurationVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblDurationVal.Location = New System.Drawing.Point(140, 75)
            Me.lblDurationVal.Name = "lblDurationVal"
            Me.lblDurationVal.Size = New System.Drawing.Size(12, 15)
            Me.lblDurationVal.Text = "-"
            '
            ' lblBaseFeeTitle
            '
            Me.lblBaseFeeTitle.AutoSize = True
            Me.lblBaseFeeTitle.Location = New System.Drawing.Point(15, 100)
            Me.lblBaseFeeTitle.Name = "lblBaseFeeTitle"
            Me.lblBaseFeeTitle.Text = "Tarif Parkir:"
            '
            ' lblBaseFeeVal
            '
            Me.lblBaseFeeVal.AutoSize = True
            Me.lblBaseFeeVal.Location = New System.Drawing.Point(140, 100)
            Me.lblBaseFeeVal.Name = "lblBaseFeeVal"
            Me.lblBaseFeeVal.Size = New System.Drawing.Size(12, 15)
            Me.lblBaseFeeVal.Text = "Rp 0"
            '
            ' lblFineTitle
            '
            Me.lblFineTitle.AutoSize = True
            Me.lblFineTitle.Location = New System.Drawing.Point(15, 125)
            Me.lblFineTitle.Name = "lblFineTitle"
            Me.lblFineTitle.Text = "Denda Karcis:"
            '
            ' lblFineVal
            '
            Me.lblFineVal.AutoSize = True
            Me.lblFineVal.ForeColor = System.Drawing.Color.Red
            Me.lblFineVal.Location = New System.Drawing.Point(140, 125)
            Me.lblFineVal.Name = "lblFineVal"
            Me.lblFineVal.Size = New System.Drawing.Size(12, 15)
            Me.lblFineVal.Text = "Rp 0"
            '
            ' lblOvernightTitle
            '
            Me.lblOvernightTitle.AutoSize = True
            Me.lblOvernightTitle.Location = New System.Drawing.Point(15, 150)
            Me.lblOvernightTitle.Name = "lblOvernightTitle"
            Me.lblOvernightTitle.Text = "Biaya Menginap:"
            '
            ' lblOvernightVal
            '
            Me.lblOvernightVal.AutoSize = True
            Me.lblOvernightVal.Location = New System.Drawing.Point(140, 150)
            Me.lblOvernightVal.Name = "lblOvernightVal"
            Me.lblOvernightVal.Size = New System.Drawing.Size(12, 15)
            Me.lblOvernightVal.Text = "Rp 0"
            '
            ' lblDiscountTitle
            '
            Me.lblDiscountTitle.AutoSize = True
            Me.lblDiscountTitle.Location = New System.Drawing.Point(15, 175)
            Me.lblDiscountTitle.Name = "lblDiscountTitle"
            Me.lblDiscountTitle.Text = "Diskon Member:"
            '
            ' lblDiscountVal
            '
            Me.lblDiscountVal.AutoSize = True
            Me.lblDiscountVal.ForeColor = System.Drawing.Color.Green
            Me.lblDiscountVal.Location = New System.Drawing.Point(140, 175)
            Me.lblDiscountVal.Name = "lblDiscountVal"
            Me.lblDiscountVal.Size = New System.Drawing.Size(12, 15)
            Me.lblDiscountVal.Text = "Rp 0"
            '
            ' chkLostTicket
            '
            Me.chkLostTicket.AutoSize = True
            Me.chkLostTicket.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.chkLostTicket.ForeColor = System.Drawing.Color.DarkRed
            Me.chkLostTicket.Location = New System.Drawing.Point(28, 100)
            Me.chkLostTicket.Name = "chkLostTicket"
            Me.chkLostTicket.Size = New System.Drawing.Size(130, 19)
            Me.chkLostTicket.TabIndex = 5
            Me.chkLostTicket.Text = "Karcis Hilang (Denda)"
            Me.chkLostTicket.UseVisualStyleBackColor = True
            '
            ' lblMemberInfo
            '
            Me.lblMemberInfo.AutoSize = True
            Me.lblMemberInfo.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Italic)
            Me.lblMemberInfo.ForeColor = System.Drawing.Color.Blue
            Me.lblMemberInfo.Location = New System.Drawing.Point(25, 340)
            Me.lblMemberInfo.Name = "lblMemberInfo"
            Me.lblMemberInfo.Size = New System.Drawing.Size(0, 13)
            Me.lblMemberInfo.TabIndex = 6
            '
            ' lblTotalPayTitle
            '
            Me.lblTotalPayTitle.AutoSize = True
            Me.lblTotalPayTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalPayTitle.Location = New System.Drawing.Point(25, 360)
            Me.lblTotalPayTitle.Name = "lblTotalPayTitle"
            Me.lblTotalPayTitle.Size = New System.Drawing.Size(107, 20)
            Me.lblTotalPayTitle.TabIndex = 7
            Me.lblTotalPayTitle.Text = "TOTAL BAYAR:"
            '
            ' lblTotalPay
            '
            Me.lblTotalPay.AutoSize = True
            Me.lblTotalPay.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalPay.ForeColor = System.Drawing.Color.DarkGreen
            Me.lblTotalPay.Location = New System.Drawing.Point(145, 355)
            Me.lblTotalPay.Name = "lblTotalPay"
            Me.lblTotalPay.Size = New System.Drawing.Size(58, 30)
            Me.lblTotalPay.TabIndex = 8
            Me.lblTotalPay.Text = "Rp 0"
            '
            ' lblPaymentMethod
            '
            Me.lblPaymentMethod.AutoSize = True
            Me.lblPaymentMethod.Location = New System.Drawing.Point(25, 400)
            Me.lblPaymentMethod.Name = "lblPaymentMethod"
            Me.lblPaymentMethod.Size = New System.Drawing.Size(123, 15)
            Me.lblPaymentMethod.TabIndex = 9
            Me.lblPaymentMethod.Text = "Metode Pembayaran:"
            '
            ' cmbPaymentMethod
            '
            Me.cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cmbPaymentMethod.FormattingEnabled = True
            Me.cmbPaymentMethod.Items.AddRange(New Object() {"Tunai", "QRIS", "Debit"})
            Me.cmbPaymentMethod.Location = New System.Drawing.Point(155, 395)
            Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
            Me.cmbPaymentMethod.Size = New System.Drawing.Size(200, 25)
            Me.cmbPaymentMethod.TabIndex = 10
            '
            ' btnProcessPayment
            '
            Me.btnProcessPayment.BackColor = System.Drawing.Color.SeaGreen
            Me.btnProcessPayment.FlatStyle = FlatStyle.Flat
            Me.btnProcessPayment.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnProcessPayment.ForeColor = System.Drawing.Color.White
            Me.btnProcessPayment.Location = New System.Drawing.Point(28, 435)
            Me.btnProcessPayment.Name = "btnProcessPayment"
            Me.btnProcessPayment.Size = New System.Drawing.Size(200, 40)
            Me.btnProcessPayment.TabIndex = 11
            Me.btnProcessPayment.Text = "PROSES PEMBAYARAN"
            Me.btnProcessPayment.UseVisualStyleBackColor = False
            '
            ' btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Gray
            Me.btnClose.FlatStyle = FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.Location = New System.Drawing.Point(235, 435)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(120, 40)
            Me.btnClose.TabIndex = 12
            Me.btnClose.Text = "BATAL"
            Me.btnClose.UseVisualStyleBackColor = False
            '
            ' ExitForm
            '
            Me.ClientSize = New System.Drawing.Size(385, 495)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnProcessPayment)
            Me.Controls.Add(Me.cmbPaymentMethod)
            Me.Controls.Add(Me.lblPaymentMethod)
            Me.Controls.Add(Me.lblTotalPay)
            Me.Controls.Add(Me.lblTotalPayTitle)
            Me.Controls.Add(Me.lblMemberInfo)
            Me.Controls.Add(Me.chkLostTicket)
            Me.Controls.Add(Me.grpRincian)
            Me.Controls.Add(Me.btnSearch)
            Me.Controls.Add(Me.txtPlateNumber)
            Me.Controls.Add(Me.lblPlateNumber)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "ExitForm"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Parking App - Exit System"
            Me.grpRincian.ResumeLayout(False)
            Me.grpRincian.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents lblPlateNumber As Label
        Friend WithEvents txtPlateNumber As TextBox
        Friend WithEvents btnSearch As Button
        Friend WithEvents grpRincian As GroupBox
        Friend WithEvents lblTypeTitle As Label
        Friend WithEvents lblTypeVal As Label
        Friend WithEvents lblEntryTimeTitle As Label
        Friend WithEvents lblEntryTimeVal As Label
        Friend WithEvents lblDurationTitle As Label
        Friend WithEvents lblDurationVal As Label
        Friend WithEvents lblBaseFeeTitle As Label
        Friend WithEvents lblBaseFeeVal As Label
        Friend WithEvents lblFineTitle As Label
        Friend WithEvents lblFineVal As Label
        Friend WithEvents lblOvernightTitle As Label
        Friend WithEvents lblOvernightVal As Label
        Friend WithEvents lblDiscountTitle As Label
        Friend WithEvents lblDiscountVal As Label
        Friend WithEvents chkLostTicket As CheckBox
        Friend WithEvents lblMemberInfo As Label
        Friend WithEvents lblTotalPayTitle As Label
        Friend WithEvents lblTotalPay As Label
        Friend WithEvents lblPaymentMethod As Label
        Friend WithEvents cmbPaymentMethod As ComboBox
        Friend WithEvents btnProcessPayment As Button
        Friend WithEvents btnClose As Button
    End Class
End Namespace