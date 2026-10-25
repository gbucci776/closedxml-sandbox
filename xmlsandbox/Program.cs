using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

string filepath = @"C:\Users\giova\OneDrive\Desktop\PersonalMonthlyBudget1.xlsx";
using var workbook = new XLWorkbook(filepath);

var worksheet = workbook.Worksheet("Example Sheet");

var headerRow = worksheet.Row(1);
int headerCount = headerRow.CellsUsed().Count();

Console.WriteLine($"Number of headers: {headerCount}");