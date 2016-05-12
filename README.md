# loginRegClient

-With service running in another vs instance, copy the localhost address. 
-New blank website, add service reference to the service you have running. Remember to name it. 
-Add new web form, create your table with asp text boxes and buttons. 
  - Remember to make set the textmode for the password field to password. 
-double click the button to add event handler
  - below the button click handler, add your method (login) and inside create a new loginserviceref object and call its client. (see first line of login()).
- Add a link to a registration page on the default.aspx page, the create new web form for register. 
- Create registration page as a web form. 
- to add jQuery, right click on project and select manage nuget packages. 
  -   select asp.net.scriptmanager.jquery and install 
  -   you will now have validation in your toolbox. 
  -   You can drag and drop validation into the blank fields on your form. 
  -   Click on the validation field to see properties, and set the control to validate to the field you want it to validate. You can aslo set things like color, and what the error message says. 
