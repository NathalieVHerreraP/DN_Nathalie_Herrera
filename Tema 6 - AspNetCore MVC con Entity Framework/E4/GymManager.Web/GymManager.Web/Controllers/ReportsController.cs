using GymManager.DataAccess.Reports;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web.Controllers
{
    public class ReportsController : Controller
    {

        private readonly IWebHostEnvironment _environment;
        private readonly IGeneratePdf _generatePdf;

        public ReportsController(IWebHostEnvironment environment, IGeneratePdf generatePdf) 
        {
            _environment = environment;
            _generatePdf = generatePdf;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult NewMembers()
        {
            string path = System.IO.Path.Combine(_environment.ContentRootPath, "Reports\\NewMembers.rdlc");
            Stream reportDefinition = System.IO.File.OpenRead(path);

            LocalReport report = new LocalReport();
            report.EnableExternalImages = true;
            report.LoadReportDefinition(reportDefinition);

            MembersDataSet dataSet = new MembersDataSet();
            Random random = new Random();

            string[] membershipTypes = new string[] { "Basic", "Family", "Gold" };

            for (int i = 1; i < 28; i++)
            {
                MembersDataSet.MemberRow row = dataSet.Member.NewMemberRow();
                int day = random.Next(1, 10) * -1;
                int membershipIndex = random.Next(0,2);

                row.Name = $"Member Ness {i}";
                row.RegisteredOn = DateTime.Today.AddDays(day);
                row.MembershipType = membershipTypes[membershipIndex];

                dataSet.Member.Rows.Add(row);

            }

            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string reportName = "NewMembers";
            string[] streamids = null;
            Warning[] warnings = null;

            report.SetParameters(new ReportParameter[] 
            { 
                new ReportParameter("DateFrom", DateTime.Today.AddDays(-10).ToString()),
                new ReportParameter("DateTo", DateTime.Today.ToString())
            });

            report.DataSources.Add(new ReportDataSource("Members", (System.Data.DataTable)dataSet.Member));

            streamBytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);



            return File(streamBytes, mimeType, $"{reportName}.{filenameExtension}");
        }
        public IActionResult Attendance()
        {
            string path = System.IO.Path.Combine(_environment.ContentRootPath, "Reports\\Attendances.rdlc");

            Stream attendanceDefinition = System.IO.File.OpenRead(path);

            LocalReport attendances = new LocalReport();
            attendances.EnableExternalImages = true;
            attendances.LoadReportDefinition(attendanceDefinition);

            MembersDataSet dataSet = new MembersDataSet();
            Random random = new Random();


            for (int i = 1; i < 20; i++)
            {
                MembersDataSet.AttendanceRow row = dataSet.Attendance.NewAttendanceRow();
                int day = random.Next(1, 30) * -1;
                int frecuency = random.Next(5, 10);

                row.Name = $"Member Ness {i}";
                row.Attendances = frecuency;
                row.LastAttendance = DateTime.Today.AddDays(day); ;

                dataSet.Attendance.Rows.Add(row);

            }

            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string reportName = "Attendances";
            string[] streamids = null;
            Warning[] warnings = null;

            attendances.SetParameters(new ReportParameter[]
            {
                new ReportParameter("DateFrom", DateTime.Today.AddDays(-30).ToString()),
                new ReportParameter("DateTo", DateTime.Today.ToString())
            });

            attendances.DataSources.Add(new ReportDataSource("Attendace", (System.Data.DataTable)dataSet.Attendance));

            streamBytes = attendances.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            return File(streamBytes, mimeType, $"{reportName}.{filenameExtension}");
        }
    }
}
