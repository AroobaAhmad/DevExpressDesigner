using DevExpress.AspNetCore.Reporting.QueryBuilder;
using DevExpress.AspNetCore.Reporting.QueryBuilder.Native.Services;
using DevExpress.AspNetCore.Reporting.ReportDesigner;
using DevExpress.AspNetCore.Reporting.ReportDesigner.Native.Services;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;

namespace WebApplication1.Controllers;

public class CustomWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService)
    : WebDocumentViewerController(controllerService);

public class CustomReportDesignerController(IReportDesignerMvcControllerService controllerService)
    : ReportDesignerController(controllerService);

public class CustomQueryBuilderController(IQueryBuilderMvcControllerService controllerService)
    : QueryBuilderController(controllerService);
