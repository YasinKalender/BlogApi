using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Tools.JWT
{
    public class JwtInfo
    {

        public const string Issuer= "http://localhost:58353"; //Bu tokenı oluşturan kişi
        public const string Auidence = "http://localhost:5000";//Bu tokenı kullanıcak kişi
        public const string SecurityKey = "yasinyasinyasin1";//Token şifresi

    }
}
