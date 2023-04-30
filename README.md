# Cipher API

Cipher API is a RESTful web service built using C#, ASP.NET Core 6.0, and implements ROT13 and ROT16 (Russian) ciphers for text encryption.

## Features

- Support for two ciphers:
  - ROT13 (English)
  - ROT16 (Russian)
-RESTful API for easy integration with other applications
-Swagger/OpenAPI documentation for easy testing and integration

## Prerequisites

- .NET 6.0 SDK
- Visual Studio or Visual Studio Code (with C# extension)

## Installation

1. Clone the repository
2. Navigate to the project folder
3. Restore dependancies: dotnet restore

## Usage
To run the project locally, use the following command: dotnet run

This will usually start the API at `http://localhost:5000` or `https://localhost:5001`, but in case it chooses a different port, pay attention to the powershell output

## API Endpoints
- `POST /api/cipher/encrypt`: Encrypts the input text using the specified cipher.
- Note that if the wrong language is chosen, the output text will not be ciphered and will return the input text.
- Note that this logic can also DEcipher the entered text if the cipher used is ROT13(for English) or ROT16(for Russian).
 Example request payload:

   ```json
   {
       "Language": "English",
       "Text": "Hello, World!"
   }
   ```
 Example response payload:
   ```json
   {
    "encryptedText": "Uryyb, Jbeyq!"
   }
   ```

## Testing

You can test the API using tools like Postman or Swagger UI by importing the OpenAPI specification available at http://localhost:5000/swagger/v1/swagger.json or https://localhost:5001/swagger/v1/swagger.json.

