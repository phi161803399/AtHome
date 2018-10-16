using System.IO;

namespace Grades
{
    internal interface IGradeTracker
    {
        GradeStatistics ComputeStatistics();
        void AddGrade(float grade);
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
        event NameChangedDelegate NameChanged;
    }
}