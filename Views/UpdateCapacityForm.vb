Imports System
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers

Namespace Views
    ''' <summary>
    ''' Form UpdateCapacityForm menyediakan dialog modal sederhana untuk memperbarui kapasitas maksimum slot parkir Mobil dan Motor di memori sistem.
    ''' </summary>
    Partial Public Class UpdateCapacityForm
        Inherits Form

        ''' <summary>
        ''' Constructor untuk menginisialisasi Form Update Kapasitas Slot Parkir.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub UpdateCapacityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Mengisi nilai kuota parkir saat ini dari DashboardController
            numCarCapacity.Value = DashboardController.MaxCarCapacity
            numMotorCapacity.Value = DashboardController.MaxMotorcycleCapacity
        End Sub

        ''' <summary>
        ''' Memproses penyimpanan kapasitas baru ke memori sistem tanpa mengubah database.
        ''' </summary>
        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            DashboardController.MaxCarCapacity = Convert.ToInt32(numCarCapacity.Value)
            DashboardController.MaxMotorcycleCapacity = Convert.ToInt32(numMotorCapacity.Value)

            MessageBox.Show("Kapasitas slot area parkir berhasil diperbarui di sistem!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub
    End Class
End Namespace
