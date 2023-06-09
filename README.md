<div align="center"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR.Images/Main.gif" alt="Hospital animated icon"></div>
<h1 align="center">EHR</h1><br>

## Table of Contents

* [Project Description](#Project-Description)
* [Required Software](#Required-Software)
* [Views](#Views)
* [Notes](#Notes)
* [References](#References)

# Project Description

EHR (Electronic Healthcare Report System) is a desktop application, which could be used by the public and the healthcare field. The EHR would collect and store data on patients' treatment, test results, scans, medicine prescriptions, and medical history with their exact dates at public and private hospitals, pharmacies, and clinics. This would enable faster access to a patient's past medical records and ensure accurate data and eliminate the risk of lost medical documents. The information in these systems is input and managed by authorized healthcare practitioners within a specific healthcare organization. The application would come with multiple user-friendly interfaces, providing different functionalities depending on who the user is. For example, the patient would be able to view their medical history, view lab results and could even
become an organ donor.
Hospitals and clinics could apply to be on our database system to get patient-generated data,
medication process tracking, and show their laboratory results.
Pharmacies could also apply to be on our database system to show patients' current illnesses and
required medication and give them their medications.

# Required Software

- [Microsoft Visual Studio](https://visualstudio.microsoft.com/downloads/).
- C# package
- [Krypton UI Toolkit](https://github.com/ComponentFactory/Krypton).

# Views

### Patient
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Sign%20UP.png" alt="Patient Sign Up" width="500px"></div>
<br>
Patient is first greeted with the sign up page where they can create their account.
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Sign%20IN.png" alt="Patient Sign In" width="500px"></div>
<br>
If they already have an accout they can sign in instead.
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Patient.png" alt="Patient" width="500px"></div>
<br>
The patient then can view all the different functionalities:
1. View Medical History
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Medical History.png" alt="Medical History" width="500px"></div>
<br>
Patient can view all diagnosis within a certain date range.
<br>
2. View Lab Results
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Lab Results.png" alt="Lab Results" width="500px"></div>
<br>
Patient can view, download, and/or print all lab results.
<br>
3. View Prescriptions
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Prescriptions.png" alt="Prescriptions" width="500px"></div>
<br>Patient can view all prescriptions prescribed within a certain time period.<br>
4. Add Family Members
<br><div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Family.png" alt="Family" width="500px"></div>
<br>Patient can view family members, add family members, or view requests.
<br><div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Family Requests.png" alt="Family Requests" width="500px"></div>
<br>Here we can see a family member request where user can accept or reject the request.
<br>5. Apply for Organ Donations
<br><div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Organ Donation.png" alt="Organ Donations" width="500px"></div>
<br>Patient can apply to become an organ donor while alive or choose to donate his organs upon death.
<br>6. View Surgeries
<br><div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Patient/Surgery Report.png" alt="Surgeries" width="500px"></div>
<br>Patient can view all surgery reports for surgeries done within a certain time period.

### Hospital
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Hospital/Login.png" alt="Hospital Sign In" width="500px"></div>
<br>
Hospital staff are first greeted with the sign in page where they can login to their account provided by an admin.
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Hospital/Hospital.png" alt="Hospital Functionalities" width="500px"></div>
<br>
The hospital then can view all the different functionalities similar to the patient:
<br>
<ol>
<li> Issue Diagnosis</li>
<li> View Patient History</li>
<li> Request surgeries and Issue surgery reports</li>
<li> Issue death reports</li>
<li> Request lab tests</li>
  <li> Request organs and view previous requests </li>
</ol>
<br>

### Pharmacy
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Pharmacy/Login.png" alt="Pharmacy Sign In" width="500px"></div>
<br>
Similar to Hospital staff, Pharmacy staff are first greeted with the sign in page where they can login to their account provided by an admin.
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Pharmacy/Prescriptions.png" alt="Pharmacy Prescriptions" width="500px"></div>
<br>
They are then asked to enter the Patient ID and are able to view prescribed medicines to set patient and can give the patient the medicine.
<br>

### Laboratories
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Laboratory/Login.png" alt="Lab Sign In" width="500px"></div>
<br>
Lab staff are first greeted with the sign in page where they can login to their account provided by an admin.
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Laboratory/Lab Results Upload.png" alt="Lab results upload" width="500px"></div>
<br>
They are then asked to enter the Patient ID and are able to view tests requested to set patient by the hospital and can upload the test results.
<br>

### Admin
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Admin/Admin Login.png" alt="Admin Sign In" width="500px"></div>
<br>
Finally Admin is greeted by the login page as well.
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Admin/Admin.png" alt="Admin Functionalities" width="500px"></div>
<br>
The admin then can view all the different functionalities similar to the patient:
<br>
1. Add Hospital/Lab/Pharmacy
2. View Statistics
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Admin/Statistics.png" alt="Statistics" width="500px"></div>
<br>
Admins can view statistics about the diagnosis, surgeries, lab tests, etc... they can filter by date range and also filter by gender.
<br>
<div align="left"><img src="https://github.com/fares-h-moneim/EHR/blob/master/EHR-Images-Display/Admin/Statistics Males and Females.png" alt="Statistics Male and Female" width="500px"></div>
<br>

# Notes

- The database was hosted using [Microsoft Azure Cloud Services](https://azure.microsoft.com/en-us).
- The app is still under development there may be some minor bugs.

# References

Project Document: [DB Project Document.pdf](https://drive.google.com/file/d/1lmzFnGF8QHNRYkah1Ftxwts9z9UBRyJ6/view)


