using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OdevProjeesi
{
    public class Kisi
    {
        private string _ad, _soyad, _telefon, _email, _tckn;

        public string Ad 
        {
            get =>this._ad; 
            set
            {
                NameValid(value,"Ad");
                value = value.Trim();
                this._ad = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public string Soyad 
        { 
            get => this._soyad; 
            set
            {
                NameValid(value, "Soyad");
                value = value.Trim();
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Telefon 
        { 
            get => this._telefon; 
            set
            {
                if (!(value.StartsWith("0")))
                {
                    throw new Exception("Girdiğiniz numara 0 ile başlamalıdır..");
                }
                if (!(value.Length == 11))
                {
                    throw new Exception("Numaranızı eksik girmemelisiniz..");
                }
                foreach (char harf in value)
                {
                    if (!(char.IsDigit(harf)))
                    {
                        throw new Exception("Numaranız sadece rakamlardan oluşmalıdır..");
                    }
                }
                this._telefon = value;
            }
        }

        public string Email 
        {
            get => this._email; 
            set
            {
                Regex rg = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!(rg.IsMatch(value)))
                {
                    throw new Exception("Lütfen mail adresinin doğruluğundan emin olunuz..");
                }
                this._email = value;    
            }
        }

        public string TCKN 
        { 
            get=>this._tckn; 
            set
            {
                Regex rg = new Regex(@"^[1-9]{1}[0-9]{9}[02468]{1}$");
                if (!(rg.IsMatch(value)))
                {
                    throw new Exception("Lütfen TCKN'nin doğruluğundan emin olunuz..");
                }
                this._tckn = value;
            }
        }

        private void NameValid(string value, string propAdi)
        {
            foreach (char harf in value)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                {
                    throw new Exception($"{propAdi} girişi sadece harf ve boşluk içerebilir");
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }
    }
}
