//using DataAccessLayer.Entities;
//using Graduation.BLL.BLConract;
//using Graduation.DAL.UnitOfWork;
//using Gradutation.Models;
//using Models.Mappers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Graduation.BLL.AccountBL
//{
//    public class LecturerBL : ILecturerBL
//    {
//        private readonly IUnitOfWork unitOfWork;

//        public LecturerBL(IUnitOfWork unitOfWork)
//        {
//            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
//        }
//        public void Insert(LecturerModel student)
//        {
//            LecturerEntitiy studentEntity = Mapper<LecturerModel, LecturerEntitiy>.Map(student);

//            //studentEntity. = 5;
//            unitOfWork.LecturerRepository.Insert(studentEntity);

//            unitOfWork.LecturerRepository.Save();
//        }
//        public void Update(LecturerModel student)
//        {
//            LecturerEntitiy studentEntity = Mapper<LecturerModel, LecturerEntitiy>.Map(student);

//            //studentEntity.GroupId = 5;
//            unitOfWork.LecturerRepository.Update(studentEntity);

//            unitOfWork.LecturerRepository.Save();
//        }

//        public LecturerEntitiy GetById(string id)
//        {
//            return unitOfWork.LecturerRepository.GetById(id);
//        }

//        public void Remove(string id)
//        {
//            unitOfWork.LecturerRepository.Delete(id);
//        }
//    }
//}
