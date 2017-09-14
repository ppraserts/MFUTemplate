namespace MFU.DataAccess
{
    public static class SqlText
    {
        public static readonly string DocumentCategory_Select = "SELECT * FROM DocumentCategory;";
        public static readonly string DocumentCategory_Select_ByID = "SELECT * FROM DocumentCategory WHERE Id = @DocumentCategoryID;";
        public static readonly string DocumentCategory_Select_WithDetail = "SELECT * FROM DocumentCategory AS DC LEFT JOIN Document AS D ON DC.Id = D.DocumentCategoryID;";
    }
}