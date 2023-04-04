using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using Graduation.DAL;
using Graduation.DAL.Entitiys;
using Graduation.DAL.Repository;

namespace Graduation.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private GenericRepository<GroupEntity> groupRepository;
        private GenericRepository<InstituteEntity> instituteRepository;
        private GenericRepository<LecturerEntitiy> lecturerRepository;
        private GenericRepository<LecturerGroupEntity> lecturerGroupRepository;
        private GenericRepository<ChairsEntity> pulpitRepository;
        private GenericRepository<SectionEntitiy> sectionRepository;
        private GenericRepository<StudentEntity> studentRepository;
        private GenericRepository<GradedEntity> gradedRepository;


        private GraduationDBContext context;

        public UnitOfWork()
        {
            context = new GraduationDBContext();
        }

        public GenericRepository<GroupEntity> GroupRepository
        {
            get
            {
                if (groupRepository == null)
                    groupRepository = new GenericRepository<GroupEntity>(context);
                return groupRepository;
                
            }
        }
        public GenericRepository<InstituteEntity> InstituteRepository
        {
            get
            {
                if (instituteRepository == null)
                    instituteRepository = new GenericRepository<InstituteEntity>(context);
                return instituteRepository;

            }
        }

        public GenericRepository<LecturerEntitiy> LecturerRepository
        {
            get
            {
                if (lecturerRepository == null)
                    lecturerRepository = new GenericRepository<LecturerEntitiy>(context);
                return lecturerRepository;

            }
        }
        public GenericRepository<LecturerGroupEntity> LecturerGroupRepository
        {
            get
            {
                if (lecturerGroupRepository == null)
                    lecturerGroupRepository = new GenericRepository<LecturerGroupEntity>(context);
                return lecturerGroupRepository;

            }
        }
        public GenericRepository<ChairsEntity> PulpitRepository
        {
            get
            {
                if (pulpitRepository == null)
                    pulpitRepository = new GenericRepository<ChairsEntity>(context);
                return pulpitRepository;

            }
        }
        public GenericRepository<SectionEntitiy> SectionRepository
        {
            get
            {
                if (sectionRepository == null)
                    sectionRepository = new GenericRepository<SectionEntitiy>(context);
                return sectionRepository;

            }
        }
        public GenericRepository<StudentEntity> StudentRepository
        {
            get
            {
                if (studentRepository == null)
                    studentRepository = new GenericRepository<StudentEntity>(context);
                return studentRepository;

            }
        }

        public GenericRepository<GradedEntity> GradedRepository
        {
            get
            {
                if (gradedRepository == null)
                    gradedRepository = new GenericRepository<GradedEntity>(context);
                return gradedRepository;

            }
        }
    }
}
