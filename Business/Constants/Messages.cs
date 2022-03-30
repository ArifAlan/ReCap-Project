using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
          //FOR CAR
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "İsim hatalı";
        public static string CarsListed="Arabalar listelendi";
        public static string CarDeleted="Araba silindi";
        public static string CarUpdated="Araba güncellendi";


        // FOR BRAND
        public static string BrandAdded="Brand eklendi";
        public static string BrandDeleted= "Brand silindi";
        public static string BrandUpdated= "Brand güncellendi";
         
        // FOR COLOR
        public static string ColorAdded="Color eklendi";
        public static string ColorDeleted="Color silindi";
        public static string ColorUpdated="Color güncellendi";

        // For User
        public static string UserAdded="User eklendi";
        public static string UserDeleted="User silindi";
        public static string UserListed="User listelendi";
        public static string UserUpdated="User güncellendi";

        // FOR Customer
        public static string CustomerAdded="Customer eklendi";
        public static string CustomerDeleted= "Customer silindi";
        public static string CustomerListed= "Customers listelendi";
        public static string CustomerUpdated= "Customer güncellendi";

        // FOR RENTAL

        public static string RentalAdded="Rental eklendi";
        public static string RentalDeleted="Rental silindi";
        public static string RentalListed="Rental listelendi";
        public static string RentalUpdated = "Rental güncellendi";

        //SecuredOperation
        public static string AuthorizationDenied="yetkiniz yok";
        //AuthManager
        public  static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Hatalı giriş";
        public static string SuccessfulLogin="Başaralı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
