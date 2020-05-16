﻿using DevExpress.XtraEditors.Repository;
using System.Drawing;

namespace OrderExport
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo10 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo11 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo12 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo13 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo14 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo15 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo16 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo17 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo18 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col来源 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col订单号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col订单序号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col品牌名 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col商品条码 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col商品款号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col品类 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col商品名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col颜色 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col尺码 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col数量 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收货人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col联系电话 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收货地址 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col快递公司 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col运单号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU编码 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col条形码 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.btn_loadExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem6 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem7 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem8 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem9 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem10 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem11 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem5 = new DevExpress.XtraBars.BarEditItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.excelDataSource1;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 160);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEdit});
            this.gridControl.Size = new System.Drawing.Size(1366, 608);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.MouseHover += new System.EventHandler(this.gridControl_MouseHover);
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "来源";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "订单号";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "订单序号";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "品牌名";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "商品条码";
            fieldInfo5.Type = typeof(string);
            fieldInfo6.Name = "商品款号";
            fieldInfo6.Type = typeof(string);
            fieldInfo7.Name = "品类";
            fieldInfo7.Type = typeof(string);
            fieldInfo8.Name = "商品名称";
            fieldInfo8.Type = typeof(string);
            fieldInfo9.Name = "颜色";
            fieldInfo9.Type = typeof(string);
            fieldInfo10.Name = "尺码";
            fieldInfo10.Type = typeof(string);
            fieldInfo11.Name = "数量";
            fieldInfo11.Type = typeof(double);
            fieldInfo12.Name = "收货人";
            fieldInfo12.Type = typeof(string);
            fieldInfo13.Name = "联系电话";
            fieldInfo13.Type = typeof(double);
            fieldInfo14.Name = "收货地址";
            fieldInfo14.Type = typeof(string);
            fieldInfo15.Name = "快递公司";
            fieldInfo15.Type = typeof(string);
            fieldInfo16.Name = "运单号";
            fieldInfo16.Type = typeof(string);
            fieldInfo17.Name = "SKU编码";
            fieldInfo17.Type = typeof(string);
            fieldInfo18.Name = "条形码";
            fieldInfo18.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9,
            fieldInfo10,
            fieldInfo11,
            fieldInfo12,
            fieldInfo13,
            fieldInfo14,
            fieldInfo15,
            fieldInfo16,
            fieldInfo17,
            fieldInfo18});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Sheet1";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col来源,
            this.col订单号,
            this.col订单序号,
            this.col品牌名,
            this.col商品条码,
            this.col商品款号,
            this.col品类,
            this.col商品名称,
            this.col颜色,
            this.col尺码,
            this.col数量,
            this.col收货人,
            this.col联系电话,
            this.col收货地址,
            this.col快递公司,
            this.col运单号,
            this.colSKU编码,
            this.col条形码,
            this.colPic});
            this.gridView.DetailHeight = 377;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.MultiSelect = true;
            // 
            // col来源
            // 
            this.col来源.FieldName = "来源";
            this.col来源.Name = "col来源";
            this.col来源.Visible = true;
            this.col来源.VisibleIndex = 0;
            this.col来源.Width = 33;
            // 
            // col订单号
            // 
            this.col订单号.FieldName = "订单号";
            this.col订单号.Name = "col订单号";
            this.col订单号.Visible = true;
            this.col订单号.VisibleIndex = 1;
            this.col订单号.Width = 33;
            // 
            // col订单序号
            // 
            this.col订单序号.FieldName = "订单序号";
            this.col订单序号.Name = "col订单序号";
            this.col订单序号.Visible = true;
            this.col订单序号.VisibleIndex = 2;
            this.col订单序号.Width = 33;
            // 
            // col品牌名
            // 
            this.col品牌名.FieldName = "品牌名";
            this.col品牌名.Name = "col品牌名";
            this.col品牌名.Visible = true;
            this.col品牌名.VisibleIndex = 3;
            this.col品牌名.Width = 33;
            // 
            // col商品条码
            // 
            this.col商品条码.FieldName = "商品条码";
            this.col商品条码.Name = "col商品条码";
            this.col商品条码.Visible = true;
            this.col商品条码.VisibleIndex = 4;
            this.col商品条码.Width = 33;
            // 
            // col商品款号
            // 
            this.col商品款号.FieldName = "商品款号";
            this.col商品款号.Name = "col商品款号";
            this.col商品款号.Visible = true;
            this.col商品款号.VisibleIndex = 5;
            this.col商品款号.Width = 33;
            // 
            // col品类
            // 
            this.col品类.FieldName = "品类";
            this.col品类.Name = "col品类";
            this.col品类.Visible = true;
            this.col品类.VisibleIndex = 6;
            this.col品类.Width = 33;
            // 
            // col商品名称
            // 
            this.col商品名称.FieldName = "商品名称";
            this.col商品名称.Name = "col商品名称";
            this.col商品名称.Visible = true;
            this.col商品名称.VisibleIndex = 7;
            this.col商品名称.Width = 122;
            // 
            // col颜色
            // 
            this.col颜色.FieldName = "颜色";
            this.col颜色.Name = "col颜色";
            this.col颜色.Visible = true;
            this.col颜色.VisibleIndex = 8;
            this.col颜色.Width = 24;
            // 
            // col尺码
            // 
            this.col尺码.FieldName = "尺码";
            this.col尺码.Name = "col尺码";
            this.col尺码.Visible = true;
            this.col尺码.VisibleIndex = 9;
            this.col尺码.Width = 24;
            // 
            // col数量
            // 
            this.col数量.FieldName = "数量";
            this.col数量.Name = "col数量";
            this.col数量.Visible = true;
            this.col数量.VisibleIndex = 10;
            this.col数量.Width = 24;
            // 
            // col收货人
            // 
            this.col收货人.FieldName = "收货人";
            this.col收货人.Name = "col收货人";
            this.col收货人.Visible = true;
            this.col收货人.VisibleIndex = 11;
            this.col收货人.Width = 24;
            // 
            // col联系电话
            // 
            this.col联系电话.FieldName = "联系电话";
            this.col联系电话.Name = "col联系电话";
            this.col联系电话.Visible = true;
            this.col联系电话.VisibleIndex = 12;
            this.col联系电话.Width = 24;
            // 
            // col收货地址
            // 
            this.col收货地址.FieldName = "收货地址";
            this.col收货地址.Name = "col收货地址";
            this.col收货地址.Visible = true;
            this.col收货地址.VisibleIndex = 13;
            this.col收货地址.Width = 24;
            // 
            // col快递公司
            // 
            this.col快递公司.FieldName = "快递公司";
            this.col快递公司.Name = "col快递公司";
            this.col快递公司.Visible = true;
            this.col快递公司.VisibleIndex = 14;
            this.col快递公司.Width = 24;
            // 
            // col运单号
            // 
            this.col运单号.FieldName = "运单号";
            this.col运单号.Name = "col运单号";
            this.col运单号.Visible = true;
            this.col运单号.VisibleIndex = 15;
            this.col运单号.Width = 24;
            // 
            // colSKU编码
            // 
            this.colSKU编码.FieldName = "SKU编码";
            this.colSKU编码.Name = "colSKU编码";
            this.colSKU编码.Visible = true;
            this.colSKU编码.VisibleIndex = 16;
            this.colSKU编码.Width = 24;
            // 
            // col条形码
            // 
            this.col条形码.FieldName = "条形码";
            this.col条形码.Name = "col条形码";
            this.col条形码.Visible = true;
            this.col条形码.VisibleIndex = 17;
            this.col条形码.Width = 24;
            // 
            // colPic
            // 
            this.colPic.Caption = "图片";
            this.colPic.Name = "colPic";
            this.colPic.Visible = true;
            this.colPic.VisibleIndex = 18;
            this.colPic.Width = 30;
            // 
            // textEdit
            // 
            this.textEdit.Name = "textEdit";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.skinRibbonGalleryBarItem,
            this.skinDropDownButtonItem,
            this.skinPaletteRibbonGalleryBarItem,
            this.btn_loadExcel,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barEditItem1,
            this.barButtonItem4,
            this.barEditItem2,
            this.barEditItem3,
            this.barEditItem6,
            this.barEditItem7,
            this.barEditItem8,
            this.barButtonItem5,
            this.barEditItem9,
            this.barEditItem10,
            this.barEditItem11});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 17;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage,
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5,
            this.repositoryItemTextEdit6,
            this.repositoryItemTextEdit7,
            this.repositoryItemTextEdit8,
            this.repositoryItemTextEdit9});
            this.ribbonControl.Size = new System.Drawing.Size(1366, 160);
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Caption = "skinRibbonGalleryBarItem";
            this.skinRibbonGalleryBarItem.Id = 1;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // skinDropDownButtonItem
            // 
            this.skinDropDownButtonItem.Id = 2;
            this.skinDropDownButtonItem.Name = "skinDropDownButtonItem";
            // 
            // skinPaletteRibbonGalleryBarItem
            // 
            this.skinPaletteRibbonGalleryBarItem.Caption = "skinPaletteRibbonGalleryBarItem";
            this.skinPaletteRibbonGalleryBarItem.Id = 3;
            this.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem";
            // 
            // btn_loadExcel
            // 
            this.btn_loadExcel.Caption = "加载订单数据";
            this.btn_loadExcel.Id = 2;
            this.btn_loadExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_loadExcel.ImageOptions.SvgImage")));
            this.btn_loadExcel.Name = "btn_loadExcel";
            this.btn_loadExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "当前查询结果";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "当前汇总结果";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "清空数据";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "订单号:";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.EditWidth = 150;
            this.barEditItem1.Id = 6;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "搜索";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "快递号:";
            this.barEditItem2.Edit = this.repositoryItemTextEdit2;
            this.barEditItem2.EditWidth = 150;
            this.barEditItem2.Id = 8;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "货品名:";
            this.barEditItem3.Edit = this.repositoryItemTextEdit3;
            this.barEditItem3.EditWidth = 150;
            this.barEditItem3.Id = 9;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // barEditItem6
            // 
            this.barEditItem6.Caption = "手机:";
            this.barEditItem6.Edit = this.repositoryItemTextEdit4;
            this.barEditItem6.EditWidth = 150;
            this.barEditItem6.Id = 10;
            this.barEditItem6.Name = "barEditItem6";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // barEditItem7
            // 
            this.barEditItem7.Caption = "姓名:";
            this.barEditItem7.Edit = this.repositoryItemTextEdit5;
            this.barEditItem7.EditWidth = 150;
            this.barEditItem7.Id = 11;
            this.barEditItem7.Name = "barEditItem7";
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // barEditItem8
            // 
            this.barEditItem8.Caption = "昵称:";
            this.barEditItem8.Edit = this.repositoryItemTextEdit6;
            this.barEditItem8.EditWidth = 150;
            this.barEditItem8.Id = 12;
            this.barEditItem8.Name = "barEditItem8";
            // 
            // repositoryItemTextEdit6
            // 
            this.repositoryItemTextEdit6.AutoHeight = false;
            this.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "清空条件";
            this.barButtonItem5.Id = 13;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barEditItem9
            // 
            this.barEditItem9.Caption = "颜色:";
            this.barEditItem9.Edit = this.repositoryItemTextEdit7;
            this.barEditItem9.EditWidth = 150;
            this.barEditItem9.Id = 14;
            this.barEditItem9.Name = "barEditItem9";
            // 
            // repositoryItemTextEdit7
            // 
            this.repositoryItemTextEdit7.AutoHeight = false;
            this.repositoryItemTextEdit7.Name = "repositoryItemTextEdit7";
            // 
            // barEditItem10
            // 
            this.barEditItem10.Caption = "数量:";
            this.barEditItem10.Edit = this.repositoryItemTextEdit8;
            this.barEditItem10.EditWidth = 150;
            this.barEditItem10.Id = 15;
            this.barEditItem10.Name = "barEditItem10";
            // 
            // repositoryItemTextEdit8
            // 
            this.repositoryItemTextEdit8.AutoHeight = false;
            this.repositoryItemTextEdit8.Name = "repositoryItemTextEdit8";
            // 
            // barEditItem11
            // 
            this.barEditItem11.Caption = "尺码:";
            this.barEditItem11.Edit = this.repositoryItemTextEdit9;
            this.barEditItem11.EditWidth = 150;
            this.barEditItem11.Id = 16;
            this.barEditItem11.Name = "barEditItem11";
            // 
            // repositoryItemTextEdit9
            // 
            this.repositoryItemTextEdit9.AutoHeight = false;
            this.repositoryItemTextEdit9.Name = "repositoryItemTextEdit9";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "工具栏";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_loadExcel);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup1.Text = "基础操作";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem7);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem8);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem9);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem11);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem10);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "查询条件";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "导出";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "其它";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "barEditItem3";
            this.barEditItem4.Edit = this.repositoryItemTextEdit3;
            this.barEditItem4.Id = 9;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // barEditItem5
            // 
            this.barEditItem5.Caption = "barEditItem3";
            this.barEditItem5.Edit = this.repositoryItemTextEdit3;
            this.barEditItem5.Id = 9;
            this.barEditItem5.Name = "barEditItem5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.LargeImage")));
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl;
            this.Text = "订单助手";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarButtonItem btn_loadExcel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn col来源;
        private DevExpress.XtraGrid.Columns.GridColumn col订单号;
        private DevExpress.XtraGrid.Columns.GridColumn col订单序号;
        private DevExpress.XtraGrid.Columns.GridColumn col品牌名;
        private DevExpress.XtraGrid.Columns.GridColumn col商品条码;
        private DevExpress.XtraGrid.Columns.GridColumn col商品款号;
        private DevExpress.XtraGrid.Columns.GridColumn col品类;
        private DevExpress.XtraGrid.Columns.GridColumn col商品名称;
        private DevExpress.XtraGrid.Columns.GridColumn col颜色;
        private DevExpress.XtraGrid.Columns.GridColumn col尺码;
        private DevExpress.XtraGrid.Columns.GridColumn col数量;
        private DevExpress.XtraGrid.Columns.GridColumn col收货人;
        private DevExpress.XtraGrid.Columns.GridColumn col联系电话;
        private DevExpress.XtraGrid.Columns.GridColumn col收货地址;
        private DevExpress.XtraGrid.Columns.GridColumn col快递公司;
        private DevExpress.XtraGrid.Columns.GridColumn col运单号;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU编码;
        private DevExpress.XtraGrid.Columns.GridColumn col条形码;
        private DevExpress.XtraGrid.Columns.GridColumn col图片;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarEditItem barEditItem6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraBars.BarEditItem barEditItem7;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraBars.BarEditItem barEditItem8;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarEditItem barEditItem4;
        private DevExpress.XtraBars.BarEditItem barEditItem5;
        private DevExpress.XtraBars.BarEditItem barEditItem9;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit7;
        private DevExpress.XtraBars.BarEditItem barEditItem10;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit8;
        private DevExpress.XtraBars.BarEditItem barEditItem11;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit9;
        private DevExpress.XtraGrid.Columns.GridColumn colPic;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private RepositoryItemImageComboBox textEdit;
    }
}
