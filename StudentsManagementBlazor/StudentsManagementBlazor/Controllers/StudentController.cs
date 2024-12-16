﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsManagementBlazor.Shared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        [HttpGet("All-Students")]
        public async Task<ActionResult<List<Student>>> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetAllStudentsAsync();

            return Ok(students);
        }

        [HttpGet("Single-Student/{id}")]
        public async Task<ActionResult<Student>> GetSingleStudentAsync(int id)
        {
            var student = await _studentRepository.GetStudentByIdAsync(id);

            return Ok(student);
        }

        [HttpPost("Add-Student")]
        public async Task<ActionResult<Student>> AddNewStudentAsync(Student student)
        {
            var newstudent = await _studentRepository.AddStudentAsync(student);

            return Ok(newstudent);
        }

        [HttpPost("Update-Student")]
        public async Task<ActionResult<Student>> UpdateStudentAsync(Student student)
        {
            var updatetudent = await _studentRepository.UpdateStudentAsync(student);

            return Ok(updatetudent);
        }

        [HttpPost("Delete-Student/{id}")]
        public async Task<ActionResult<Student>> DeleteStudentAsync(int id)
        {
            var deletestudent = await _studentRepository.DeleteStudentAsync(id);

            return Ok(deletestudent);
        }
    }
}
