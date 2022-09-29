using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_P_A_Calculator
{
    public class Course
    {
        private string    _courseCode;
        private double    _courseUnit;
        private double    _courseGrade;
        private double    _score;
        private char      _grade;
        private double    _weightPoint;
        private string    _remark;
        private double    _unitPassed;

        public Course(string code, int courseUnit, int score)
        {
            _courseCode = code;
            _courseUnit = courseUnit;
            _score      = score;
            _unitPassed = courseUnit;

            if (score >= 70 && score <= 100) 
            {
                _courseGrade = 5;
                _grade = 'A';
                _remark = "Excellent";
                _unitPassed = courseUnit;

            }
            else if(score >= 60 && score < 70)
            {
                _courseGrade = 4;
                _grade = 'B';
                _remark = "Very Good";
                _unitPassed = courseUnit;
            }
            else if(score >= 50 && score < 60)
            {
                _courseGrade = 3;
                _grade = 'C';
                _remark = "Good";
                _unitPassed = courseUnit;
            }
            else if (score >= 45 && score < 50)
            {
                _courseGrade = 2;
                _grade = 'D';
                _remark = "Fair";
                _unitPassed = courseUnit;
            }
            else if (score >= 40 && score < 45)
            {
                _courseGrade = 1;
                _grade = 'E';
                _remark = "Pass";
                _unitPassed = courseUnit;
            }
            else if (score >= 0 && score < 40)
            {
                _courseGrade = 0;
                _grade = 'F';
                _remark = "Fail";
                _unitPassed = 0;
            }
            else
            {
                throw new InvalidOperationException("Invalid input");
            }


            _weightPoint = _courseUnit * _courseGrade;

        }

        public string CourseCode {
            get { return _courseCode; }
           // set { _courseCode = value; }
        }

        public double CourseUnit
        {
            get { return _courseUnit; }
            //set { _courseUnit = value; }
        }

        public double CourseGrade
        {
            get { return _courseGrade; }    
           // set { _courseGrade = value; }   
        }

        public double WeightPoint
        {
            get { return _weightPoint; }
           // set { _weightPoint = value; }
        }

        public double Score
        {
            get { return _score; }
            // set { _score = value; }
        }

        public char Grade
        {
            get { return _grade; }
            // set { _grade = value; }
        }

        public string Remark
        {
            get { return _remark; }
            // set { _remark = value; }
        }

        public double UnitPassed
        {
            get { return _unitPassed; }
          //  set { _unitPassed = value; }

        }


    }
}

