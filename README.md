Setup:

- Drop the php file on your webserver where the mysql server is running. 
- Drop c# script on an object in unity.
- edit c# script and set the correct file location on your server. Currently its looking for localhost/sqlconnect/sqlconnector.php
- Your done. You can now send queries to your MySQL server by calling SQLConnector.DoDB("YOUR QUERY HERE");

Hope it helps ;)
