using DiLifetimesDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiLifetimesDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LifetimeTestController : ControllerBase
    {
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        public LifetimeTestController(
            ITransientService transientService1,
            ITransientService transientService2,
            IScopedService scopedService1,
            IScopedService scopedService2,
            ISingletonService singletonService1,
            ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Transient1 = _transientService1.GetOperationId(),
                Transient2 = _transientService2.GetOperationId(),
                Scoped1 = _scopedService1.GetOperationId(),
                Scoped2 = _scopedService2.GetOperationId(),
                Singleton1 = _singletonService1.GetOperationId(),
                Singleton2 = _singletonService2.GetOperationId()
            });
        }
    }
}
