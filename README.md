# CarParkingCalcServiceAPI

API : GET: ParkingCharges/GetParkingCharge Returns Charges based on parameter CarEntryTime and CarExitTime.

Tests: Test API work space has tests for all type of charge types
        Name of the Rate	Early Bird

Type	Flat Rate
Total Price	$13.00
Entry Condition	Enter between 6:00 AM to 9:00 AM
Exit Condition	Exit between 3:30 PM to 11:30 PM

Name of the Rate	Night Rate
Type	Flat Rate
Total Price	$6.50
Entry Condition	Enter between 6:00 PM to midnight (weekdays)
Exit Condition	Exit between 3:30 PM to 11:30 PM

Name of the Rate	Weekend Rate
Type	Flat Rate
Total Price	$10.00
Entry Condition	Enter anytime past midnight on Friday to Sunday
Exit Condition	Exit any time before midnight of Sunday

Note: If a customer enters the carpark before midnight on Friday and if they qualify for Night rate on a Saturday morning, then the program should charge the night rate instead of weekend rate.  
For any other entry and exit times the program should refer the following table for calculating the total price. 
Name of the Rate	Standard Rate
Type	Hourly Rate
0-1 Hours	$5.00
1-2 Hours	$10.00
2-3 Hours	$15.00
3+ Hours	$20.00 flat rate for each calendar day of parking

