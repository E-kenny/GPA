using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_P_A_Calculator
{
    public class GPA
    {
        private double _totalCourseUnitRegistered;
        private double _totalGradeunit;
        private double _totalWeightPoint;
        private double _totalUnitPassed;

        public GPA(List<Course> lists)
        {

            foreach(Course list in lists )
            {
                _totalCourseUnitRegistered += list.CourseUnit;
                _totalGradeunit += list.CourseGrade;
                _totalWeightPoint += list.WeightPoint;
                _totalUnitPassed += list.UnitPassed;
            }

        }

        public double TotalCourseUnitRegistered
        {
            get { return _totalCourseUnitRegistered; }
         //   set { _totalCourseUnitRegistered = value; }
        }

        public double TotalGradeUnit
        {
            get { return _totalGradeunit; }
          //  set { _totalGradeUnit = value; }
        }

        public double TotalWeightPoint
         { 
            get   { return _totalWeightPoint; }
           // set { _totalWeightPoint = value;  }
        }

        public double TotalUnitPassed
        {
           get { return _totalUnitPassed; }
          // set { _totalUnitPassed = value; }
        }

        public double Calculate()
        {
            return _totalWeightPoint/_totalCourseUnitRegistered;
        }

    }
}
