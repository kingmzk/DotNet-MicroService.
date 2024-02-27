﻿namespace Mango.Web.Utility
{
    public class SD
    {
        public static string CouponAPIBase { get; set; }
        public static string AuthApiBase { get; set; }

        public static string RoleAdmin = "ADMIN";

        public static string RoleCustomer = "CUSTOMER";

        public static string TokenCookie = "JWTToken";

        public static string ProductAPIBase { get; set; }
        
        public static string ShoppingCartAPIBase { get; set; }

        public static string OrderAPIBase { get; set; }

        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public const string Status_Pending = "Pending";
        public const string Status_Approved = "Approved";
        public const string Status_ReadyForPickup = "ReadyForPickup";
        public const string Status_Completed = "Completed";
        public const string Status_Refunded = "Refunded";
        public const string Status_Canceled = "Canceled";   
    }
}
