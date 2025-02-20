using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class HospitalTriage

    {
        private SortedDictionary<int, Queue<string>> patientQueue;

        public HospitalTriage()
        {
            patientQueue = new SortedDictionary<int, Queue<string>>();
        }

        public void AddPatient(string name, int severity)
        {
            if (!patientQueue.ContainsKey(-severity)) // Use negative severity to get max priority
            {
                patientQueue[-severity] = new Queue<string>();
            }
            patientQueue[-severity].Enqueue(name);
            Console.WriteLine($"Patient {name} with severity {severity} added.");
        }

        public void TreatPatient()
        {
            if (patientQueue.Count > 0)
            {
                var highestPriority = patientQueue.First();
                string patient = highestPriority.Value.Dequeue();

                if (highestPriority.Value.Count == 0)
                    patientQueue.Remove(highestPriority.Key);

                Console.WriteLine($"Treating Patient: {patient}");
            }
            else
            {
                Console.WriteLine("No patients left.");
            }
        }
    }
}