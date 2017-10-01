namespace MFU.DataAccess
{
    public static class SqlText
    {
        public static readonly string DocumentCategory_Select = "SELECT * FROM DocumentCategory;";
        public static readonly string DocumentCategory_Select_ByID = "SELECT * FROM DocumentCategory WHERE Id = @DocumentCategoryID;";
        public static readonly string DocumentCategory_Select_WithDetail = "SELECT * FROM DocumentCategory AS DC LEFT JOIN Document AS D ON DC.Id = D.DocumentCategoryID;";

        public static readonly string Request_Select = "select request.REQUESTID as Id, request.CREATEDATETIME, requesttype.REQUESTTYPEID as RequestTypeId, requesttype.REQUESTTYPEID as Id, requesttype.Price, requesttype.REQUESTTYPENAME from avsreg.request JOIN avsreg.requesttype on request.REQUESTTYPEID = requesttype.REQUESTTYPEID WHERE request.REQUESTID in (3479, 3498) ";
        public static readonly string Request_Select_ByID = "select request.REQUESTID as Id, request.CREATEDATETIME, requesttype.REQUESTTYPEID as RequestTypeId, requesttype.REQUESTTYPEID as Id, requesttype.Price, requesttype.REQUESTTYPENAME from avsreg.request JOIN avsreg.requesttype on request.REQUESTTYPEID = requesttype.REQUESTTYPEID WHERE request.REQUESTID = @REQUESTID ";

    }
}