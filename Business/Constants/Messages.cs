using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz ";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string Productlisted="ürünler listelendi";
        public static string ProductCountEror = "category eror fazla ürün";
        public static string ProductNameOlreadyExist = "Bu katagoride aynı ürün bulunmakta";
        public static string CateGoryLimit = "kategori limiti aşıldı";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş Başaralı";
        public static string UserAlreadyExists = "Var olan kullanıcı adı";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
