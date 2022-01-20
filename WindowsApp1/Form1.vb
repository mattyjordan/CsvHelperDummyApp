'Option Strict Off

Imports System.Dynamic
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports CsvHelper
Imports Newtonsoft.Json

Public Class Form1
    Public Property CsvHelperExpectedType As Type

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ts = New Timesheet

        CsvHelperExpectedType = ts.GetType()

        Reader(CsvHelperExpectedType)()

    End Sub

    Private Function Reader(Of T As New)() As Type
        Using theReader = New StreamReader("C:\Users\mattj\OneDrive - Womble Bond Dickinson (UK) LLP\Desktop\2021-11-26 - Timesheets.csv")
            Using csv = New CsvReader(theReader, CultureInfo.InvariantCulture)
                Dim records = csv.GetRecords(Of T)().ToList()
                Dim recordsAsDt = ToDataTable(records)
            End Using
        End Using
    End Function

    Public Function ToDataTable(ByVal items As IEnumerable(Of Object)) As DataTableReader
        Dim data = items.ToArray()
        If data.Count() = 0 Then Return Nothing
        Dim ds = New DataSet()
        Dim dt = New DataTable()

        For Each key In (CType(data(0), IDictionary(Of String, Object))).Keys
            dt.Columns.Add(key)
        Next

        For Each d In data
            dt.Rows.Add((CType(d, IDictionary(Of String, Object))).Values.ToArray())
        Next

        ds.Tables.Add(dt)

        Return ds.CreateDataReader()
    End Function

End Class