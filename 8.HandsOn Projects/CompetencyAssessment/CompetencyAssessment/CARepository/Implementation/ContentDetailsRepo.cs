using BusinessEntity.BEModels;
using BusinessEntity.Context;
using CARepository.Abstract;
using CARepository.RepoModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.Implementation
{
    public class ContentDetailsRepo : IContentDetailsRepo
    {
        CompetencyContext _context = new CompetencyContext();

        public CaseStudyDetail CreateCaseStudy(CreateCaseStudyViewModel createcaseStudyVM)
        {
            string responseMsg = String.Empty;
            CaseStudyDetail caseObj = new CaseStudyDetail();
            CaseStudySolution caseSolObjOne = new CaseStudySolution();
            CaseStudySolution caseSolObjTwo = new CaseStudySolution();
            CaseStudySolution caseSolObjThree = new CaseStudySolution();
            CaseStudySolution caseSolObjFour = new CaseStudySolution();

            try
            {
                caseObj.CaseStudyName = createcaseStudyVM.CaseStudyName;
                caseObj.AssessmentID = createcaseStudyVM.AssmtID;
                caseObj.ReviewStatus = false;
                caseObj.CareatedBy = createcaseStudyVM.CreatedBy;
                _context.CaseStudyDetailData.Add(caseObj);
                _context.SaveChanges();

                if (caseObj.CSID != null)
                {
                    try
                    {
                        caseSolObjOne.SolutionName = createcaseStudyVM.SolutionOne;
                        caseSolObjOne.CaseStudtID = caseObj.CSID;
                        caseSolObjOne.CompetencyID = createcaseStudyVM.SolutionOneId;
                        _context.CaseStudySolutionData.Add(caseSolObjOne);

                        caseSolObjTwo.SolutionName = createcaseStudyVM.SolutionTwo;
                        caseSolObjTwo.CaseStudtID = caseObj.CSID;
                        caseSolObjTwo.CompetencyID = createcaseStudyVM.SolutionTwoId;
                        _context.CaseStudySolutionData.Add(caseSolObjTwo);

                        caseSolObjThree.SolutionName = createcaseStudyVM.SolutionThree;
                        caseSolObjThree.CaseStudtID = caseObj.CSID;
                        caseSolObjThree.CompetencyID = createcaseStudyVM.SolutionThreeId;
                        _context.CaseStudySolutionData.Add(caseSolObjThree);

                        caseSolObjFour.SolutionName = createcaseStudyVM.SolutionFour;
                        caseSolObjFour.CaseStudtID = caseObj.CSID;
                        caseSolObjFour.CompetencyID = createcaseStudyVM.SolutionFourId;
                        _context.CaseStudySolutionData.Add(caseSolObjFour);

                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        responseMsg = ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                responseMsg = ex.Message;
            }

            return caseObj;
        }

        public List<AssessmentDetail> GetAssessmentDetail()
        {
            List<AssessmentDetail> assessmentList = new List<AssessmentDetail>();
            try
            {
                assessmentList = _context.AssessmentDetailData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return assessmentList;
        }

        public List<CompetencyDetail> GetCompetencyDetail()
        {
            List<CompetencyDetail> competencyList = new List<CompetencyDetail>();
            try
            {
                competencyList = _context.CompetencyDetailData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return competencyList;
        }
    }
}
