Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ExitForm
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
            Me.pnlPaymentCard = New System.Windows.Forms.Panel()
            Me.btnProcessPayment = New System.Windows.Forms.Button()
            Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
            Me.lblPaymentMethod = New System.Windows.Forms.Label()
            Me.lblTotalPay = New System.Windows.Forms.Label()
            Me.lblTotalPayTitle = New System.Windows.Forms.Label()
            Me.pnlDetailsCard = New System.Windows.Forms.Panel()
            Me.lblMemberInfo = New System.Windows.Forms.Label()
            Me.lblDiscountVal = New System.Windows.Forms.Label()
            Me.lblDiscountTitle = New System.Windows.Forms.Label()
            Me.lblOvernightVal = New System.Windows.Forms.Label()
            Me.lblOvernightTitle = New System.Windows.Forms.Label()
            Me.lblFineVal = New System.Windows.Forms.Label()
            Me.lblFineTitle = New System.Windows.Forms.Label()
            Me.lblBaseFeeVal = New System.Windows.Forms.Label()
            Me.lblBaseFeeTitle = New System.Windows.Forms.Label()
            Me.lblDurationVal = New System.Windows.Forms.Label()
            Me.lblDurationTitle = New System.Windows.Forms.Label()
            Me.lblEntryTimeVal = New System.Windows.Forms.Label()
            Me.lblEntryTimeTitle = New System.Windows.Forms.Label()
            Me.lblTypeVal = New System.Windows.Forms.Label()
            Me.lblTypeTitle = New System.Windows.Forms.Label()
            Me.pnlSearchCard = New System.Windows.Forms.Panel()
            Me.chkLostTicket = New System.Windows.Forms.CheckBox()
            Me.btnSearch = New System.Windows.Forms.Button()
            Me.txtPlateNumber = New System.Windows.Forms.TextBox()
            Me.lblPlateNumber = New System.Windows.Forms.Label()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlPaymentCard.SuspendLayout()
            Me.pnlDetailsCard.SuspendLayout()
            Me.pnlSearchCard.SuspendLayout()
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
            Me.pnlHeader.Size = New System.Drawing.Size(680, 60)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(20, 18)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(288, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Registrasi Parkir Keluar && Pembayaran"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(633, 12)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(35, 35)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "X"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.pnlMain.Controls.Add(Me.pnlPaymentCard)
            Me.pnlMain.Controls.Add(Me.pnlDetailsCard)
            Me.pnlMain.Controls.Add(Me.pnlSearchCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 60)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
            Me.pnlMain.Size = New System.Drawing.Size(680, 560)
            Me.pnlMain.TabIndex = 1
            '
            'pnlPaymentCard
            '
            Me.pnlPaymentCard.BackColor = System.Drawing.Color.White
            Me.pnlPaymentCard.Controls.Add(Me.btnProcessPayment)
            Me.pnlPaymentCard.Controls.Add(Me.cmbPaymentMethod)
            Me.pnlPaymentCard.Controls.Add(Me.lblPaymentMethod)
            Me.pnlPaymentCard.Controls.Add(Me.lblTotalPay)
            Me.pnlPaymentCard.Controls.Add(Me.lblTotalPayTitle)
            Me.pnlPaymentCard.Location = New System.Drawing.Point(350, 115)
            Me.pnlPaymentCard.Name = "pnlPaymentCard"
            Me.pnlPaymentCard.Size = New System.Drawing.Size(310, 420)
            Me.pnlPaymentCard.TabIndex = 2
            '
            'btnProcessPayment
            '
            Me.btnProcessPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnProcessPayment.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnProcessPayment.FlatAppearance.BorderSize = 0
            Me.btnProcessPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnProcessPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
            Me.btnProcessPayment.ForeColor = System.Drawing.Color.White
            Me.btnProcessPayment.Location = New System.Drawing.Point(20, 340)
            Me.btnProcessPayment.Name = "btnProcessPayment"
            Me.btnProcessPayment.Size = New System.Drawing.Size(270, 50)
            Me.btnProcessPayment.TabIndex = 4
            Me.btnProcessPayment.Text = "Proses Pembayaran"
            Me.btnProcessPayment.UseVisualStyleBackColor = False
            '
            'cmbPaymentMethod
            '
            Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 10.5!)
            Me.cmbPaymentMethod.FormattingEnabled = True
            Me.cmbPaymentMethod.Items.AddRange(New Object() {"Tunai", "QRIS", "Transfer / Debit"})
            Me.cmbPaymentMethod.Location = New System.Drawing.Point(20, 245)
            Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
            Me.cmbPaymentMethod.Size = New System.Drawing.Size(270, 27)
            Me.cmbPaymentMethod.TabIndex = 3
            '
            'lblPaymentMethod
            '
            Me.lblPaymentMethod.AutoSize = True
            Me.lblPaymentMethod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPaymentMethod.Location = New System.Drawing.Point(17, 220)
            Me.lblPaymentMethod.Name = "lblPaymentMethod"
            Me.lblPaymentMethod.Size = New System.Drawing.Size(133, 17)
            Me.lblPaymentMethod.TabIndex = 2
            Me.lblPaymentMethod.Text = "Metode Pembayaran"
            '
            'lblTotalPay
            '
            Me.lblTotalPay.AutoSize = True
            Me.lblTotalPay.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.lblTotalPay.Location = New System.Drawing.Point(15, 75)
            Me.lblTotalPay.Name = "lblTotalPay"
            Me.lblTotalPay.Size = New System.Drawing.Size(81, 40)
            Me.lblTotalPay.TabIndex = 1
            Me.lblTotalPay.Text = "Rp 0"
            '
            'lblTotalPayTitle
            '
            Me.lblTotalPayTitle.AutoSize = True
            Me.lblTotalPayTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalPayTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalPayTitle.Location = New System.Drawing.Point(18, 40)
            Me.lblTotalPayTitle.Name = "lblTotalPayTitle"
            Me.lblTotalPayTitle.Size = New System.Drawing.Size(149, 19)
            Me.lblTotalPayTitle.TabIndex = 0
            Me.lblTotalPayTitle.Text = "Total Harus Dibayar"
            '
            'pnlDetailsCard
            '
            Me.pnlDetailsCard.BackColor = System.Drawing.Color.White
            Me.pnlDetailsCard.Controls.Add(Me.lblMemberInfo)
            Me.pnlDetailsCard.Controls.Add(Me.lblDiscountVal)
            Me.pnlDetailsCard.Controls.Add(Me.lblDiscountTitle)
            Me.pnlDetailsCard.Controls.Add(Me.lblOvernightVal)
            Me.pnlDetailsCard.Controls.Add(Me.lblOvernightTitle)
            Me.pnlDetailsCard.Controls.Add(Me.lblFineVal)
            Me.pnlDetailsCard.Controls.Add(Me.lblFineTitle)
            Me.pnlDetailsCard.Controls.Add(Me.lblBaseFeeVal)
            Me.pnlDetailsCard.Controls.Add(Me.lblBaseFeeTitle)
            Me.pnlDetailsCard.Controls.Add(Me.lblDurationVal)
            Me.pnlDetailsCard.Controls.Add(Me.lblDurationTitle)
            Me.pnlDetailsCard.Controls.Add(Me.lblEntryTimeVal)
            Me.pnlDetailsCard.Controls.Add(Me.lblEntryTimeTitle)
            Me.pnlDetailsCard.Controls.Add(Me.lblTypeVal)
            Me.pnlDetailsCard.Controls.Add(Me.lblTypeTitle)
            Me.pnlDetailsCard.Location = New System.Drawing.Point(20, 115)
            Me.pnlDetailsCard.Name = "pnlDetailsCard"
            Me.pnlDetailsCard.Size = New System.Drawing.Size(315, 420)
            Me.pnlDetailsCard.TabIndex = 1
            '
            'lblMemberInfo
            '
            Me.lblMemberInfo.Font = New System.Drawing.Font("Segoe UI Italic", 8.5!)
            Me.lblMemberInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.lblMemberInfo.Location = New System.Drawing.Point(20, 375)
            Me.lblMemberInfo.Name = "lblMemberInfo"
            Me.lblMemberInfo.Size = New System.Drawing.Size(275, 30)
            Me.lblMemberInfo.TabIndex = 14
            '
            'lblDiscountVal
            '
            Me.lblDiscountVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblDiscountVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.lblDiscountVal.Location = New System.Drawing.Point(150, 325)
            Me.lblDiscountVal.Name = "lblDiscountVal"
            Me.lblDiscountVal.Size = New System.Drawing.Size(145, 20)
            Me.lblDiscountVal.TabIndex = 13
            Me.lblDiscountVal.Text = "Rp 0"
            Me.lblDiscountVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblDiscountTitle
            '
            Me.lblDiscountTitle.AutoSize = True
            Me.lblDiscountTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblDiscountTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblDiscountTitle.Location = New System.Drawing.Point(20, 325)
            Me.lblDiscountTitle.Name = "lblDiscountTitle"
            Me.lblDiscountTitle.Size = New System.Drawing.Size(95, 17)
            Me.lblDiscountTitle.TabIndex = 12
            Me.lblDiscountTitle.Text = "Diskon Member"
            '
            'lblOvernightVal
            '
            Me.lblOvernightVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblOvernightVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.lblOvernightVal.Location = New System.Drawing.Point(150, 275)
            Me.lblOvernightVal.Name = "lblOvernightVal"
            Me.lblOvernightVal.Size = New System.Drawing.Size(145, 20)
            Me.lblOvernightVal.TabIndex = 11
            Me.lblOvernightVal.Text = "Rp 0"
            Me.lblOvernightVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblOvernightTitle
            '
            Me.lblOvernightTitle.AutoSize = True
            Me.lblOvernightTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblOvernightTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblOvernightTitle.Location = New System.Drawing.Point(20, 275)
            Me.lblOvernightTitle.Name = "lblOvernightTitle"
            Me.lblOvernightTitle.Size = New System.Drawing.Size(93, 17)
            Me.lblOvernightTitle.TabIndex = 10
            Me.lblOvernightTitle.Text = "Biaya Inap/Mlm"
            '
            'lblFineVal
            '
            Me.lblFineVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblFineVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblFineVal.Location = New System.Drawing.Point(150, 225)
            Me.lblFineVal.Name = "lblFineVal"
            Me.lblFineVal.Size = New System.Drawing.Size(145, 20)
            Me.lblFineVal.TabIndex = 9
            Me.lblFineVal.Text = "Rp 0"
            Me.lblFineVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblFineTitle
            '
            Me.lblFineTitle.AutoSize = True
            Me.lblFineTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblFineTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblFineTitle.Location = New System.Drawing.Point(20, 225)
            Me.lblFineTitle.Name = "lblFineTitle"
            Me.lblFineTitle.Size = New System.Drawing.Size(123, 17)
            Me.lblFineTitle.TabIndex = 8
            Me.lblFineTitle.Text = "Denda Tiket Hilang"
            '
            'lblBaseFeeVal
            '
            Me.lblBaseFeeVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblBaseFeeVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.lblBaseFeeVal.Location = New System.Drawing.Point(150, 175)
            Me.lblBaseFeeVal.Name = "lblBaseFeeVal"
            Me.lblBaseFeeVal.Size = New System.Drawing.Size(145, 20)
            Me.lblBaseFeeVal.TabIndex = 7
            Me.lblBaseFeeVal.Text = "Rp 0"
            Me.lblBaseFeeVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblBaseFeeTitle
            '
            Me.lblBaseFeeTitle.AutoSize = True
            Me.lblBaseFeeTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblBaseFeeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblBaseFeeTitle.Location = New System.Drawing.Point(20, 175)
            Me.lblBaseFeeTitle.Name = "lblBaseFeeTitle"
            Me.lblBaseFeeTitle.Size = New System.Drawing.Size(107, 17)
            Me.lblBaseFeeTitle.TabIndex = 6
            Me.lblBaseFeeTitle.Text = "Tarif Parkir Dasar"
            '
            'lblDurationVal
            '
            Me.lblDurationVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblDurationVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.lblDurationVal.Location = New System.Drawing.Point(150, 125)
            Me.lblDurationVal.Name = "lblDurationVal"
            Me.lblDurationVal.Size = New System.Drawing.Size(145, 20)
            Me.lblDurationVal.TabIndex = 5
            Me.lblDurationVal.Text = "-"
            Me.lblDurationVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblDurationTitle
            '
            Me.lblDurationTitle.AutoSize = True
            Me.lblDurationTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblDurationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblDurationTitle.Location = New System.Drawing.Point(20, 125)
            Me.lblDurationTitle.Name = "lblDurationTitle"
            Me.lblDurationTitle.Size = New System.Drawing.Size(83, 17)
            Me.lblDurationTitle.TabIndex = 4
            Me.lblDurationTitle.Text = "Durasi Parkir"
            '
            'lblEntryTimeVal
            '
            Me.lblEntryTimeVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblEntryTimeVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.lblEntryTimeVal.Location = New System.Drawing.Point(120, 75)
            Me.lblEntryTimeVal.Name = "lblEntryTimeVal"
            Me.lblEntryTimeVal.Size = New System.Drawing.Size(175, 20)
            Me.lblEntryTimeVal.TabIndex = 3
            Me.lblEntryTimeVal.Text = "-"
            Me.lblEntryTimeVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblEntryTimeTitle
            '
            Me.lblEntryTimeTitle.AutoSize = True
            Me.lblEntryTimeTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblEntryTimeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblEntryTimeTitle.Location = New System.Drawing.Point(20, 75)
            Me.lblEntryTimeTitle.Name = "lblEntryTimeTitle"
            Me.lblEntryTimeTitle.Size = New System.Drawing.Size(84, 17)
            Me.lblEntryTimeTitle.TabIndex = 2
            Me.lblEntryTimeTitle.Text = "Waktu Masuk"
            '
            'lblTypeVal
            '
            Me.lblTypeVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblTypeVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.lblTypeVal.Location = New System.Drawing.Point(150, 25)
            Me.lblTypeVal.Name = "lblTypeVal"
            Me.lblTypeVal.Size = New System.Drawing.Size(145, 20)
            Me.lblTypeVal.TabIndex = 1
            Me.lblTypeVal.Text = "-"
            Me.lblTypeVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblTypeTitle
            '
            Me.lblTypeTitle.AutoSize = True
            Me.lblTypeTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblTypeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTypeTitle.Location = New System.Drawing.Point(20, 25)
            Me.lblTypeTitle.Name = "lblTypeTitle"
            Me.lblTypeTitle.Size = New System.Drawing.Size(104, 17)
            Me.lblTypeTitle.TabIndex = 0
            Me.lblTypeTitle.Text = "Jenis Kendaraan"
            '
            'pnlSearchCard
            '
            Me.pnlSearchCard.BackColor = System.Drawing.Color.White
            Me.pnlSearchCard.Controls.Add(Me.chkLostTicket)
            Me.pnlSearchCard.Controls.Add(Me.btnSearch)
            Me.pnlSearchCard.Controls.Add(Me.txtPlateNumber)
            Me.pnlSearchCard.Controls.Add(Me.lblPlateNumber)
            Me.pnlSearchCard.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSearchCard.Location = New System.Drawing.Point(20, 20)
            Me.pnlSearchCard.Name = "pnlSearchCard"
            Me.pnlSearchCard.Size = New System.Drawing.Size(640, 80)
            Me.pnlSearchCard.TabIndex = 0
            '
            'chkLostTicket
            '
            Me.chkLostTicket.AutoSize = True
            Me.chkLostTicket.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkLostTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.chkLostTicket.Location = New System.Drawing.Point(495, 30)
            Me.chkLostTicket.Name = "chkLostTicket"
            Me.chkLostTicket.Size = New System.Drawing.Size(91, 19)
            Me.chkLostTicket.TabIndex = 3
            Me.chkLostTicket.Text = "Tiket Hilang?"
            Me.chkLostTicket.UseVisualStyleBackColor = True
            '
            'btnSearch
            '
            Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSearch.FlatAppearance.BorderSize = 0
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSearch.ForeColor = System.Drawing.Color.White
            Me.btnSearch.Location = New System.Drawing.Point(365, 25)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(110, 30)
            Me.btnSearch.TabIndex = 2
            Me.btnSearch.Text = "Cari Data"
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            'txtPlateNumber
            '
            Me.txtPlateNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPlateNumber.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.txtPlateNumber.Location = New System.Drawing.Point(140, 26)
            Me.txtPlateNumber.Name = "txtPlateNumber"
            Me.txtPlateNumber.Size = New System.Drawing.Size(210, 27)
            Me.txtPlateNumber.TabIndex = 1
            '
            'lblPlateNumber
            '
            Me.lblPlateNumber.AutoSize = True
            Me.lblPlateNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblPlateNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPlateNumber.Location = New System.Drawing.Point(20, 30)
            Me.lblPlateNumber.Name = "lblPlateNumber"
            Me.lblPlateNumber.Size = New System.Drawing.Size(107, 17)
            Me.lblPlateNumber.TabIndex = 0
            Me.lblPlateNumber.Text = "Cari Plat Nomor:"
            '
            'ExitForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(680, 620)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "ExitForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Registrasi Parkir Keluar & Pembayaran"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlPaymentCard.ResumeLayout(False)
            Me.pnlPaymentCard.PerformLayout()
            Me.pnlDetailsCard.ResumeLayout(False)
            Me.pnlDetailsCard.PerformLayout()
            Me.pnlSearchCard.ResumeLayout(False)
            Me.pnlSearchCard.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlSearchCard As System.Windows.Forms.Panel
        Friend WithEvents lblPlateNumber As System.Windows.Forms.Label
        Friend WithEvents txtPlateNumber As System.Windows.Forms.TextBox
        Friend WithEvents btnSearch As System.Windows.Forms.Button
        Friend WithEvents chkLostTicket As System.Windows.Forms.CheckBox
        Friend WithEvents pnlDetailsCard As System.Windows.Forms.Panel
        Friend WithEvents lblTypeTitle As System.Windows.Forms.Label
        Friend WithEvents lblTypeVal As System.Windows.Forms.Label
        Friend WithEvents lblEntryTimeTitle As System.Windows.Forms.Label
        Friend WithEvents lblEntryTimeVal As System.Windows.Forms.Label
        Friend WithEvents lblDurationTitle As System.Windows.Forms.Label
        Friend WithEvents lblDurationVal As System.Windows.Forms.Label
        Friend WithEvents lblBaseFeeTitle As System.Windows.Forms.Label
        Friend WithEvents lblBaseFeeVal As System.Windows.Forms.Label
        Friend WithEvents lblFineTitle As System.Windows.Forms.Label
        Friend WithEvents lblFineVal As System.Windows.Forms.Label
        Friend WithEvents lblOvernightTitle As System.Windows.Forms.Label
        Friend WithEvents lblOvernightVal As System.Windows.Forms.Label
        Friend WithEvents lblDiscountTitle As System.Windows.Forms.Label
        Friend WithEvents lblDiscountVal As System.Windows.Forms.Label
        Friend WithEvents lblMemberInfo As System.Windows.Forms.Label
        Friend WithEvents pnlPaymentCard As System.Windows.Forms.Panel
        Friend WithEvents lblTotalPayTitle As System.Windows.Forms.Label
        Friend WithEvents lblTotalPay As System.Windows.Forms.Label
        Friend WithEvents lblPaymentMethod As System.Windows.Forms.Label
        Friend WithEvents cmbPaymentMethod As System.Windows.Forms.ComboBox
        Friend WithEvents btnProcessPayment As System.Windows.Forms.Button
    End Class
End Namespace