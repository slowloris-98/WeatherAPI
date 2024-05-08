This is a .Net Core Web API project to retrieve real time weather details of different cities based on user inputs and IP address. The API has following endpoints:
1. /Login (POST) - Registers user, record added in MongoDB and returns JWT for authorization.
2. /Weather (GET) - Checks user authorization and returns temperature of the user's city based on the IP address.
3. /WeatherByCity (POST) - Checks user authorization and returns temprature of the user input city.
