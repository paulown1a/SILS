using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SILS.Data;

namespace SILS.ErrorApi.Controllers
{
    public class ReportsController : ApiController
    {
        private SILSEntities db = new SILSEntities();

        // GET: api/Reports
        public List<Report> GetReports()
        {
            return DataRepository.Report.GetAllWithImfomation();
        }

        // GET: api/Reports/?bookId
        [ResponseType(typeof(Report))]
        public IHttpActionResult GetReport(int bookId)
        {
            List<Report> reports = DataRepository.Report.GetWithImformation(bookId);
            if (reports.Count==0)
            {
                return NotFound();
            }

            return Ok(reports);
        }
        // GET: api/Reports/?codeId
        [ResponseType(typeof(Report))]
        public IHttpActionResult GetReport(string codeId)
        {
            
            List<Report> reports = DataRepository.Report.GetWithImformation(codeId);
            if (reports.Count == 0)
            {
                return NotFound();
            }

            return Ok(reports);
        }

        // PUT: api/Reports/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReport(int id, Report report)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != report.ReportId)
            {
                return BadRequest();
            }

            db.Entry(report).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReportExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Reports
        [ResponseType(typeof(Report))]
        public IHttpActionResult PostReport(Report report)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reports.Add(report);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = report.ReportId }, report);
        }

        // DELETE: api/Reports/5
        [ResponseType(typeof(Report))]
        public IHttpActionResult DeleteReport(int id)
        {
            Report report = db.Reports.Find(id);
            if (report == null)
            {
                return NotFound();
            }

            db.Reports.Remove(report);
            db.SaveChanges();

            return Ok(report);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReportExists(int id)
        {
            return db.Reports.Count(e => e.ReportId == id) > 0;
        }
    }
}