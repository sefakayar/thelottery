using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loto
{
    class sayisal
    {
        public sayisal()
        {
        }
        //çekilen sayiları sıralar
        public int[] sirala(int[] dizi)
        {
            int temp;

            for (int i = 0; i < dizi.Length; i++)
                for(int j=i+1; j<dizi.Length; j++)
                if (dizi[j] < dizi[i])
                {
                    temp = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = temp;
                }
            return dizi;
        }
        //belirtilen aralıkta rasgele bir sayı döndürür
        public int sayi_cek(int min, int max)
        {
            Random r = new Random();
            int sayi;
            sayi = r.Next(min, max);
            return sayi;
        }
        //gönderilen sayının gönderilen dizinin içinde olup
        //olmadığını kontrol eder
        public bool varmi(int sayi, int[] dizi)
        {
            bool var = false;
            for (int i = 0; i < dizi.Length; i++)
                if (dizi[i] == sayi)
                {
                    var = true;
                    break;
                }
            return var;
        }
    }
}
