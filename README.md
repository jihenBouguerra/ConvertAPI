# ConvertAPI
[![npm](https://img.shields.io/badge/langage-ASP.Netcore-blue.svg?style=flat-square)](https://dotnet.microsoft.com/apps/aspnet/) 
## ASP.NET Core MVC web application Structure

As any framework that supports MVC pattern ASP has its structure that helps to achieve separation of concerns.

### Model: it contains 3 classes:
- the ConvertAmountRequest: the API Post request.
- the ConvertAmountResponse: the API Post response.
- the Rate: the class that contains the value of the API.


### Controller: it contains 2 classes 
- the HomeController: the controller of the Home page [route "/"]

- the ExchangeRatesApi: the controller that gets the exchange rate from the API. 
- the APIController: it has just one post method that gets the rate value from the ExchangeRatesApi method and convert the value. [route "/api"]


### View: it contains 2 folders
- Home or index: our home page that contains the frame 
- the share files: (here we have no father nor means so we have shared element) but we still needed to edit the layout file
which contains the requirements of the code (bootstrap and jquery environment)

## Dependencies ##
I'm using this [API](https://api.exchangeratesapi.io/) to get the rating change.
I also imported :[Jquery](https://jquery.com/)  and [Bootstrap](https://getbootstrap.com/)


## How to run ##

* Execute: the solution with Visual Studio

## Authors ##

* Jihen Bouguerra 
  * Github: [jihenBouguerra](https://github.com/jihenBouguerra)
  * Email: [boujihen](mailto:boujihen647@gmail.com)
  


