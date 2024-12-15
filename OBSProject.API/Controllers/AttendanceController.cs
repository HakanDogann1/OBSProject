using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBSProject.BusinessLayer.Abstract;
using OBSProject.DtoLayer.AttendanceDtos;

namespace OBSProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;

        public AttendanceController(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var values = await _attendanceService.GetAllAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAttendance(CreateAttendanceDto createAttendanceDto)
        {
            await _attendanceService.AddAsync(createAttendanceDto);
            return Ok();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _attendanceService.GetByIdAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateAttendance(UpdateAttendanceDto updateAttendanceDto)
        {
            return Ok(_attendanceService.Update(updateAttendanceDto));
        }
        [HttpDelete("id")]
        public IActionResult Remove(int id)
        {
            _attendanceService.Delete(id);
            return Ok();
        }

    }
}
