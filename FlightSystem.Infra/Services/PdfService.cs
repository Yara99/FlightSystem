using FlightSystem.Core.DTO;
using FlightSystem.Core.Services;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;

public class PdfService : IPdfService
{
    public async Task<byte[]> GeneratePdfAsync(InvoiceDTO invoiceDTO)
    {
        using (var memoryStream = new MemoryStream())
        {
            using (var pdfWriter = new PdfWriter(memoryStream))
            {
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    var document = new Document(pdfDocument);

                    // Set background color for the document
                    Color lightGray = new DeviceGray(0.9f);

                    // Title
                    document.Add(new Paragraph("Flight Reservation Ticket")
                        .SetFontSize(24)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBold()
                        .SetFontColor(ColorConstants.DARK_GRAY)
                        .SetMarginBottom(20));

                    // Separator line
                    document.Add(new LineSeparator(new SolidLine(1f)).SetMarginBottom(20));

                    // Ticket details table
                    var table = new Table(2);
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    // Table styles
                    var headerFontSize = 12f;
                    var cellFontSize = 11f;

                    // Header Row
                    table.AddCell(new Cell().Add(new Paragraph("Airline"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetFontSize(headerFontSize)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));
                    table.AddCell(new Cell().Add(new Paragraph(invoiceDTO.AirlineName))
                        .SetFontSize(cellFontSize));

                    table.AddCell(new Cell().Add(new Paragraph("Flight Number"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetFontSize(headerFontSize)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));
                    table.AddCell(new Cell().Add(new Paragraph(invoiceDTO.FlightNumber))
                        .SetFontSize(cellFontSize));

                    table.AddCell(new Cell().Add(new Paragraph("Departure Airport"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetFontSize(headerFontSize)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));
                    table.AddCell(new Cell().Add(new Paragraph($"{invoiceDTO.DepartureAirportName} ({invoiceDTO.DepartureIataCode})"))
                        .SetFontSize(cellFontSize));

                    table.AddCell(new Cell().Add(new Paragraph("Arrival Airport"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetFontSize(headerFontSize)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));
                    table.AddCell(new Cell().Add(new Paragraph($"{invoiceDTO.DestinationAirportName} ({invoiceDTO.DestinationIataCode})"))
                        .SetFontSize(cellFontSize));

                    table.AddCell(new Cell().Add(new Paragraph("Class"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetFontSize(headerFontSize)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));
                    table.AddCell(new Cell().Add(new Paragraph(invoiceDTO.DegreeName))
                        .SetFontSize(cellFontSize));

                    table.AddCell(new Cell().Add(new Paragraph("Departure Date"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetFontSize(headerFontSize)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));
                    table.AddCell(new Cell().Add(new Paragraph(invoiceDTO.DepartureDate))
                        .SetFontSize(cellFontSize));

                    table.AddCell(new Cell().Add(new Paragraph("Arrival Date"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetFontSize(headerFontSize)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));
                    table.AddCell(new Cell().Add(new Paragraph(invoiceDTO.DestinationDate))
                        .SetFontSize(cellFontSize));

                    table.AddCell(new Cell().Add(new Paragraph("Total Price"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetFontSize(headerFontSize)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));
                    table.AddCell(new Cell().Add(new Paragraph($"${invoiceDTO.TotalPrice}"))
                        .SetFontSize(cellFontSize)
                        .SetBold());

                    document.Add(table.SetMarginBottom(20));

                    // Thank you message with styling
                    document.Add(new Paragraph("\nThank you for choosing our airline! We wish you a pleasant journey.")
                        .SetFontSize(12)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginTop(30)
                        .SetFontColor(ColorConstants.DARK_GRAY));

                    document.Close();
                }
            }
            return memoryStream.ToArray();
        }
    }
}
