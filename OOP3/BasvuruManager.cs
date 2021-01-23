using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        //Bu yapıyı liste ile değilde teklide yapabilirdik List<ILoggerService> değilde ILoggerService loggerService şeklinde.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvurann bilgilerini değerlendirme 
            // 
            krediManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
           foreach(IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
