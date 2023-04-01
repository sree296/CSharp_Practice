using BusinessEntity.BEModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.RepoModels
{
    public class CreateCaseStudyViewModel
    {
        [DisplayName("Assesment")]
        public int AssmtID { get; set; }

        [DisplayName("Case Study Name")]
        public string CaseStudyName { get; set; }

        [DisplayName("Solution 1")]
        public string SolutionOne { get; set; }

        [DisplayName("Competency")]
        public int SolutionOneId { get; set; }

        [DisplayName("Solution 2")]
        public string SolutionTwo { get; set; }

        [DisplayName("Competency")]
        public int SolutionTwoId { get; set; }

        [DisplayName("Solution 3")]
        public string SolutionThree { get; set; }

        [DisplayName("Competency")]
        public int SolutionThreeId { get; set; }

        [DisplayName("Solution 4")]
        public string SolutionFour { get; set; }

        [DisplayName("Competency")]
        public int SolutionFourId { get; set; }

        public string? CreatedBy { get; set; }
        public List<AssessmentDetail>? Assessments { get; set; }
        public List<CompetencyDetail>? Competencies { get; set; }

    }
}
