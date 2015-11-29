using System;

namespace _3.CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string ProjectName { get; }

        DateTime ProjectStartDate { get; }

        string Details { get; }

        State State { get; }

        void CloseProject();
    }
}
