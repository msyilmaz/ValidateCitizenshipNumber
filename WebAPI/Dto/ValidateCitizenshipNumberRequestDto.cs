namespace WebAPI
{
    public class ValidateCitizenshipNumberRequestDto
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TCKimlikNo { get; set; }
    }
}