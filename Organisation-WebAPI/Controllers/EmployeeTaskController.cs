using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organisation_WebAPI.Dtos.EmployeeTaskDto;
using Organisation_WebAPI.Services.EmployeeTasks;

namespace Organisation_WebAPI.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeTaskController : ControllerBase
    {
        private readonly IEmployeeTaskService _employeeTaskService;

        public EmployeeTaskController(IEmployeeTaskService employeeTaskService)
        {
            _employeeTaskService = employeeTaskService;
        }

        [HttpGet("GetAllEmployeeTasks")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeTaskDto>>> GetEmployeeTasks()
        {
            return Ok(await _employeeTaskService.GetAllEmployeeTasks());
        }

        [HttpPost("CreateEmployeeTasks")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeTaskDto>>> AddEmployeeTask(AddEmployeeTaskDto newEmployeeTask)
        {
            return Ok(await _employeeTaskService.AddEmployeeTask(newEmployeeTask));
        }

        
        [HttpDelete("DeleteEmployeeTask")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeTaskDto>>> DeleteEmployeeTask(int id){
            return Ok(await _employeeTaskService.DeleteEmployeeTask(id));
        }

        [HttpGet("GetEmployeeTaskById")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeTaskDto>>> GetEmployeeTask(int id)
        {
            return Ok(await _employeeTaskService.GetEmployeeTaskById(id));
        }


        [HttpPut("UpdateEmployeeTask")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeTaskDto>>> UpdateEmployeeTask(UpdateEmployeeTaskDto updatedEmployeeTask,int id){
            return Ok(await _employeeTaskService.UpdateEmployeeTask(updatedEmployeeTask,id));
        }

        [HttpPut("UpdateEmployeeTaskStatus")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeTaskDto>>> UpdateEmployee(UpdateEmployeeTaskStatusDto updatedEmployeeTaskStatus,int id){
            return Ok(await _employeeTaskService.UpdateEmployeeTaskStatus(updatedEmployeeTaskStatus,id));
        }
    }
}