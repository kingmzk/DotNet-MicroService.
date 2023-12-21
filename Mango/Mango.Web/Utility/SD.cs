namespace Mango.Web.Utility
{
    public class SD
    {
        public static string CouponAPIBase { get; set; }
        public static string AuthApiBase { get; set; }

        public static string RoleAdmin = "ADMIN";

        public static string RoleCustomer = "CUSTOMER";

        public static string TokenCookie = "JWTToken";

        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
