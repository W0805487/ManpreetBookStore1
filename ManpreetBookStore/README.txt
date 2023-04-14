2023-03-02
1505
started assignment 2 in-class on the lab computer
Set up the ASP>NET MVC
using 1.3 core
HTTPS enabled, individual account authentication..
no razor..

Reviewed the area folders..

removed option for default action from startup.cs file in line 33
removed  (options => options.SignIn.RequireConfirmedAccount = true

Tested th app..it run succesfully..

Action item:
Modify the navigation...
Update the copyright...

update the welcome page in index.cshtml 
tested..

Reviewed the route patteren in startup.cs

Created Github repository

2023-03-03
1516
confirmed the repo is built...  tested it...

created README.md file..

2023-03-09

select LUX theme from the bootswatch.com
renamed the older bootstrap file.
added new bootstrap.css file in the lib >bootstrap > css > bootstrap.css

changes in layout.cshtml file..
renamed file bootstrap.min.css to bootstrap.css
nav class from nav-bar light to navvar- dark to the big primary
remove text dark from line 23..

tested the app...
it run successfully...

Added the new date and time in the view > Layout.cshtml file....

Modified a navigation bar...
write Books at the place of Home in line 23 in Layout.cshtml file.

make changes in README.md file...


1904
Added dropdown in Layout.cshtml file...

remove text-dark in Loginpartial.cshtml file from line 20 and 23.

2023-03-23
1500
corrected my spelling errors in project name ManpreetBooks.Models1


1910
Copy the data folder and paste to .DataAccess project.

1932

Move Models in ManpreetBook.Models
Added project references....
Rename modelsfolder to ViewModels...


updated Error.cshtml
updated startup.cs file....
Updated HomeController.cs


2025

Added Customer in Area file
Change route in startup.cs file.

2029

Edit the HomeController.cs file.

2043
added a new Admin area..
Added the proper view file and delete the Data and Models folder..
Deleted the controller folder....

Part 1 is done...

2023-03-24
1551

Start assignment 2 part 2

Update the Database name in appsettings.json
Database= ManpreetBookStore


Added migration
add-migration adddefaultIdentityMigration (this is wrong)
new migration file namee= manpreetBookStore.DataAccess

MIGRATION FILES
20230324195020_AddDefaultIdentityMigration.cs
20230331004007_AddCategoryToDb.cs

1554
update database
got ERROR......


2023-03-30
1701
ERROR correct...
Update database successfully....



1730
added new class named Category.cs in Models.
migration 
update database 
show categories table inSQL server Object Explorer....

2051
Create Repository folder in ManpreetBooks.DataAccess
create IRepository folder in Repository Folder
Created IRepository.cs in IRepository folder.

2104

created Interface in IRepository folder
created class in Repository folder..
Modified them with given instructions...

2110
Created new interface named ISP_Call.cs in IRepository folder.
Created new class named SP_Call.cs in Repository folder... 

2122
Created new interface named IUnitOfWork.cs in IRepository folder...
modified interface According to instructions

2132
Created new class named UnitOfWork.cs in Repository folder..
modified class According to instructions....

2136

Modified configurationServices method in startup.cs file..

No errors...

Project run SUCCESSFULLY.....

2023-04-06

I started again because my new project DataAccess,Models and Utility not open in Github....

Assinment 2 complete.


2023-04-13
1425

ERROR: privacy page was not working
SOLVED! I was missing two files in Views in main project
_ViewImport.cshtml
_ViewStart.cshtml

1550
created IunitOfWork.cs file in the IRepository folder. 


1807
created UnitOfWork.cs file in the Repository folder. 
and modified it according to instruction.

1810
Modified startup.cs file.
created public interfaces and classes.


1835
created CategoryController.cs file in Area>Admin>controller folder.
write the code according to the given instruction.
Edit the ICategoryRepository.cs file.

1840
created new folder named Category in the Area>Admin>Views
created class in Category folder named Index.cshtml.

Updated Navigation in the Layout.cshtml file.


1920
created category.js file in the wwwroot>js folder.
Edit two icones named Edit,create and Delete in the category files. 
added the new view called Upsert.cshtml.
created a partial view for the EDIT/BACK in the View>Shared folder.
1. _CreateAndBackToListButton.cshtml..
2._EditAndBackToListButton.cshtml..

Edit the asp-action in the index.cshtml file.

2024

Edit the category.js file according to given instruction 
write Delete on the place of Upsert in line 23..

2040

add Delete method CategoryController.cs file
Run the project..
Successfully run......

Completed Assignment 2 part 2

