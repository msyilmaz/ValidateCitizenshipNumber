# ValidateCitizenshipNumber

Türkiye Cumhuriyeti Kimlik Numarası Doğrulama servis entegrasyonu. <br />
.Net 5.0 ile hazırlanmıştır. <br />
**https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx** adresindeki web servis kullanılarak oluşturulmuştur.<br />

Request : 
{
  "ad": "string",
  "soyad": "string",
  "dogumYili": 0,
  "tcKimlikNo": 0
}

Response :<br />
(200) true/false<br />
(400) name is required<br />
(400) surname is required<br />
(400) birthyear is required<br />
(400) citizenshipnumber is required<br />
