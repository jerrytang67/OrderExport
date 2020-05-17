﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraRichEdit.SpellChecker;
using OfficeOpenXml;

namespace OrderExport
{
    public partial class MainForm : RibbonForm
    {

        public Configuration config { get; }


        public MainForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a ExcelDataSource asynchronously
            //excelDataSource1.FillAsync();
            config = ConfigurationManager.
                OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);

            this.picPath.EditValue = config.AppSettings.Settings["picPath"].Value;


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oldData = this.gridControl.DataSource as List<DataDto> ?? new List<DataDto>();


            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var xmlResult = new List<DataDto>();
                    using (var memoryStream = new MemoryStream())
                    {
                        openFileDialog.OpenFile().CopyTo(memoryStream);
                        using (var package = new ExcelPackage(memoryStream))
                        {
                            var worksheet = package.Workbook.Worksheets[1]; // Tip: To access the first worksheet, try index 1, not 0
                            int rowCount = worksheet.Dimension.Rows;
                            int ColCount = worksheet.Dimension.Columns;
                            for (int row = 2; row <= rowCount; row++)
                            {
                                var model = new DataDto();
                                for (int col = 1; col <= ColCount; col++)
                                {
                                    switch (col)
                                    {
                                        case 1:
                                            model.来源 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 2:
                                            model.订单号 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 3:
                                            model.订单序号 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 4:
                                            model.品牌名 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 5:
                                            model.商品条码 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 6:
                                            model.商品款号 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 7:
                                            model.品类 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 8:
                                            model.商品名称 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 9:
                                            model.颜色 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 10:
                                            model.尺码 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 11:
                                            model.数量 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 12:
                                            model.收货人 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 13:
                                            model.联系电话 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 14:
                                            model.收货地址 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 15:
                                            model.快递公司 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 16:
                                            model.运单号 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 17:
                                            model.SKU编码 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                        case 18:
                                            model.条形码 = worksheet.Cells[row, col].Value?.ToString();
                                            break;
                                    }
                                }

                                model.图片 = Path.Combine(picPath.EditValue.ToString(), model.商品款号 + ".jpg"); ;
                                xmlResult.Add(model);
                            }
                        }
                    }

                    var concat = false;

                    if (oldData.Count > 0)
                    {
                        concat = DevExpress.XtraEditors.XtraMessageBox.Show(
                            "是否在现有数据中追加？",
                            "提示",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK;
                    }

                    if (concat)
                    {


                        gridControl.DataSource = oldData.Concat(xmlResult).ToList();
                    }
                    else
                    {
                        gridControl.DataSource = xmlResult;
                    }

                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ConfirmDelete() == DialogResult.OK)
            {
                // excelDataSource1.FileName = "";
                // excelDataSource1.Fill(new List<IParameter>());
                this.gridControl.DataSource = null;
            }
        }

        private void gridControl_MouseHover(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }


        /// <summary>
        /// 确认删除对话框
        /// </summary>
        /// /// <returns>用户点击结果</returns>
        public DialogResult ConfirmDelete()
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(
                "确定要删除吗？",
                "提示",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
        }

        private void gridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "photo" && e.IsGetData)
            {
                var row = e.Row as DataDto;

                // row["col商品款号"];
                //RefImage是存储图片路径的那一列
                string filePath = row.图片;//row["col商品款号"] + "1.png";
                Image img = null;
                try
                {
                    //判断图片路径是否为网络路径
                    if (UrlDiscern(filePath))
                    {
                        //文件是否存在
                        if (RemoteFileExists(filePath))
                        {
                            //读取文件
                            using (WebClient wc = new WebClient())
                            {
                                img = new Bitmap(wc.OpenRead(filePath));
                            }
                        }
                    }
                    // 判断本地文件是否存在
                    else if (LocalFileExists(filePath))
                    {
                        //加载本地图片
                        img = Image.FromFile(filePath);
                    }
                    //pictureEdit列绑定图片
                    e.Value = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// 判断远程文件是否存在
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <returns></returns>
        public bool RemoteFileExists(string fileUrl)
        {
            HttpWebRequest re = null;
            HttpWebResponse res = null;
            try
            {
                re = (HttpWebRequest)WebRequest.Create(fileUrl);
                res = (HttpWebResponse)re.GetResponse();
                if (res.ContentLength != 0)
                {
                    //MessageBox.Show("文件存在");
                    return true;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("无此文件");
                return false;
            }
            finally
            {
                if (re != null)
                {
                    re.Abort();//销毁关闭连接
                }
                if (res != null)
                {
                    res.Close();//销毁关闭响应
                }
            }
            return false;
        }
        /// <summary>
        /// 判断本地文件是否存在
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool LocalFileExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 识别urlStr是否是网络路径
        /// </summary>
        /// <param name="urlStr"></param>
        /// <returns></returns>
        public bool UrlDiscern(string urlStr)
        {
            if (Regex.IsMatch(urlStr,
                @"((http|ftp|https)://)(([a-zA-Z0-9\._-]+\.[a-zA-Z]{2,6})|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(:[0-9]{1,4})*(/[a-zA-Z0-9\&%_\./-~-]*)?")
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                string path = "output.xlsx";
                this.gridControl.ExportToXlsx(path);
                // Open the created XLSX file with the default application.
                Process.Start(path);
            }

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.barEditItem2.EditValue = null;
            gridView.Columns["订单号"].ClearFilter();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lines = barEditItem2.EditValue.ToString().Split(new[] { Environment.NewLine }
                    , StringSplitOptions.RemoveEmptyEntries);

            if (lines.Length <= 0) return;

            var sb = new StringBuilder();
            sb.Append("[订单号] In (");
            foreach (var line in lines)
            {
                sb.Append($"'{line}'");
            }
            sb.Append(")");

            gridView.Columns["订单号"].FilterInfo = new ColumnFilterInfo(sb.ToString());

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.picPath.EditValue = fbd.SelectedPath;

                    config.AppSettings.Settings["picPath"].Value = fbd.SelectedPath;
                    config.Save();
                    ConfigurationManager.RefreshSection("appSettings");


                    // Properties.Settings.Default.picPath = fbd.SelectedPath;
                    // Properties.Settings.Default.Save();
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("还未做");
        }
    }
}
