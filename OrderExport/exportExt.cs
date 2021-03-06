﻿using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace OrderExport
{
    public static class exportExt
    {
        /// <summary>
        /// DevExpress通用导出Excel,支持多个控件同时导出在同一个Sheet表
        /// eg:ExportToXlsx("",gridControl1,gridControl2);
        /// 将gridControl1和gridControl2的数据一同导出到同一张工作表
        /// </summary>
        /// <param name="title">文件名</param>
        /// <param name="panels">控件集</param>
        public static void ExportToExcel(string title, GridControl panels)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = title;
            saveFileDialog.Title = "导出Excel";
            saveFileDialog.Filter = "Excel文件(*.xlsx)|*.xlsx|Excel文件(*.xls)|*.xls";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
                return;
            string FileName = saveFileDialog.FileName;
            var ps = new PrintingSystem();
            CompositeLink link = new CompositeLink(ps);
            ps.Links.Add(link);
            link.Links.Add(CreatePrintableLink(panels));
            link.Landscape = true;//横向          
            //判断是否有标题，有则设置        
            //link.CreateDocument(); //建立文档
            try
            {
                int count = 1;
                //在重复名称后加（序号）
                while (File.Exists(FileName))
                {
                    if (FileName.Contains(")."))
                    {
                        int start = FileName.LastIndexOf("(");
                        int end = FileName.LastIndexOf(").") - FileName.LastIndexOf("(") + 2;
                        FileName = FileName.Replace(FileName.Substring(start, end), string.Format("({0}).", count));
                    }
                    else
                    {
                        FileName = FileName.Replace(".", string.Format("({0}).", count));
                    }
                    count++;
                }
                if (FileName.LastIndexOf(".xlsx") >= FileName.Length - 5)
                {
                    XlsxExportOptions options = new XlsxExportOptions();
                    link.ExportToXlsx(FileName, options);
                }
                else
                {
                    XlsExportOptions options = new XlsExportOptions();
                    link.ExportToXls(FileName, options);
                }
                if (DevExpress.XtraEditors.XtraMessageBox.Show("保存成功，是否打开文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    System.Diagnostics.Process.Start(FileName);//打开指定路径下的文件
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 创建打印Componet
        /// </summary>
        /// <param name="printable"></param>
        /// <returns></returns>
        private static PrintableComponentLink CreatePrintableLink(IPrintable printable)
        {
            // var chart = printable as GridControl;
            // chart.pri
            // if (chart != null)
            //     chart.OptionsPrint.SizeMode = DevExpress.XtraGrid.Printing.PrintSizeMode.Stretch;


            PrintableComponentLink printableLink = new PrintableComponentLink() { Component = printable };
            return printableLink;
        }
    }
}
