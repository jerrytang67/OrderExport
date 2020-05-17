using System;

namespace OrderExport
{
    public class DataDto : IEquatable<DataDto>
    {
        public string 来源 { get; set; }
        public string 订单号 { get; set; }
        public string 订单序号 { get; set; }
        public string 品牌名 { get; set; }
        public string 商品条码 { get; set; }
        public string 商品款号 { get; set; }
        public string 品类 { get; set; }
        public string 商品名称 { get; set; }
        public string 颜色 { get; set; }
        public string 尺码 { get; set; }
        public string 数量 { get; set; }
        public string 收货人 { get; set; }
        public string 联系电话 { get; set; }
        public string 收货地址 { get; set; }
        public string 快递公司 { get; set; }
        public string 运单号 { get; set; }
        public string SKU编码 { get; set; }
        public string 条形码 { get; set; }

        public bool Equals(DataDto other)
        {
            return this.订单号 == other.订单号;
        }

        public override int GetHashCode()
        {
            return 订单号.GetHashCode();
        }
    }
}
