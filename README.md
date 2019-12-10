# ConvertAPI
ASP.NET Core MVC web application structure.
As any framework that supports MVC pattern ASP has its structure that helps to achieve separation of concerns.

## Model: it contains 3 classes:
- the ConvertAmountRequest: the API Post request.
- the ConvertAmountResponse: the API Post response.
- the Rate: the class that contains the value of the API.


## Controller: it contains 2 classes 
- the HomeController: the controller of the Home page [route "/"]

- the ExchangeRatesApi: the controller that gets the exchange rate from the API. 
- the APIController: it has just one post method that gets the rate value from the ExchangeRatesApi method and convert the value. [route "/api"]


## View: it contains 2 folders
- Home or index: our home page that contains the frame 
- the share files: (here we have no father nor means so we have shared element) but we still needed to edit the layout file
which contains the requirements of the code (bootstrap and jquery environment)
