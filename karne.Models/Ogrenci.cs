using System;

namespace karne.Models
{
    public class Ogrenci
    {
        private string _ad;
        private string _soyad;
        private string _numara;
        private double _matematik;
        private double _turkce;
        private double _fen;
        private double _sosyal;

        public string Ad
        {
            get
            {
                return
                    _ad.Substring(0, 1).ToUpper() +
                    _ad.Substring(1).ToLower();
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("ad alanı boş olamaz.");
                }
                if (value.Length > 20)
                    throw new Exception(" ad alanı 20 karakterden uzun olamaz.");

                foreach(char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception(" kişinin adında rakam olamaz.");
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kişinin adında geçersiz karakter bulunmaktadır.");

                }

                _ad = value;
            }   
        }
        public string Soyad
        {
            get
            {
                return
                    _soyad.Substring(0, 1).ToUpper() +
                    _soyad.Substring(1).ToLower();
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("soyad alanı boş olamaz.");
                }
                if (value.Length > 20)
                    throw new Exception(" soyad alanı 20 karakterden uzun olamaz.");

                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception(" kişinin soyadında rakam olamaz.");
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kişinin soyadında geçersiz karakter bulunmaktadır.");

                }

                _soyad = value;

            }
        } 

        public string Numara
        {
            get
            {
                return _numara;
            }
            set
            {
                foreach(char rakam in value)
                {
                    if (!char.IsDigit(rakam))
                        throw new Exception("kişinin numarsında harf olamaz.");
                  
                }
                if (value.Length > 10 || value.Length < 5)
                    throw new Exception("kişinin numarası 5-10 hane arasında olmalıdır.");
                _numara = value;

            }

        }
        public double Matematik
        {
            get
            {
                return _matematik;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("kişinin notu 0-100 arasında olmalıdır.");
                }
                _matematik = value;

                if (value >= 50)
                    MatematikSonuc = true;
                else
                    MatematikSonuc = false;
            }
        }

        public bool MatematikSonuc { get; private set; }


        public double Fen
        {
            get
            {
                return _fen;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("kişinin notu 0-100 arasında olmalıdır.");
                }
                _fen = value;

                if (value >= 50)
                    FenSonuc = true;
                else
                    FenSonuc = false;
            }
        }

        public bool FenSonuc { get; private set; }
        public double Sosyal
        {
            get
            {
                return _sosyal;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("kişinin notu 0-100 arasında olmalıdır.");
                }
                _sosyal = value;

                if (value >= 50)
                    SosyalSonuc = true;
                else
                    SosyalSonuc = false;
            }
        }

        public bool SosyalSonuc { get; private set; }
        public double   Turkce
        {
            get
            {
                return _turkce;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("kişinin notu 0-100 arasında olmalıdır.");
                }
                _turkce = value;

                if (value >= 50)
                    TurkceSonuc = true;
                else
                    TurkceSonuc = false;
            }
        }

        public bool TurkceSonuc { get; private set; }

        public override string ToString()
        {
            return $" {Ad} {Soyad} [{Numara}] ";
        }

    }
}
