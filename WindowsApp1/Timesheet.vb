Imports CsvHelper.Configuration.Attributes

Public Class Timesheet

    <Index(0)>
    Public Property [Date] As String

    <Index(1)>
    Public Property User As String

    <Index(2)>
    Public Property [UserName] As String

    <Index(3)>
    Public Property Duration As String

    <Index(4)>
    Public Property Notes As String

    '<Name("Is Client Related")>
    <Index(5)>
    Public Property IsClientRelated As String

    '<Name("Client Name")>
    <Index(6)>
    Public Property ClientName As String

    '<Name("Client Reference")>
    <Index(7)>
    Public Property ClientReference As String

    <Index(8)>
    Public Property CRMContactID As String

    '<Name("Time Catagory")>
    <Index(9)>
    Public Property TimeCatagory As String

    '<Name("Is Chargeable")>
    <Index(10)>
    Public Property IsChargeable As String

    'Is Chargeable
    '<Name("Amount To Charge")>
    <Index(11)>
    Public Property AmountToCharge As String

    '<Name("Potential Amount")>
    <Index(12)>
    Public Property PotentialAmount As String

    <Index(13)>
    Public Property TimeEntryId As String

End Class