# ASP.Net-Core-MVC-LayoutViews-Assignment
Weather app using Layout views

ASP.Net-Core-MVC-LayoutViews-Assignment - WeatherApp
<img width="1916" height="914" alt="image" src="https://github.com/user-attachments/assets/71aa90ab-a7fe-4f03-b1e1-bb77e657a4ab" />




# 🌦️ Weather Portal - ASP.NET Core Web Application

A lightweight, responsive ASP.NET Core MVC application that displays real-time weather information for selected cities. The portal leverages **Attribute Routing**, **Strongly-Typed Views**, and **Conditional Razor Styles** to provide a seamless, modern user experience.

---

## 🚀 Features

*   **City Overview Dashboard:** Displays an overview of all tracked cities at the root path (`/`).
*   **Detailed City Weather View:** Dynamic routing (`/weather/{cityCode}`) to deep-dive into specific city conditions.
*   **Dynamic UI Coloring:** Automatically applies contextual background colors to weather cards based on temperature thresholds via Razor local functions.
*   **Graceful Error Handling:** Provides user-friendly error views for invalid city codes instead of unhandled runtime exceptions.

---

## 🛠️ Tech Stack & Architecture

*   **Framework:** .NET 8.0 / 9.0 (ASP.NET Core MVC)
*   **View Engine:** Razor Views (`.cshtml`)
*   **Routing:** Attribute-based Routing
*   **Styling:** Modern CSS3 with a responsive grid layout

---

## 📂 Project Structure & Core Code

### 1. The Model (`Models/CityWeather.cs`)
Defines the core structure for city weather instances.

```csharp
using System;

namespace WeatherApp.Models
{
    public class CityWeather
    {
        public string CityUniqueCode { get; set; } = string.Empty;
        public string CityName { get; set; } = string.Empty;
        public DateTime DateAndTime { get; set; }
        public int TemperatureFahrenheit { get; set; }
    }
}
```
---
## 🔌 API & Endpoint Specifications

**Example 1:** Dashboard Overview
URL: /

Method: GET

Status Code: 200 OK

Output: Grid display containing weather summaries for London, New York, and Paris.

**Example 2:** Specific City Weather
URL: /weather/LDN

Method: GET

Status Code: 200 OK

Output: Focused details view displaying exclusively London's weather telemetry.

**Example 3:** Error Handling
URL: /weather/XYZ

Method: GET

Status Code: 200 OK (Graceful presentation rendering)

Output: Returns the user-friendly Error.cshtml layout displaying: "No weather data found for city code: 'XYZ'".
---
## 📂 Assignment statement

**Requirement:**

Imagine a weather application that shows weather details of the selected city. Create an Asp.Net Core Web Application that fulfils this requirement.



Consider the following hard-coded weather data of 3 cities.

CityUniqueCode = "LDN", CityName = "London", DateAndTime = "2030-01-01 8:00",  TemperatureFahrenheit = 33
CityUniqueCode = "NYC", CityName = "London", DateAndTime = "2030-01-01 3:00",  TemperatureFahrenheit = 60
CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = "2030-01-01 9:00",  TemperatureFahrenheit = 82


Consider a model class called 'CityWeather' with following properties:

 string CityUniqueCode
 string CityName
 DateTime DateAndTime
 int TemperatureFahrenheit






**Example #1:**

If you receive a HTTP GET request at path "/", it has to generate a view with weather details of all cities with HTTP status code 200.

Request Url: /

Request Method: GET

Response Status Code: 200

Response body (output):

View as shown below.

<img width="767" height="319" alt="image" src="https://github.com/user-attachments/assets/3ef4eb2e-b2ca-4c61-816a-a747b101a6c7" />




**Example #2:**

If you receive a HTTP GET request at path "/weather/{cityCode}", it has to generate a view with weather details of the selected city s with HTTP status code 200.

Request Url: /

Request Method: GET

Response Status Code: 200

Response body (output):

View as shown below.

<img width="767" height="324" alt="image" src="https://github.com/user-attachments/assets/15b6091f-1c42-4aea-9975-fdf0b4a49a16" />





**Instructions:**

Create controller(s) with attribute routing.

Initialize the hard-coded data as collection of model objects in the controller.

Use strongly-typed views. Send model object(s) to view.

If you supply an invalid city code as route parameter, it should show a page with proper error message, instead of throwing an exception.

Use CSS styles, _ViewImports, Razor view engine as per the necessity.

The UI should be consistent and modern. It should minimum look like as shown in the screenshot. Optionally, you can try enhancing it based on your thoughts.

Apply background color for each box, based on the following categories of temperature value. Write local function in view, to determine the apppriate css class to apply background color.

  Fahrenheit is less than 44 = blue background color
  Fahrenheit is between 44 and 74 = blue background color
  Fahrenheit is greater than 74 = blue background color
The CSS file is provided as downloadable resource for applying essential styles. You can download and use it.
