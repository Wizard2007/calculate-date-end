# calculate date end
Simple class for calculate end date of peroiod

1. The input of function is starting date, duration in days (an integer) and output (an array of objects from the fields of the start date and end date if the start date coincides with the end date - it means the output is only on this day, if not the same - then this period output, for example 23/04/2011 - 25/04/2011 - two weekends (Saturday + Sunday) and 25th - a holiday, a total of three weekends). The array is sorted by start date, the periods do not overlap. Class can do yourself
 
2. The output of function is date, which is calculated as the start date + duration excluding weekends.
 
For example :
Start date 21/04/2011
Duration: 5 days
Weekend :
23/04/2011 - 25/04/2011
 
The output should be:
End date: 28/04/2011