using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_72_2018
{
    class ExerciseResults
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }
        public int Points { get; set; }

        public ExerciseResults()
        { }
        public ExerciseResults(int Id, string StudentName, string StudentIndex, int Points)
        {
            this.Id = Id;
            this.StudentName = StudentName;
            this.StudentIndex = StudentIndex;
            this.Points = Points;
        }

    }
}
