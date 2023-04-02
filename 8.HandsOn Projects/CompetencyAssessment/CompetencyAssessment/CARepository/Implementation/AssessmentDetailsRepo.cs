using BusinessEntity.BEModels;
using BusinessEntity.Context;
using CARepository.Abstract;
using CARepository.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.Implementation
{
    public class AssessmentDetailsRepo : IAssessmentDetailsRepo
    {
        CompetencyContext _context = new CompetencyContext();
        public AssessmentDetail CreateAssessment(CreateAssessmentViewModel createAssment)
        {
            AssessmentDetail assmtObj = new AssessmentDetail();

            string responseMsg = String.Empty;

            try
            {
                assmtObj.AssmtName = createAssment.AssmtName;
                assmtObj.AssmtDate = createAssment.AssmtDate;
                assmtObj.isActive = false;
                assmtObj.Description = createAssment.Description;
                assmtObj.CreatedBy = createAssment.CreatedBy;
                assmtObj.CreatedDate = DateTime.Now;
                _context.AssessmentDetailData.Add(assmtObj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                responseMsg = ex.Message;
                return assmtObj;
            }

            return assmtObj;
        }

        public List<AssessmentDetail> GetAllAssessments()
        {
            List<AssessmentDetail> assessments = new List<AssessmentDetail>();

            try
            {
                assessments = _context.AssessmentDetailData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return assessments;
        }

        public AssessmentDetail ActivateAssessment(ActivateAssessmentViewModel activateAssmtVM)
        {
            AssessmentDetail assmtObj = _context.AssessmentDetailData.FirstOrDefault(x => x.AssmtID == activateAssmtVM.AssmtId);

            if(assmtObj != null)
            {
                try
                {
                    assmtObj.isActive = activateAssmtVM.isActive;
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    string str = ex.Message;
                }
            }

            return assmtObj;
        }
    }
}
