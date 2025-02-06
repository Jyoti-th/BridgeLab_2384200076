﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Object_Modeling
{
        class Patient
        {
            public string PatientName { get; set; }
            public List<Doctor> Doctors { get; set; }

            public Patient(string name)
            {
                PatientName = name;
                Doctors = new List<Doctor>();
            }

            // Method to consult with a doctor
            public void ConsultWithDoctor(Doctor doctor)
            {
                if (!Doctors.Contains(doctor))
                {
                    Doctors.Add(doctor);
                    doctor.Consult(this);
                }
                else
                {
                    Console.WriteLine($"{PatientName} has already consulted with Dr. {doctor.DoctorName}.");
                }
            }
        }

        // Define the Doctor class
        class Doctor
        {
            public string DoctorName { get; set; }
            public string Specialty { get; set; }
            public List<Patient> Patients { get; set; }

            public Doctor(string name, string specialty)
            {
                DoctorName = name;
                Specialty = specialty;
                Patients = new List<Patient>();
            }

            // Method to consult with a patient
            public void Consult(Patient patient)
            {
                if (!Patients.Contains(patient))
                {
                    Patients.Add(patient);
                }
                Console.WriteLine($"Dr. {DoctorName} ({Specialty}) is consulting with {patient.PatientName}.");
            }

            // Display the patients seen by the doctor
            public void ShowPatients()
            {
                Console.WriteLine($"Dr. {DoctorName} has consulted the following patients:");
                if (Patients.Count == 0)
                {
                    Console.WriteLine("No patients yet.");
                }
                else
                {
                    foreach (var patient in Patients)
                    {
                        Console.WriteLine($"- {patient.PatientName}");
                    }
                }
            }
        }

        // Define the Hospital class
        class Hospital
        {
            public string HospitalName { get; set; }
            public List<Doctor> Doctors { get; set; }
            public List<Patient> Patients { get; set; }

            public Hospital(string hospitalName)
            {
                HospitalName = hospitalName;
                Doctors = new List<Doctor>();
                Patients = new List<Patient>();
            }

            // Add a doctor to the hospital
            public void AddDoctor(Doctor doctor)
            {
                if (!Doctors.Contains(doctor))
                {
                    Doctors.Add(doctor);
                    Console.WriteLine($"Dr. {doctor.DoctorName} has been added to {HospitalName}");
                }
            }

            // Add a patient to the hospital
            public void AddPatient(Patient patient)
            {
                if (!Patients.Contains(patient))
                {
                    Patients.Add(patient);
                    Console.WriteLine($"{patient.PatientName} has been added to {HospitalName}");
                }
            }

            // Show the list of doctors and patients in the hospital
            public void ShowHospitalDetails()
            {
                Console.WriteLine($"Hospital: {HospitalName}");
                Console.WriteLine("Doctors:");
                foreach (var doctor in Doctors)
                {
                    Console.WriteLine($"- Dr. {doctor.DoctorName}, Specialty: {doctor.Specialty}");
                }

                Console.WriteLine("Patients:");
                foreach (var patient in Patients)
                {
                    Console.WriteLine($"- {patient.PatientName}");
                }
            }
        }
}
