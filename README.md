#Parking Challenge

This is a WCF REST project built off of the following specifications.

Write a REST Service, define the contracts and an implementation using which one can get

  1.    Parking space availability

  2.    When exiting how long the vehicle was parked to compute fees.

  3.    A method to compute the fees

    a.       0-2 hrs. – 5$

    b.      2-10 hrs. – 10$

    c.       > 10 – 15$
	 
Include error handling and unit testing.

Please plan to complete in 3 hours.


##Getting Started

This project is configured for SSL binding and should be deployed to an IIS folder set as an application with HTTPS enabled.  As this is a demo, I have configured error exceptions get sent to my own e-mail address.  You will want to change that to your own should you want to test this services in a different environment.


###Prerequisites
This project leverages Elmah error handling and Newtonsoft Json libraries.

###Installing
Import a web deploy package for your server and configure the virtual directory where you have set up the folder application for the solution.

###Running the tests
I have configured a simple implementation of the two services in the challenge here.  (https://dalcreatives.com/lambertshowsoff/parkingchallenge)  I have also added an Implementation.html file for review of ajax calls (https://dalcreatives.com/parkingchallenge/Implementation.html).  Note:  I have only added three parking tickets (1, 2, 3).  Any lot other then "full" or an empty string will show as available parking.

###API Documentation
There is a Swagger API site at https://dalcreatives.com/lambertshowsoff/parkingchallenge/api-docs
