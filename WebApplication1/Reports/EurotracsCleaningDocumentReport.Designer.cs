namespace WebApplication1.Reports
{
    partial class EurotracsCleaningDocumentReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EurotracsCleaningDocumentReport));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SubReportCompartments = new DevExpress.XtraReports.UI.XRSubreport();
            this.CompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.CleaningOrderID = new DevExpress.XtraReports.Parameters.Parameter();
            this.CompanyPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.CompanyTelLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.CompanyCityLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.CompanyStreetLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.CompanyNameLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.Logo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CustomerReferencePanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.IdentificationPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.CustomerPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.NextLoadPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.NatureOfProductPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.CleaningProceduresPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.PreviousLoadPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.AdditionalServicesPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.RemarksPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAllertec = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.SealingLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.CO2Label = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCheckBox2 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.DatePanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.CleanerPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.DriverPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.CleaningStationPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 32.00001F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.SubReportCompartments,
            this.CompanyPanel,
            this.xrPanel1,
            this.CustomerReferencePanel,
            this.IdentificationPanel,
            this.CustomerPanel,
            this.NextLoadPanel,
            this.NatureOfProductPanel,
            this.CleaningProceduresPanel,
            this.PreviousLoadPanel,
            this.AdditionalServicesPanel,
            this.RemarksPanel,
            this.DatePanel,
            this.CleanerPanel,
            this.DriverPanel,
            this.CleaningStationPanel});
            this.Detail.HeightF = 1092.744F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SubReportCompartments
            // 
            this.SubReportCompartments.LocationFloat = new DevExpress.Utils.PointFloat(76.54171F, 447.7941F);
            this.SubReportCompartments.Name = "SubReportCompartments";
            this.SubReportCompartments.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CompID", this.CompanyID));
            this.SubReportCompartments.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CleanID", this.CleaningOrderID));
            this.SubReportCompartments.SizeF = new System.Drawing.SizeF(340F, 250F);
            // 
            // CompanyID
            // 
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Type = typeof(short);
            this.CompanyID.ValueInfo = "90";
            // 
            // CleaningOrderID
            // 
            this.CleaningOrderID.Name = "CleaningOrderID";
            this.CleaningOrderID.Type = typeof(int);
            this.CleaningOrderID.ValueInfo = "27";
            // 
            // CompanyPanel
            // 
            this.CompanyPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CompanyPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.CompanyTelLabel,
            this.CompanyCityLabel,
            this.CompanyStreetLabel,
            this.CompanyNameLabel,
            this.Logo});
            this.CompanyPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.CompanyPanel.Name = "CompanyPanel";
            this.CompanyPanel.SizeF = new System.Drawing.SizeF(770.9986F, 216.103F);
            this.CompanyPanel.StylePriority.UseBorders = false;
            // 
            // CompanyTelLabel
            // 
            this.CompanyTelLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CompanyTelLabel.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.CompanyTelLabel.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 183.103F);
            this.CompanyTelLabel.Name = "CompanyTelLabel";
            this.CompanyTelLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CompanyTelLabel.SizeF = new System.Drawing.SizeF(295.4166F, 22.99997F);
            this.CompanyTelLabel.StylePriority.UseBorders = false;
            this.CompanyTelLabel.StylePriority.UseFont = false;
            this.CompanyTelLabel.Text = "CompanyTelLabel";
            // 
            // CompanyCityLabel
            // 
            this.CompanyCityLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CompanyCityLabel.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.CompanyCityLabel.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 160.103F);
            this.CompanyCityLabel.Name = "CompanyCityLabel";
            this.CompanyCityLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CompanyCityLabel.SizeF = new System.Drawing.SizeF(295.4167F, 23F);
            this.CompanyCityLabel.StylePriority.UseBorders = false;
            this.CompanyCityLabel.StylePriority.UseFont = false;
            this.CompanyCityLabel.Text = "CompanyCityLabel";
            // 
            // CompanyStreetLabel
            // 
            this.CompanyStreetLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CompanyStreetLabel.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.CompanyStreetLabel.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 137.103F);
            this.CompanyStreetLabel.Name = "CompanyStreetLabel";
            this.CompanyStreetLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CompanyStreetLabel.SizeF = new System.Drawing.SizeF(295.4167F, 23F);
            this.CompanyStreetLabel.StylePriority.UseBorders = false;
            this.CompanyStreetLabel.StylePriority.UseFont = false;
            this.CompanyStreetLabel.Text = "CompanyStreetLabel";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CompanyNameLabel.Font = new DevExpress.Drawing.DXFont("Arial", 18F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CompanyNameLabel.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 93.26964F);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CompanyNameLabel.SizeF = new System.Drawing.SizeF(295.4165F, 43.83334F);
            this.CompanyNameLabel.StylePriority.UseBorders = false;
            this.CompanyNameLabel.StylePriority.UseFont = false;
            this.CompanyNameLabel.Text = "CompanyNameLabel";
            // 
            // Logo
            // 
            this.Logo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Logo.LocationFloat = new DevExpress.Utils.PointFloat(395.4985F, 94.10299F);
            this.Logo.Name = "Logo";
            this.Logo.SizeF = new System.Drawing.SizeF(365.4986F, 112F);
            this.Logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.Logo.StylePriority.UseBorders = false;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(385.4999F, 216.103F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(385.4999F, 48.75005F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.AutoWidth = true;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CleaningOrderReference]")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(49.88906F, 28.75004F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(325.6055F, 20F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabelCleaningOrderReference";
            // 
            // CustomerReferencePanel
            // 
            this.CustomerReferencePanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CustomerReferencePanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.CustomerReferencePanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 216.103F);
            this.CustomerReferencePanel.Name = "CustomerReferencePanel";
            this.CustomerReferencePanel.SizeF = new System.Drawing.SizeF(385.5F, 48.75005F);
            this.CustomerReferencePanel.StylePriority.UseBorders = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Reference]")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 28.75004F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(285.4141F, 20F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // IdentificationPanel
            // 
            this.IdentificationPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.IdentificationPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel17,
            this.xrLabel4});
            this.IdentificationPanel.LocationFloat = new DevExpress.Utils.PointFloat(385.4999F, 264.853F);
            this.IdentificationPanel.Name = "IdentificationPanel";
            this.IdentificationPanel.SizeF = new System.Drawing.SizeF(385.4986F, 107.9413F);
            this.IdentificationPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CleaningTruckInfo]")});
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(49.88906F, 51.58574F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(325.606F, 19.81372F);
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.Text = "xrLabel17";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CleaningContainerTrailerInfo]")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(49.88906F, 88.12758F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(325.6041F, 19.81375F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CustomerPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel3});
            this.CustomerPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 264.853F);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.SizeF = new System.Drawing.SizeF(385.5F, 97.94128F);
            this.CustomerPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerCity]")});
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 51.58577F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(285.4141F, 19.99997F);
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.Text = "xrLabel19";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerStreet]")});
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(90.08598F, 30.00002F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(285.4141F, 20F);
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.Text = "xrLabel18";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerName]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 9.999974F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(285.4141F, 20.00003F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // NextLoadPanel
            // 
            this.NextLoadPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.NextLoadPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6});
            this.NextLoadPanel.LocationFloat = new DevExpress.Utils.PointFloat(385.4999F, 372.7943F);
            this.NextLoadPanel.Name = "NextLoadPanel";
            this.NextLoadPanel.SizeF = new System.Drawing.SizeF(385.4987F, 74.99985F);
            this.NextLoadPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NewProductName]")});
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(49.89808F, 11.87503F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(325.6058F, 23.33337F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "xrLabel6";
            // 
            // NatureOfProductPanel
            // 
            this.NatureOfProductPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.NatureOfProductPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5});
            this.NatureOfProductPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 372.7943F);
            this.NatureOfProductPanel.Name = "NatureOfProductPanel";
            this.NatureOfProductPanel.SizeF = new System.Drawing.SizeF(385.5F, 74.99982F);
            this.NatureOfProductPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NatureOfProduct]")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(90.08598F, 11.87503F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(285.4166F, 23.33334F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "xrLabel5";
            // 
            // CleaningProceduresPanel
            // 
            this.CleaningProceduresPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CleaningProceduresPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel22,
            this.xrLabel7});
            this.CleaningProceduresPanel.LocationFloat = new DevExpress.Utils.PointFloat(416.75F, 447.7941F);
            this.CleaningProceduresPanel.Name = "CleaningProceduresPanel";
            this.CleaningProceduresPanel.SizeF = new System.Drawing.SizeF(354.2499F, 246.7882F);
            this.CleaningProceduresPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(46.76953F, 157.6215F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(272.4804F, 89.16669F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.Text = "[Remark]";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProcedureEftcoItems]")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(46.76947F, 10F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(272.4804F, 147.6215F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "xrLabel7";
            // 
            // PreviousLoadPanel
            // 
            this.PreviousLoadPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PreviousLoadPanel.CanGrow = false;
            this.PreviousLoadPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 447.7941F);
            this.PreviousLoadPanel.Name = "PreviousLoadPanel";
            this.PreviousLoadPanel.SizeF = new System.Drawing.SizeF(416.75F, 246.7882F);
            this.PreviousLoadPanel.StylePriority.UseBorders = false;
            // 
            // AdditionalServicesPanel
            // 
            this.AdditionalServicesPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AdditionalServicesPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8});
            this.AdditionalServicesPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 694.5824F);
            this.AdditionalServicesPanel.Name = "AdditionalServicesPanel";
            this.AdditionalServicesPanel.SizeF = new System.Drawing.SizeF(771F, 147.1201F);
            this.AdditionalServicesPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExtraEftcoItems]")});
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(135.9167F, 32.29163F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(625.0836F, 104.8286F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "xrLabel8";
            // 
            // RemarksPanel
            // 
            this.RemarksPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.RemarksPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20,
            this.lblAllertec,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.SealingLabel,
            this.CO2Label,
            this.xrCheckBox2,
            this.xrCheckBox1});
            this.RemarksPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 841.7025F);
            this.RemarksPanel.Name = "RemarksPanel";
            this.RemarksPanel.SizeF = new System.Drawing.SizeF(770.9989F, 75F);
            this.RemarksPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(594.2528F, 23F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(166.7401F, 23F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "[AtpLocationName] [AtpResult]";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblAllertec
            // 
            this.lblAllertec.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.lblAllertec.LocationFloat = new DevExpress.Utils.PointFloat(594.2528F, 46F);
            this.lblAllertec.Name = "lblAllertec";
            this.lblAllertec.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAllertec.SizeF = new System.Drawing.SizeF(166.7402F, 23F);
            this.lblAllertec.StylePriority.UseFont = false;
            this.lblAllertec.StylePriority.UseTextAlignment = false;
            this.lblAllertec.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(510.9985F, 45.99997F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(83.25427F, 23F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Allergenen";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CO2]")});
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(155.6293F, 42F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(219.8702F, 23F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel9
            // 
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Seals]")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(155.6293F, 10F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(219.8702F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "xrLabel9";
            // 
            // SealingLabel
            // 
            this.SealingLabel.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.SealingLabel.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 9.999974F);
            this.SealingLabel.Name = "SealingLabel";
            this.SealingLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.SealingLabel.SizeF = new System.Drawing.SizeF(65.54594F, 23F);
            this.SealingLabel.StylePriority.UseFont = false;
            this.SealingLabel.Text = "Sealing :";
            // 
            // CO2Label
            // 
            this.CO2Label.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.CO2Label.LocationFloat = new DevExpress.Utils.PointFloat(90.08337F, 41.99998F);
            this.CO2Label.Name = "CO2Label";
            this.CO2Label.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CO2Label.SizeF = new System.Drawing.SizeF(65.54597F, 23F);
            this.CO2Label.StylePriority.UseFont = false;
            this.CO2Label.Text = "CO2 :";
            // 
            // xrCheckBox2
            // 
            this.xrCheckBox2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[IsAtp]")});
            this.xrCheckBox2.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrCheckBox2.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Far;
            this.xrCheckBox2.GlyphOptions.Size = new System.Drawing.SizeF(13F, 13F);
            this.xrCheckBox2.LocationFloat = new DevExpress.Utils.PointFloat(510.9985F, 23.00012F);
            this.xrCheckBox2.Name = "xrCheckBox2";
            this.xrCheckBox2.SizeF = new System.Drawing.SizeF(83.25427F, 22.99988F);
            this.xrCheckBox2.StylePriority.UseFont = false;
            this.xrCheckBox2.Text = "ATP";
            // 
            // xrCheckBox1
            // 
            this.xrCheckBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[IsMilliport]")});
            this.xrCheckBox1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrCheckBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Far;
            this.xrCheckBox1.GlyphOptions.Size = new System.Drawing.SizeF(13F, 13F);
            this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(510.9985F, 0F);
            this.xrCheckBox1.Name = "xrCheckBox1";
            this.xrCheckBox1.SizeF = new System.Drawing.SizeF(83.25427F, 23.00012F);
            this.xrCheckBox1.StylePriority.UseFont = false;
            this.xrCheckBox1.Text = "Millipore";
            // 
            // DatePanel
            // 
            this.DatePanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DatePanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel14});
            this.DatePanel.LocationFloat = new DevExpress.Utils.PointFloat(385.5001F, 916.7025F);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.SizeF = new System.Drawing.SizeF(385.5F, 60.83337F);
            this.DatePanel.StylePriority.UseBorders = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CleaningStartDate]")});
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(188.0236F, 18.50012F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(187.48F, 15F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "xrLabel13";
            this.xrLabel13.TextFormatString = "{0:dd/MM/yyyy H:mm:ss}";
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CleaningStopDate]")});
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(188.0131F, 45.8334F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(187.48F, 15F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "xrLabel14";
            this.xrLabel14.TextFormatString = "{0:dd/MM/yyyy H:mm:ss}";
            // 
            // CleanerPanel
            // 
            this.CleanerPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CleanerPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12});
            this.CleanerPanel.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 916.7025F);
            this.CleanerPanel.Name = "CleanerPanel";
            this.CleanerPanel.SizeF = new System.Drawing.SizeF(385.5F, 60.83337F);
            this.CleanerPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CleaningUserFullName]")});
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(90.08331F, 33.33356F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(285.4167F, 27.49982F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "xrLabel12";
            // 
            // DriverPanel
            // 
            this.DriverPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DriverPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16});
            this.DriverPanel.LocationFloat = new DevExpress.Utils.PointFloat(385.5F, 1017.744F);
            this.DriverPanel.Name = "DriverPanel";
            this.DriverPanel.SizeF = new System.Drawing.SizeF(385.5F, 75F);
            this.DriverPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CleaningDriverFullName]")});
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(188.0237F, 20.00012F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(187.4764F, 45F);
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.Text = "xrLabel16";
            // 
            // CleaningStationPanel
            // 
            this.CleaningStationPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CleaningStationPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15});
            this.CleaningStationPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1017.744F);
            this.CleaningStationPanel.Name = "CleaningStationPanel";
            this.CleaningStationPanel.SizeF = new System.Drawing.SizeF(385.5F, 75F);
            this.CleaningStationPanel.StylePriority.UseBorders = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CleaningStationName]")});
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(206.75F, 20.00024F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(168.7499F, 45F);
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "xrLabel15";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrPageInfo1});
            this.BottomMargin.HeightF = 31.95837F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(998.6392F, 10.00002F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(55.44543F, 21.95835F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Pagina";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(1054.085F, 10.00002F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(50.91541F, 21.95834F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "report_spEurotracsCleaningDocumentSelect";
            queryParameter1.Name = "@CleaningOrderID";
            queryParameter1.Type = typeof(global::DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?CleaningOrderID", typeof(int));
            queryParameter2.Name = "@CompanyID";
            queryParameter2.Type = typeof(global::DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?CompanyID", typeof(short));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            storedProcQuery1.StoredProcName = "report.spEurotracsCleaningDocumentSelect";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // EurotracsCleaningDocumentReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "report_spEurotracsCleaningDocumentSelect";
            this.DataSource = this.sqlDataSource1;
            this.DisplayName = "EurotracsCleaningDocumentReport_default";
            this.Extensions.Add("DataSerializationExtension", "DevExpress.XtraReports.Web.ReportDesigner.DefaultDataSerializer");
            this.Margins = new DevExpress.Drawing.DXMargins(28F, 28F, 32.00001F, 31.95837F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.CompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.CleaningOrderID, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.CompanyID,
            this.CleaningOrderID});
            this.Version = "24.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRSubreport SubReportCompartments;
        private DevExpress.XtraReports.Parameters.Parameter CompanyID;
        private DevExpress.XtraReports.Parameters.Parameter CleaningOrderID;
        private DevExpress.XtraReports.UI.XRPanel CompanyPanel;
        private DevExpress.XtraReports.UI.XRLabel CompanyTelLabel;
        private DevExpress.XtraReports.UI.XRLabel CompanyCityLabel;
        private DevExpress.XtraReports.UI.XRLabel CompanyStreetLabel;
        private DevExpress.XtraReports.UI.XRLabel CompanyNameLabel;
        private DevExpress.XtraReports.UI.XRPictureBox Logo;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRPanel CustomerReferencePanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPanel IdentificationPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPanel CustomerPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPanel NextLoadPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRPanel NatureOfProductPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRPanel CleaningProceduresPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRPanel PreviousLoadPanel;
        private DevExpress.XtraReports.UI.XRPanel AdditionalServicesPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRPanel RemarksPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel lblAllertec;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel SealingLabel;
        private DevExpress.XtraReports.UI.XRLabel CO2Label;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox2;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox1;
        private DevExpress.XtraReports.UI.XRPanel DatePanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRPanel CleanerPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRPanel DriverPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRPanel CleaningStationPanel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
