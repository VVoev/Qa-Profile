Feature: Seconds To Minutes Calculator
	In order to do my homework
	As a math student
	I want to be abble to convert minutes to seconds

@mytag
Scenario: Succesfully Convert Minutes To Seconds
	#Given Chrome space browser is open
	And Conversion Site is loaded
	When I press the time link
	And then press minutes link
	And then press the minutes to seconds link
	And type 15 minutes in the box
	Then assert that 900 seconds will be displayed
	#Then close the chrome browser
