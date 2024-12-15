﻿using OBSProject.BusinessLayer.Abstract;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DtoLayer.TeacherDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Concrete
{
    public class TeacherManager : GenericService<ResultTeacherDto, CreateTeacherDto, UpdateTeacherDto, Teacher>, ITeacherService
    {
        public TeacherManager(IGenericRepository<Teacher> genericRepository) : base(genericRepository)
        {
        }
    }
}
