using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //Parametre olarak List<OperationClaim> operationClaims'i de göndermemin sebebi oluşturacağım token'a User'ımın claimlerininde içinde olması
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);//Arayüzde kullanıcı ID ve Şifresini yazdı, girş yap dediğinde bizim API'mize geldi. giriş yap dediğinde bizim bu CreateToken operasyonumuz çalışacak.Eğer giriş bilgileri doğru ise ilgili kullanıcı için veri tabanına gidecek, veritabanından bu kullanıcının clamilerini bulucak(yetkilerini) orada bir tane JWT üretecek daha sonra onları client e verecek.
    }//ilgil
}
