using System;
using System.Collections.Generic;
using System.Text;

namespace exceptionPjt
{
    class DatabaseTask
    {
        public DatabaseTask()
        {
            Console.WriteLine("=== DatabaseTask CONSTRUCTOR ===");
        }

        public void connectDatabase()
        {
            Console.WriteLine("=== connectDatabase() Start ===");
        }

        public void queryDatabase()
        {
            Console.WriteLine("=== queryDatabase() Start ===");
            throw new NullReferenceException("Reference Exception");
        }

        public void closeDatabase()
        {
            Console.WriteLine("=== closeDatabase() Start ===");
        }
    }
}
