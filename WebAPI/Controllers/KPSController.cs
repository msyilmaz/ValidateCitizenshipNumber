using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KPSController : ControllerBase
    {
        private readonly KPS.KPSPublicSoapClient _kpsClient;
        public KPSController()
        {
            _kpsClient = new KPS.KPSPublicSoapClient(KPS.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
        }

        [HttpPost]
        public async Task<IActionResult> ValidateCitizenshipNumber(ValidateCitizenshipNumberRequestDto request)
        {
            if (request == null)
                return BadRequest("request is required");

            if (string.IsNullOrWhiteSpace(request.Ad))
                return BadRequest("name is required");

            if (string.IsNullOrWhiteSpace(request.Soyad))
                return BadRequest("surname is required");

            if ( request.DogumYili  < DateTime.MinValue.Year || request.DogumYili  > DateTime.MaxValue.Year )
                return BadRequest("birthyear is required");

            if (request.TCKimlikNo <= 0)
                return BadRequest("citizenshipnumber is required");
            
            var kpsResponse = await _kpsClient.TCKimlikNoDogrulaAsync(request.TCKimlikNo,request.Ad,request.Soyad,request.DogumYili);

            return Ok(kpsResponse.Body.TCKimlikNoDogrulaResult);

        }
    }
}
