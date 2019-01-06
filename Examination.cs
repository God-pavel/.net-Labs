﻿using System;
using System.Text;

namespace lab1
{
    public class Examination : ICloneable, IComparable
    {
        private int semester;
        private string subject;
        private string teacher;
        public int points { get; }
        public bool is_diff { get; }
        private DateTime date;

        public Examination()
        {
            this.semester = 3;
            this.subject = "OOP";
            this.teacher = "Mukha I.P.";
            this.points = 100;
            this.is_diff = true;
            this.date = new DateTime(2019, 1, 9);
        }

        public Examination(int semester, string subject, string teacher, int points, bool is_diff, string date)
        {
            this.semester = semester;
            this.subject = subject;
            this.teacher = teacher;
            this.points = points;
            this.is_diff = is_diff;
            this.date = Convert.ToDateTime(date);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nSubject: " + this.subject + '\n');
            result.Append("Teacher: " + this.teacher.Split(' ')[0] + '\n');
            result.Append("Semester: " + this.semester + '\n');
            result.Append("Points: " + (this.is_diff ? this.points.ToString() : "N/A"));
            return result.ToString();
        }

        public object Clone()
        {
            return new Examination(this.semester, this.subject, this.teacher, this.points, this.is_diff, this.date.ToShortDateString());
        }

        public int CompareTo(object obj)
        {
            return this.semester.CompareTo(((Examination)obj).semester);
        }
    }
}