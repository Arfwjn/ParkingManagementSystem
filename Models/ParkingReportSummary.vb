''' <summary>
''' Model DTO (Data Transfer Object) ParkingReportSummary menampung akumulasi statistik transaksi dan pendapatan laporan parkir.
''' </summary>
Public Class ParkingReportSummary
    ''' <summary>Total akumulasi transaksi parkir dalam periode laporan.</summary>
    Public Property TotalTransactions As Integer
    ''' <summary>Total keseluruhan pendapatan parkir.</summary>
    Public Property TotalRevenue As Decimal
    ''' <summary>Total jumlah transaksi parkir kendaraan mobil.</summary>
    Public Property TotalCar As Integer
    ''' <summary>Total jumlah transaksi parkir kendaraan motor.</summary>
    Public Property TotalMotorcycle As Integer
    ''' <summary>Total pendapatan dari pembayaran metode Tunai (Cash).</summary>
    Public Property TotalCashRevenue As Decimal
    ''' <summary>Total pendapatan dari pembayaran metode QRIS.</summary>
    Public Property TotalQrisRevenue As Decimal
    ''' <summary>Total pendapatan dari pembayaran metode Kartu Debit.</summary>
    Public Property TotalDebitRevenue As Decimal
End Class