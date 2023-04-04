﻿using DataAccessLayer.Entities;
using Gradutation.Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.BLConract
{
    public interface IStudentBL
    {
        StudentModel GetByIdentityNumber(string IdentityNumber);
        void Remove(string IdentityNumber);
        void Insert(StudentModel student);
        void Update(StudentModel student);
        void Update1(GradedModel student);
    }
}
