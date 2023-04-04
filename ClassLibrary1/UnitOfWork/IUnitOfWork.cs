using DataAccessLayer.Entities;
using Graduation.DAL;
using Graduation.DAL.Entitiys;
using Graduation.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduation.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        GenericRepository<GroupEntity> GroupRepository { get; }
        GenericRepository<InstituteEntity> InstituteRepository { get; }
        GenericRepository<LecturerEntitiy> LecturerRepository { get; }
        GenericRepository<LecturerGroupEntity> LecturerGroupRepository { get; }
        GenericRepository<ChairsEntity> PulpitRepository { get; }
        GenericRepository<SectionEntitiy> SectionRepository { get; }
        GenericRepository<StudentEntity> StudentRepository { get; }
        GenericRepository<GradedEntity> GradedRepository { get; }
    }
}
