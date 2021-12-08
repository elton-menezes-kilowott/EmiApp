using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmiController : ControllerBase
    {
        [HttpPost]
        [Route("api/[controller]/CalculateMontlyEmi")]
        public Response CalculateMonthlyEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();

            var response = new Response();

            var emiMonthly = emiCalculator.CalculateMonthlyEmi(request);
            return emiMonthly;
        }

        [HttpPost]
        [Route("api/[controller]/CalculateContinousEmi")]
        public Response CalculateContinousEmi(Request request)
        {
            ICalculator emiCalcualtor = new Calculator();

            var response = new Response();

            var emiContinous = emiCalcualtor.CalculateContinousEmi(request);
            return emiContinous;
        }

        [HttpPost]
        [Route("api/[controller]/CalculateDailyEmi")]
        public Response CalculateDailyEmi(Request request)
        {
            ICalculator emiCalcualtor = new Calculator();

            var response = new Response();

            var emiDaily = emiCalcualtor.CalculateDailyEmi(request);
            return emiDaily;
        }
    }
}
