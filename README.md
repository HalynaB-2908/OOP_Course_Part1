This repository contains a comprehensive collection of assignments from the Object-Oriented Programming (OOP) course, completed during the 3rd semester of my Computer Engineering studies at the National Technical University "Kharkiv Polytechnic Institute." The projects cover various fundamental concepts of programming in C#, ranging from basic data types and control structures to advanced object-oriented principles.

Key Areas Covered:
Console Applications: These tasks, including currency conversion and time calculation, focus on basic data manipulation, mathematical operations, and conditionals, laying a strong foundation for more complex programming challenges.

WinForms Applications: Projects like the currency converter and array element manipulation showcase my initial experience with graphical user interfaces (GUIs) in C#, emphasizing the transition from console-based programs to interactive desktop applications.

Array and Loop Operations: Assignments such as cyclic array shifting and finding maximum/minimum values in arrays highlight my proficiency in handling data structures and loops, essential skills for efficient coding.

String Manipulation: Tasks involving word counting, reversing strings, and checking bracket placement demonstrate my ability to work with string data, a crucial aspect of many programming scenarios.

Object-Oriented Programming: Central to this repository, the assignments related to the Student class illustrate core OOP concepts like class creation, property management, method implementation, and exception handling. These projects not only showcase my understanding of OOP principles but also my ability to apply them in real-world scenarios.

Each project is organized by task and designed to progressively build a solid understanding of C# programming and object-oriented principles, providing a strong foundation for further software development studies and professional practice.

Task 01: Currency Converter
Create a WinForms (.NET) application to calculate the equivalent amount in dollars based on an entered amount in hryvnias and the current exchange rate from hryvnia to dollar. The user inputs the amount in hryvnias and the exchange rate, and the program outputs the converted amount in dollars.
Example: If the input is 100 UAH and the exchange rate is 38.1, the result will be $2.62.

Task 02: Seconds to Time Converter
Create a console application to convert an entered number of seconds into hours, minutes, and seconds. The user inputs the total number of seconds, and the program calculates and outputs the equivalent time in hours, minutes, and seconds. Example: If the input is 3602 seconds, the result will be 1 hour, 0 minutes, and 2 seconds.

Task 03: GUI-Based 2D Array Element Replacement
Create a GUI application to work with a 2D array of random numbers. The program should find and swap the maximum and minimum elements in the array. The background of these elements should be highlighted with a distinct color. Additionally, display the indices of these elements in a label.

Task 04: Find Max Min Arr
Create a program to find the maximum and minimum elements in an array of random numbers. The program should output the values of these elements along with their indices in the array.

Task 05: Swap Max Min Arr
Create a program to swap the maximum and minimum elements in an array of random numbers. The program should display the array before and after the swap, clearly indicating the changes made.

Task 06: Rotate Right
Create a program to perform a cyclic shift of all elements in an array of random numbers to the right by one position. The last element should become the first element in the array.

Task 07: Rotate Left
Create a program to perform a cyclic shift of all elements in an array of random numbers to the left by one position. The first element should become the last element in the array.

Task 08: Count Words
Create a program to count the number of words in a given string. Words are separated by spaces. For example, the string "asdasd s asda sd" contains 4 words.

Task 09: Split Sentence
Create a program to input a string of words separated by spaces. The program should output each word on a new line. For example, if the input is "asdasd s asda sd", the output should be:
asdasd
s
asda
sd

Task 10: Grade Average
Create a program to input an array of 5 grades (characters in the range A-F). Calculate the average grade and display both the numerical average and the corresponding letter grade.

Task 11: Normalize Sentence Spaces
Create a program to input a string containing sentences, where extra spaces may be missing before new sentences. The program should transform the string so that there is exactly one space before each new sentence. For example:
Input:
sgsgs sdg s.sd.Asdfdg sdgs g.  sgdsgds
Output:
sgsgs sdg s. sd. Asdfdg sdgs g. sgdsgds

Task 12: Student Records
Create a Windows Forms application for managing student records. Implement the following functionalities:
Add Student: Input student data (Last Name and three exam scores) and display the student's average score.
Display Student: Create and display a student record using provided input parameters, showing the average score in a message box.
Initialize DataGridView: Set up a DataGridView to display student records, including Last Name, three exam scores, and the average score. Configure column widths appropriately.
Add to DataGridView: Add students to the DataGridView and update with rounded average scores (to two decimal places).
Find Top Student: Identify and display the student with the highest average score from the DataGridView records.
Ensure the DataGridView columns are sized correctly, with the Last Name column wider than the exam score columns.

Task 13: Student List Editor
Develop a Windows Forms application for managing a list of student records with the following features:
Create Student Array: Initialize an array of students and configure a DataGridView to display student records. The DataGridView should include columns for Last Name, three exam scores, and the average score, with appropriate column sizing.
Add Student: Open a form to input student details (Last Name and three exam scores). Add the student to the array and display their information in the DataGridView. Calculate and display the student's average score, rounded to two decimal places.
Edit Student: Search for a student by Last Name and edit their details through a dedicated form. Update the student's record in the array and reflect changes in the DataGridView.
Highlight Student: Implement a feature to search for a student by Last Name and highlight their row in the DataGridView.

Task 14: FlashDrive files simulator
Create a Windows Forms application to manage flash drives and files with the following functionalities:
Classes Definition:
File Class: Contains properties for Name and Size.
Flash Drive Class: Contains properties for Name, Maximum Size, and an array of up to 5 File objects. Implement methods to add and remove files, as well as to calculate the current total size of all files on the flash drive.
Flash Drive Array:
Create an array of flash drive objects. Display flash drive details in a DataGridView, with file names shown in a single cell as a comma-separated string.
Adding Objects:
Implement additional forms for adding new flash drive and file objects. Ensure that each object can be edited through these forms.
File Transfer:
Implement functionality to move a file from one flash drive to another, based on their indexes in the array.
Swap Flash Drives:
Add a feature to swap the positions of two flash drives in the array based on their indexes.
Search Functionality:
Implement search features based on the following criteria:
Flash drive name
File name
