// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Client.Entities
{
    public interface IReportsEntity : IEntityBase
    {
        
        /// <summary>
        /// Get Reports for Current Account
        /// </summary>
        /// <remarks>
        /// Returns all the reports configured for the current account. By expanding the Records property, a list of all ReportRecords can be accessed as well.
        /// </remarks>
        /// <returns>
        /// Reports for current account
        /// </returns>
        IQuery<ODataFeed<Report>> Get();
        
        /// <summary>
        /// Get Report by ID
        /// </summary>
        /// <remarks>
        /// Returns a single report specified by id. The Records property is expandable.
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// Single Report
        /// </returns>
        IQuery<Report> Get(Uri url);
        
        /// <summary>
        /// Get recent reports
        /// </summary>
        /// <remarks>
        /// Returns the last 10 reports run for the current account.
        /// </remarks>
        /// <returns>
        /// List of reports
        /// </returns>
        IQuery<ODataFeed<Report>> GetRecent();
        
        /// <summary>
        /// Get recurring reports
        /// </summary>
        /// <remarks>
        /// Returns all recurring reports for the current account.
        /// </remarks>
        /// <returns>
        /// List of reports
        /// </returns>
        IQuery<ODataFeed<Report>> GetRecurring();
        
        /// <summary>
        /// Get Report Record by ID
        /// </summary>
        /// <remarks>
        /// Returns a single record.
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// Single Record
        /// </returns>
        IQuery<ReportRecord> GetRecord(string id);
        
        /// <summary>
        /// Get all Records by Report ID
        /// </summary>
        /// <remarks>
        /// Returns all records for a single report.
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// Records for a Report
        /// </returns>
        IQuery<ODataFeed<ReportRecord>> GetRecords(Uri url);
        
        /// <summary>
        /// Create Report
        /// </summary>
        /// <example>
        /// {
        /// "Id": "rs24f83e-b147-437e-9f28-e7d03634af42"
        /// "Title": "Usage Report",
        /// "ReportType": "Activity",
        /// "ObjectType": "Account",
        /// "ObjectId": "a024f83e-b147-437e-9f28-e7d0ef634af42",
        /// "DateOption": "Last30Days",
        /// "SaveFormat": "Excel"
        /// }
        /// </example>
        /// <remarks>
        /// Creates a new Report.
        /// </remarks>
        /// <param name="report"></param>
        /// <param name="runOnCreate"></param>
        /// <returns>
        /// the created report
        /// </returns>
        IQuery<Report> Create(Report report, bool runOnCreate);
        
        /// <summary>
        /// Update Report
        /// </summary>
        /// <example>
        /// {
        /// "Title": "Usage Report",
        /// "ReportType": "Activity",
        /// "ObjectType": "Account",
        /// "ObjectId": "a024f83e-b147-437e-9f28-e7d03634af42",
        /// "DateOption": "Last30Days",
        /// "Frequency": "Once"
        /// }
        /// </example>
        /// <remarks>
        /// Updates an existing report
        /// </remarks>
        /// <param name="report"></param>
        /// <returns>
        /// the updated report
        /// </returns>
        IQuery<Report> Update(Report report);
        
        /// <summary>
        /// Delete Report
        /// </summary>
        /// <remarks>
        /// Removes a report from the system
        /// </remarks>
        /// <param name="url"></param>
        IQuery Delete(Uri url);
        
        /// <summary>
        /// Run Report
        /// </summary>
        /// <remarks>
        /// Run a report and get the run id.
        /// </remarks>
        /// <returns>
        /// ReportRecord
        /// </returns>
        IQuery<ReportRecord> GetRun(Uri url);
        
        /// <summary>
        /// Get a preview location for the report
        /// </summary>
        /// <param name="reportUrl"></param>
        IQuery<ItemProtocolLink> Preview(Uri reportUrl);
        
        /// <summary>
        /// Get JSON Data
        /// </summary>
        /// <remarks>
        /// Get the JSON data for a report
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// JSON Formatted Report Results
        /// </returns>
        IQuery GetJsonData(string id);
        
        /// <summary>
        /// Save a folder to a folder location
        /// </summary>
        /// <param name="reportUrl"></param>
        /// <param name="folderId"></param>
        IQuery Move(Uri reportUrl, string folderId);
        
        /// <summary>
        /// Get spreadsheet data
        /// </summary>
        /// <remarks>
        /// Get the spreadsheet data for a report
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// Excel Formatted Report Results
        /// </returns>
        IQuery DownloadData(string id);
    }

    public class ReportsEntity : EntityBase, IReportsEntity
    {
        public ReportsEntity (IShareFileClient client)
            : base (client, "Reports")
        { }
        
        
        /// <summary>
        /// Get Reports for Current Account
        /// </summary>
        /// <remarks>
        /// Returns all the reports configured for the current account. By expanding the Records property, a list of all ReportRecords can be accessed as well.
        /// </remarks>
        /// <returns>
        /// Reports for current account
        /// </returns>
        public IQuery<ODataFeed<Report>> Get()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Report>>(Client);
		    sfApiQuery.From("Reports");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Report by ID
        /// </summary>
        /// <remarks>
        /// Returns a single report specified by id. The Records property is expandable.
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// Single Report
        /// </returns>
        public IQuery<Report> Get(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Report>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get recent reports
        /// </summary>
        /// <remarks>
        /// Returns the last 10 reports run for the current account.
        /// </remarks>
        /// <returns>
        /// List of reports
        /// </returns>
        public IQuery<ODataFeed<Report>> GetRecent()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Report>>(Client);
		    sfApiQuery.From("Reports");
		    sfApiQuery.Action("Recent");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get recurring reports
        /// </summary>
        /// <remarks>
        /// Returns all recurring reports for the current account.
        /// </remarks>
        /// <returns>
        /// List of reports
        /// </returns>
        public IQuery<ODataFeed<Report>> GetRecurring()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Report>>(Client);
		    sfApiQuery.From("Reports");
		    sfApiQuery.Action("Recurring");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Report Record by ID
        /// </summary>
        /// <remarks>
        /// Returns a single record.
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// Single Record
        /// </returns>
        public IQuery<ReportRecord> GetRecord(string id)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ReportRecord>(Client);
		    sfApiQuery.From("Reports");
		    sfApiQuery.Action("Record");
            sfApiQuery.ActionIds(id);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get all Records by Report ID
        /// </summary>
        /// <remarks>
        /// Returns all records for a single report.
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// Records for a Report
        /// </returns>
        public IQuery<ODataFeed<ReportRecord>> GetRecords(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<ReportRecord>>(Client);
		    sfApiQuery.Action("Records");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Create Report
        /// </summary>
        /// <example>
        /// {
        /// "Id": "rs24f83e-b147-437e-9f28-e7d03634af42"
        /// "Title": "Usage Report",
        /// "ReportType": "Activity",
        /// "ObjectType": "Account",
        /// "ObjectId": "a024f83e-b147-437e-9f28-e7d0ef634af42",
        /// "DateOption": "Last30Days",
        /// "SaveFormat": "Excel"
        /// }
        /// </example>
        /// <remarks>
        /// Creates a new Report.
        /// </remarks>
        /// <param name="report"></param>
        /// <param name="runOnCreate"></param>
        /// <returns>
        /// the created report
        /// </returns>
        public IQuery<Report> Create(Report report, bool runOnCreate)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Report>(Client);
		    sfApiQuery.From("Reports");
            sfApiQuery.QueryString("runOnCreate", runOnCreate);
            sfApiQuery.Body = report;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Update Report
        /// </summary>
        /// <example>
        /// {
        /// "Title": "Usage Report",
        /// "ReportType": "Activity",
        /// "ObjectType": "Account",
        /// "ObjectId": "a024f83e-b147-437e-9f28-e7d03634af42",
        /// "DateOption": "Last30Days",
        /// "Frequency": "Once"
        /// }
        /// </example>
        /// <remarks>
        /// Updates an existing report
        /// </remarks>
        /// <param name="report"></param>
        /// <returns>
        /// the updated report
        /// </returns>
        public IQuery<Report> Update(Report report)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Report>(Client);
		    sfApiQuery.From("Reports");
            sfApiQuery.Body = report;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Delete Report
        /// </summary>
        /// <remarks>
        /// Removes a report from the system
        /// </remarks>
        /// <param name="url"></param>
        public IQuery Delete(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Run Report
        /// </summary>
        /// <remarks>
        /// Run a report and get the run id.
        /// </remarks>
        /// <returns>
        /// ReportRecord
        /// </returns>
        public IQuery<ReportRecord> GetRun(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ReportRecord>(Client);
		    sfApiQuery.Action("Run");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get a preview location for the report
        /// </summary>
        /// <param name="reportUrl"></param>
        public IQuery<ItemProtocolLink> Preview(Uri reportUrl)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ItemProtocolLink>(Client);
		    sfApiQuery.Action("Preview");
            sfApiQuery.Uri(reportUrl);
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get JSON Data
        /// </summary>
        /// <remarks>
        /// Get the JSON data for a report
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// JSON Formatted Report Results
        /// </returns>
        public IQuery GetJsonData(string id)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.From("Reports");
		    sfApiQuery.Action("Records");
            sfApiQuery.ActionIds(id);
            sfApiQuery.SubAction("JsonData");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Save a folder to a folder location
        /// </summary>
        /// <param name="reportUrl"></param>
        /// <param name="folderId"></param>
        public IQuery Move(Uri reportUrl, string folderId)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.Action("Move");
            sfApiQuery.Uri(reportUrl);
            sfApiQuery.QueryString("folderId", folderId);
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get spreadsheet data
        /// </summary>
        /// <remarks>
        /// Get the spreadsheet data for a report
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// Excel Formatted Report Results
        /// </returns>
        public IQuery DownloadData(string id)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.From("Reports");
		    sfApiQuery.Action("Records");
            sfApiQuery.ActionIds(id);
            sfApiQuery.SubAction("DownloadData");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
    }
}