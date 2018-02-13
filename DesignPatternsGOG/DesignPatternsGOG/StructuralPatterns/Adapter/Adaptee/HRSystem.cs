﻿namespace DesignPatternsGOG.StructuralPatterns.Adapter.Adaptee
{
    /// <summary>
    /// This is a class which have the functionality, required by the client. 
    /// However, its interface is not compatible with the client.
    /// </summary>
    class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "100", "Deepak", "Team Leader" };
            employees[1] = new string[] { "101", "Rohit", "Developer" };
            employees[2] = new string[] { "102", "Gautam", "Developer" };
            employees[3] = new string[] { "103", "Dev", "Tester" };

            return employees;
        }
    }
}
