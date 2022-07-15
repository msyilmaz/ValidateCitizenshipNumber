# ValidateCitizenshipNumber

Türkiye Cumhuriyeti Kimlik Numarası Doğrulama servis entegrasyonu. 
.Net 5.0 ile hazırlanmıştır. 
**https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx** adresindeki web servis kullanılarak oluşturulmuştur.

Request : 
{
  "ad": "string",
  "soyad": "string",
  "dogumYili": 0,
  "tcKimlikNo": 0
}

Response :
(200) true/false
(400) name is required
(400) surname is required
(400) birthyear is required
(400) citizenshipnumber is required
