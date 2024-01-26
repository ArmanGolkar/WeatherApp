WeatherApp Design Document
1. Introduction
The WeatherApp is a desktop application designed to provide real-time weather information for a specified city. 
Developed using C# and Windows Forms,
the application integrates with the OpenWeatherMap API to fetch accurate and up-to-date weather data.

2. Features
2.1 Weather Information Display
	City Name: Displays the name of the city for which weather information is requested.
	Current Conditions: Shows the main weather condition (e.g., Clear, Rain, Snow).
	Temperature: Displays the current temperature in Celsius.
	Weather Description: Provides a detailed description of the current weather.
	Sunrise and Sunset: Displays the local time for sunrise and sunset.
	Wind Speed: Shows the wind speed in the specified city.
	Pressure: Displays the atmospheric pressure.
2.2 User Interaction
	Search Functionality: Users can input the name of a city and click the "Search" button to retrieve weather data.
	Close Application: Users can close the application by clicking the "Close" button.
2.3 User Interface Enhancements
	Loading Indicator: A loading icon is displayed while the application fetches weather data to indicate that the process is ongoing.
	Character Limit: The application limits the display of temperature to maintain a clean and concise user interface.

Usage
Launch the Application: Double-click the WeatherApp icon on your desktop or navigate to the installation directory and run the executable file.

Input City Name: Enter the name of the city for which you want to retrieve weather information into the provided text box.

Fetch Weather Data: Click the "Search" button to initiate the process of fetching weather data.

View Weather Information: Once the data is retrieved, the application will display the weather information on the interface.

Close the Application: Click the "Close" button to exit the application when done.