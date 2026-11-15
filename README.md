# 🏥 Vitality - Healthcare Management System (C# WinForms)

## 📖 About the Project
Vitality is a Windows Forms desktop application prototype for a healthcare management system. It provides a login screen and a dashboard organized around patient management, staff management, appointments, and support.

The supplied code focuses on the application’s user interface and navigation layout. It validates that login fields are not empty, then opens the main dashboard. Authentication, database integration, and the dashboard actions are not implemented in the provided code.

## 📌 Features

### 1. 🔐 Login Screen
* **Username and Password Fields:** Provides the basic login form.
* **Input Validation:** Displays an error when either field is left empty.
* **Password Masking:** Hides password characters while typing.
* **Login Navigation:** Opens the dashboard when both fields contain text.
* **Exit Button:** Closes the application window.

### 2. 🧑‍⚕️ Patient Management
* Add New Patient
* View / Edit Patient Details
* Delete Patient Record

### 3. 👥 Staff Management
* Add New Doctor / Staff
* View Doctor / Staff Details
* Assign Doctor to Patient

### 4. 📅 Appointments
* Schedule Appointment
* View Appointments
* Cancel Appointment
* View Appointment History

### 5. 🆘 Help and Support
* User Guide
* Contact Support
* About

### 6. 🖥️ Dashboard
* Visual shortcuts for patients, staff, appointments, help, and exit.
* Menu-based navigation for the main application areas.

## 🏗️ Application Structure
* **`Form1`:** Login screen, input validation, and navigation to the dashboard.
* **`Form2`:** Main dashboard with healthcare-management menus and visual shortcuts.
* **Windows Forms Designer files:** Define the forms’ controls and layouts.
* **Application resources:** Supply the logos, backgrounds, and icons referenced by the forms.

## 🛠️ Technologies Used
* **C#**
* **.NET Framework**
* **Windows Forms (WinForms)**
* **Visual Studio**

## ⚠️ Current Limitations
* The login checks only that both fields contain text; it does not authenticate credentials.
* Dashboard menu items and image shortcuts do not have actions implemented in the supplied code.
* No database or patient, staff, or appointment data-management logic is included.
