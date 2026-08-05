Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MemberRegistrationForm
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
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.pnlFormCard = New System.Windows.Forms.Panel()
            Me.lblFormTitle = New System.Windows.Forms.Label()
            Me.lblOwnerName = New System.Windows.Forms.Label()
            Me.txtOwnerName = New System.Windows.Forms.TextBox()
            Me.lblLevel = New System.Windows.Forms.Label()
            Me.cmbLevel = New System.Windows.Forms.ComboBox()
            Me.lblPlate1 = New System.Windows.Forms.Label()
            Me.txtPlate1 = New System.Windows.Forms.TextBox()
            Me.lblPlate2 = New System.Windows.Forms.Label()
            Me.txtPlate2 = New System.Windows.Forms.TextBox()
            Me.lblPlate3 = New System.Windows.Forms.Label()
            Me.txtPlate3 = New System.Windows.Forms.TextBox()
            Me.lblMaxNotice = New System.Windows.Forms.Label()
            Me.lblTransactionType = New System.Windows.Forms.Label()
            Me.cmbTransactionType = New System.Windows.Forms.ComboBox()
            Me.lblPaymentMethod = New System.Windows.Forms.Label()
            Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
            Me.lblTotalFeeTitle = New System.Windows.Forms.Label()
            Me.lblTotalFeeValue = New System.Windows.Forms.Label()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.dgvMembers = New System.Windows.Forms.DataGridView()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlFormCard.SuspendLayout()
            Me.pnlGridCard.SuspendLayout()
            CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.btnClose)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(1333, 74)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(27, 22)
            Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(274, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Pendaftaran Member Parkir"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(1271, 15)
            Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(47, 43)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "X"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.pnlMain.Controls.Add(Me.pnlFormCard)
            Me.pnlMain.Controls.Add(Me.pnlGridCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 74)
            Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
            Me.pnlMain.Size = New System.Drawing.Size(1333, 726)
            Me.pnlMain.TabIndex = 1
            '
            'pnlFormCard
            '
            Me.pnlFormCard.BackColor = System.Drawing.Color.White
            Me.pnlFormCard.Controls.Add(Me.lblFormTitle)
            Me.pnlFormCard.Controls.Add(Me.lblOwnerName)
            Me.pnlFormCard.Controls.Add(Me.txtOwnerName)
            Me.pnlFormCard.Controls.Add(Me.lblLevel)
            Me.pnlFormCard.Controls.Add(Me.cmbLevel)
            Me.pnlFormCard.Controls.Add(Me.lblPlate1)
            Me.pnlFormCard.Controls.Add(Me.txtPlate1)
            Me.pnlFormCard.Controls.Add(Me.lblPlate2)
            Me.pnlFormCard.Controls.Add(Me.txtPlate2)
            Me.pnlFormCard.Controls.Add(Me.lblPlate3)
            Me.pnlFormCard.Controls.Add(Me.txtPlate3)
            Me.pnlFormCard.Controls.Add(Me.lblMaxNotice)
            Me.pnlFormCard.Controls.Add(Me.lblTransactionType)
            Me.pnlFormCard.Controls.Add(Me.cmbTransactionType)
            Me.pnlFormCard.Controls.Add(Me.lblPaymentMethod)
            Me.pnlFormCard.Controls.Add(Me.cmbPaymentMethod)
            Me.pnlFormCard.Controls.Add(Me.lblTotalFeeTitle)
            Me.pnlFormCard.Controls.Add(Me.lblTotalFeeValue)
            Me.pnlFormCard.Controls.Add(Me.btnSave)
            Me.pnlFormCard.Controls.Add(Me.btnDelete)
            Me.pnlFormCard.Controls.Add(Me.btnClear)
            Me.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlFormCard.Location = New System.Drawing.Point(826, 25)
            Me.pnlFormCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlFormCard.Name = "pnlFormCard"
            Me.pnlFormCard.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
            Me.pnlFormCard.Size = New System.Drawing.Size(480, 676)
            Me.pnlFormCard.TabIndex = 1
            '
            'lblFormTitle
            '
            Me.lblFormTitle.AutoSize = True
            Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.lblFormTitle.Location = New System.Drawing.Point(27, 18)
            Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblFormTitle.Name = "lblFormTitle"
            Me.lblFormTitle.Size = New System.Drawing.Size(177, 25)
            Me.lblFormTitle.TabIndex = 0
            Me.lblFormTitle.Text = "Registrasi Member"
            '
            'lblOwnerName
            '
            Me.lblOwnerName.AutoSize = True
            Me.lblOwnerName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblOwnerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblOwnerName.Location = New System.Drawing.Point(27, 55)
            Me.lblOwnerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblOwnerName.Name = "lblOwnerName"
            Me.lblOwnerName.Size = New System.Drawing.Size(108, 20)
            Me.lblOwnerName.TabIndex = 1
            Me.lblOwnerName.Text = "Nama Pemilik:"
            '
            'txtOwnerName
            '
            Me.txtOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtOwnerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtOwnerName.Location = New System.Drawing.Point(31, 78)
            Me.txtOwnerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtOwnerName.Name = "txtOwnerName"
            Me.txtOwnerName.Size = New System.Drawing.Size(413, 27)
            Me.txtOwnerName.TabIndex = 2
            '
            'lblLevel
            '
            Me.lblLevel.AutoSize = True
            Me.lblLevel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblLevel.Location = New System.Drawing.Point(27, 114)
            Me.lblLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblLevel.Name = "lblLevel"
            Me.lblLevel.Size = New System.Drawing.Size(111, 20)
            Me.lblLevel.TabIndex = 3
            Me.lblLevel.Text = "Level Member:"
            '
            'cmbLevel
            '
            Me.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbLevel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.cmbLevel.FormattingEnabled = True
            Me.cmbLevel.Location = New System.Drawing.Point(31, 137)
            Me.cmbLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cmbLevel.Name = "cmbLevel"
            Me.cmbLevel.Size = New System.Drawing.Size(412, 28)
            Me.cmbLevel.TabIndex = 4
            '
            'lblPlate1
            '
            Me.lblPlate1.AutoSize = True
            Me.lblPlate1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblPlate1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPlate1.Location = New System.Drawing.Point(27, 174)
            Me.lblPlate1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPlate1.Name = "lblPlate1"
            Me.lblPlate1.Size = New System.Drawing.Size(123, 20)
            Me.lblPlate1.TabIndex = 5
            Me.lblPlate1.Text = "Plat Nomor 1 (*):"
            '
            'txtPlate1
            '
            Me.txtPlate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPlate1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtPlate1.Location = New System.Drawing.Point(31, 196)
            Me.txtPlate1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtPlate1.Name = "txtPlate1"
            Me.txtPlate1.Size = New System.Drawing.Size(413, 27)
            Me.txtPlate1.TabIndex = 6
            '
            'lblPlate2
            '
            Me.lblPlate2.AutoSize = True
            Me.lblPlate2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblPlate2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPlate2.Location = New System.Drawing.Point(27, 230)
            Me.lblPlate2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPlate2.Name = "lblPlate2"
            Me.lblPlate2.Size = New System.Drawing.Size(178, 20)
            Me.lblPlate2.TabIndex = 7
            Me.lblPlate2.Text = "Plat Nomor 2 (Opsional):"
            '
            'txtPlate2
            '
            Me.txtPlate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPlate2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtPlate2.Location = New System.Drawing.Point(31, 252)
            Me.txtPlate2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtPlate2.Name = "txtPlate2"
            Me.txtPlate2.Size = New System.Drawing.Size(413, 27)
            Me.txtPlate2.TabIndex = 8
            '
            'lblPlate3
            '
            Me.lblPlate3.AutoSize = True
            Me.lblPlate3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblPlate3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPlate3.Location = New System.Drawing.Point(27, 287)
            Me.lblPlate3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPlate3.Name = "lblPlate3"
            Me.lblPlate3.Size = New System.Drawing.Size(178, 20)
            Me.lblPlate3.TabIndex = 9
            Me.lblPlate3.Text = "Plat Nomor 3 (Opsional):"
            '
            'txtPlate3
            '
            Me.txtPlate3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPlate3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtPlate3.Location = New System.Drawing.Point(31, 309)
            Me.txtPlate3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtPlate3.Name = "txtPlate3"
            Me.txtPlate3.Size = New System.Drawing.Size(413, 27)
            Me.txtPlate3.TabIndex = 10
            '
            'lblMaxNotice
            '
            Me.lblMaxNotice.AutoSize = True
            Me.lblMaxNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.lblMaxNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblMaxNotice.Location = New System.Drawing.Point(27, 342)
            Me.lblMaxNotice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblMaxNotice.Name = "lblMaxNotice"
            Me.lblMaxNotice.Size = New System.Drawing.Size(275, 17)
            Me.lblMaxNotice.TabIndex = 11
            Me.lblMaxNotice.Text = "* Maksimal 3 kendaraan per nama individu"
            '
            'lblTransactionType
            '
            Me.lblTransactionType.AutoSize = True
            Me.lblTransactionType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblTransactionType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblTransactionType.Location = New System.Drawing.Point(27, 367)
            Me.lblTransactionType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTransactionType.Name = "lblTransactionType"
            Me.lblTransactionType.Size = New System.Drawing.Size(112, 20)
            Me.lblTransactionType.TabIndex = 12
            Me.lblTransactionType.Text = "Jenis Transaksi:"
            '
            'cmbTransactionType
            '
            Me.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTransactionType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.cmbTransactionType.FormattingEnabled = True
            Me.cmbTransactionType.Items.AddRange(New Object() {"Pendaftaran Baru", "Iuran Bulanan (Langganan)"})
            Me.cmbTransactionType.Location = New System.Drawing.Point(31, 389)
            Me.cmbTransactionType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cmbTransactionType.Name = "cmbTransactionType"
            Me.cmbTransactionType.Size = New System.Drawing.Size(412, 28)
            Me.cmbTransactionType.TabIndex = 13
            '
            'lblPaymentMethod
            '
            Me.lblPaymentMethod.AutoSize = True
            Me.lblPaymentMethod.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPaymentMethod.Location = New System.Drawing.Point(27, 426)
            Me.lblPaymentMethod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPaymentMethod.Name = "lblPaymentMethod"
            Me.lblPaymentMethod.Size = New System.Drawing.Size(155, 20)
            Me.lblPaymentMethod.TabIndex = 14
            Me.lblPaymentMethod.Text = "Metode Pembayaran:"
            '
            'cmbPaymentMethod
            '
            Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.cmbPaymentMethod.FormattingEnabled = True
            Me.cmbPaymentMethod.Items.AddRange(New Object() {"Tunai", "QRIS", "Debit"})
            Me.cmbPaymentMethod.Location = New System.Drawing.Point(31, 448)
            Me.cmbPaymentMethod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
            Me.cmbPaymentMethod.Size = New System.Drawing.Size(412, 28)
            Me.cmbPaymentMethod.TabIndex = 15
            '
            'lblTotalFeeTitle
            '
            Me.lblTotalFeeTitle.AutoSize = True
            Me.lblTotalFeeTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.lblTotalFeeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalFeeTitle.Location = New System.Drawing.Point(27, 490)
            Me.lblTotalFeeTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTotalFeeTitle.Name = "lblTotalFeeTitle"
            Me.lblTotalFeeTitle.Size = New System.Drawing.Size(126, 20)
            Me.lblTotalFeeTitle.TabIndex = 16
            Me.lblTotalFeeTitle.Text = "Total Biaya Bayar:"
            '
            'lblTotalFeeValue
            '
            Me.lblTotalFeeValue.AutoSize = True
            Me.lblTotalFeeValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalFeeValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.lblTotalFeeValue.Location = New System.Drawing.Point(167, 485)
            Me.lblTotalFeeValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTotalFeeValue.Name = "lblTotalFeeValue"
            Me.lblTotalFeeValue.Size = New System.Drawing.Size(108, 28)
            Me.lblTotalFeeValue.TabIndex = 17
            Me.lblTotalFeeValue.Text = "Rp 50.000"
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(31, 529)
            Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(413, 47)
            Me.btnSave.TabIndex = 18
            Me.btnSave.Text = "DAFTAR / BAYAR"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.FlatAppearance.BorderSize = 0
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnDelete.ForeColor = System.Drawing.Color.White
            Me.btnDelete.Location = New System.Drawing.Point(31, 588)
            Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(200, 43)
            Me.btnDelete.TabIndex = 19
            Me.btnDelete.Text = "HAPUS"
            Me.btnDelete.UseVisualStyleBackColor = False
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClear.FlatAppearance.BorderSize = 0
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.btnClear.Location = New System.Drawing.Point(244, 588)
            Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(200, 43)
            Me.btnClear.TabIndex = 20
            Me.btnClear.Text = "RESET"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            'pnlGridCard
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.dgvMembers)
            Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlGridCard.Location = New System.Drawing.Point(27, 25)
            Me.pnlGridCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.pnlGridCard.Size = New System.Drawing.Size(773, 676)
            Me.pnlGridCard.TabIndex = 0
            '
            'dgvMembers
            '
            Me.dgvMembers.AllowUserToAddRows = False
            Me.dgvMembers.AllowUserToDeleteRows = False
            Me.dgvMembers.AllowUserToResizeRows = False
            Me.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvMembers.BackgroundColor = System.Drawing.Color.White
            Me.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMembers.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvMembers.EnableHeadersVisualStyles = False
            Me.dgvMembers.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvMembers.Location = New System.Drawing.Point(13, 12)
            Me.dgvMembers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dgvMembers.MultiSelect = False
            Me.dgvMembers.Name = "dgvMembers"
            Me.dgvMembers.ReadOnly = True
            Me.dgvMembers.RowHeadersVisible = False
            Me.dgvMembers.RowHeadersWidth = 51
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvMembers.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvMembers.RowTemplate.Height = 35
            Me.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMembers.Size = New System.Drawing.Size(747, 652)
            Me.dgvMembers.TabIndex = 0
            '
            'MemberRegistrationForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1333, 800)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "MemberRegistrationForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Pendaftaran Member"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlFormCard.ResumeLayout(False)
            Me.pnlFormCard.PerformLayout()
            Me.pnlGridCard.ResumeLayout(False)
            CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
        Friend WithEvents dgvMembers As System.Windows.Forms.DataGridView
        Friend WithEvents pnlFormCard As System.Windows.Forms.Panel
        Friend WithEvents lblFormTitle As System.Windows.Forms.Label
        Friend WithEvents lblOwnerName As System.Windows.Forms.Label
        Friend WithEvents txtOwnerName As System.Windows.Forms.TextBox
        Friend WithEvents lblLevel As System.Windows.Forms.Label
        Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
        Friend WithEvents lblPlate1 As System.Windows.Forms.Label
        Friend WithEvents txtPlate1 As System.Windows.Forms.TextBox
        Friend WithEvents lblPlate2 As System.Windows.Forms.Label
        Friend WithEvents txtPlate2 As System.Windows.Forms.TextBox
        Friend WithEvents lblPlate3 As System.Windows.Forms.Label
        Friend WithEvents txtPlate3 As System.Windows.Forms.TextBox
        Friend WithEvents lblMaxNotice As System.Windows.Forms.Label
        Friend WithEvents lblTransactionType As System.Windows.Forms.Label
        Friend WithEvents cmbTransactionType As System.Windows.Forms.ComboBox
        Friend WithEvents lblPaymentMethod As System.Windows.Forms.Label
        Friend WithEvents cmbPaymentMethod As System.Windows.Forms.ComboBox
        Friend WithEvents lblTotalFeeTitle As System.Windows.Forms.Label
        Friend WithEvents lblTotalFeeValue As System.Windows.Forms.Label
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnDelete As System.Windows.Forms.Button
        Friend WithEvents btnClear As System.Windows.Forms.Button
    End Class
End Namespace