using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeConverter
{
    class GradeRange
    {
        double _minimumScore;
        double _maximumGrade;
        string _letterGrade;
        List<GradeRange> _gradeRangeList;

        public GradeRange()
        {
            InitializeGradeRangeList();
        }

        private GradeRange(double minGrade, double maxGrade, string letterGrade)
        {
            SetGraderange(minGrade, maxGrade, letterGrade);
        }

        public void SetGraderange(double minGrade, double maxGrade, string letterGrade)
        {
            _minimumScore = minGrade;
            _maximumGrade = maxGrade;
            _letterGrade = letterGrade;
        }

        public string GetLetterGrade(double score)
        {
            for (int i = _gradeRangeList.Count() - 1; i >= 0; i--)
            {
                if (score <= _gradeRangeList[i]._maximumGrade && score >= _minimumScore)
                {
                    return _gradeRangeList[i]._letterGrade;
                }
            }

            return "NA";
        }

        private void InitializeGradeRangeList()
        {
            _gradeRangeList = new List<GradeRange>();
            _gradeRangeList.Add(new GradeRange(95, 100, "A+"));
            _gradeRangeList.Add(new GradeRange(91, 94, "A"));
            _gradeRangeList.Add(new GradeRange(88, 90, "A-"));
            _gradeRangeList.Add(new GradeRange(86, 87, "B+"));
            _gradeRangeList.Add(new GradeRange(83, 85, "B"));
            _gradeRangeList.Add(new GradeRange(80, 82, "B-"));
            _gradeRangeList.Add(new GradeRange(76, 79, "C+"));
            _gradeRangeList.Add(new GradeRange(73, 75, "C"));
            _gradeRangeList.Add(new GradeRange(67, 72, "C-"));
            _gradeRangeList.Add(new GradeRange(65, 66, "D+"));
            _gradeRangeList.Add(new GradeRange(62, 64, "D"));
            _gradeRangeList.Add(new GradeRange(60, 61, "D-"));
            _gradeRangeList.Add(new GradeRange(0, 59, "F"));
        }
    }
}
