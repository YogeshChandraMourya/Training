namespace ADO.Models
{
    public static class CommonVariables
    {
        public static string insertbr = $"insert into brands(brand_id,brand_name) values (@BrandId,@BrandName)";
        public static string deletebr = $"delete from brands where brand_id=@BrandId";
        public static string updatebr = $"update brands set brand_id=@BrandId,brand_name=@BrandName where brand_id=@ChangeId";
    }
}
